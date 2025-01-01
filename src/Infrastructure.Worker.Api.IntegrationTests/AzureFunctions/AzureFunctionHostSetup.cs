using AzureFunctions.Api.WorkerHost;
using Common.Extensions;
using Common.Recording;
using Infrastructure.Hosting.Common;
using Infrastructure.Persistence.Azure.ApplicationServices;
using Infrastructure.Persistence.Interfaces;
using IntegrationTesting.Persistence.Common;
using JetBrains.Annotations;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Xunit;

namespace Infrastructure.Worker.Api.IntegrationTests.AzureFunctions;

[CollectionDefinition("AzureFunctions", DisableParallelization = true)]
public class AllAzureFunctionSpecs : ICollectionFixture<AzureFunctionHostSetup>;

[UsedImplicitly]
public class AzureFunctionHostSetup : IApiWorkerSpec, IAsyncLifetime
{
    private readonly AzuriteStorageEmulator _azurite = new();
    
    private static readonly TimeSpan FunctionTriggerWaitLatency = TimeSpan.FromSeconds(5);
    private IHost? _host;
    private Action<IServiceCollection>? _overridenTestingDependencies;

    public TService GetRequiredService<TService>()
        where TService : notnull
    {
        if (_host.NotExists())
        {
            throw new InvalidOperationException("Host has not be started yet!");
        }

        return _host.Services.GetRequiredService<TService>();
    }

    public IMessageBusStore MessageBusStore { get; private set; } = null!;

    public void OverrideTestingDependencies(Action<IServiceCollection> overrideDependencies)
    {
        _overridenTestingDependencies = overrideDependencies;
    }

    public IQueueStore QueueStore { get; private set; } = null!;

    public void StartHost()
    {
        _host = new HostBuilder()
            .ConfigureAppConfiguration(builder =>
            {
                builder
                    .AddJsonFile("appsettings.Testing.json", true)
                    .AddJsonFile("appsettings.Testing.local.json", true);
            })
            .ConfigureAzureFunctionTesting<Program>()
            .ConfigureServices((_, services) =>
            {
                if (_overridenTestingDependencies.Exists())
                {
                    _overridenTestingDependencies.Invoke(services);
                }
            })
            .Build();
        _host.Start();
    }

    // ReSharper disable once MemberCanBeMadeStatic.Global
    public void WaitForQueueProcessingToComplete()
    {
        Thread.Sleep(FunctionTriggerWaitLatency);
    }

    public async Task InitializeAsync()
    {
        await _azurite.StartAsync();

        var settings = new AspNetDynamicConfigurationSettings(new ConfigurationBuilder()
            .AddJsonFile("appsettings.Testing.json", true)
            .AddJsonFile("appsettings.Testing.local.json", true)
            .Build());

        var recorder = NoOpRecorder.Instance;
        var connectionString = _azurite.GetConnectionString();
        QueueStore = AzureStorageAccountQueueStore.Create(recorder, connectionString);
        MessageBusStore = AzureServiceBusStore.Create(recorder, settings);
    }

    public async Task DisposeAsync()
    {
        await _azurite.StopAsync();

        if (_host.Exists())
        {
            await _host.StopAsync();
            _host.Dispose();
        }
    }
}

internal static class AzureFunctionTestingExtensions
{
    /// <summary>
    ///     Configures the test process to load and run the azure functions
    /// </summary>
    public static IHostBuilder ConfigureAzureFunctionTesting<TProgram>(this IHostBuilder builder)
    {
        //HACK: this does not work yet, still waiting for the Azure Functions team to solve this problem:
        // https://github.com/Azure/azure-functions-dotnet-worker/issues/281
        return builder
            .ConfigureFunctionsWorkerDefaults()
            .InvokeAutoGeneratedConfigureMethods<TProgram>()
            .ConfigureServices((context, services) =>
            {
                services.RemoveAll<IHostedService>(); // We need remove this host to prevent gRPC running
                services.AddDependencies(context);
            });
    }

    /// <summary>
    ///     Invokes auto-generated configuration methods for a given <see cref="IHostBuilder" />.
    ///     This method searches for classes that implement the <see cref="IAutoConfigureStartup" /> interface in the assembly
    ///     of the specified type <see cref="TProgram" />.
    ///     This mimics what the <see cref="WorkerHostBuilderExtensions.ConfigureFunctionsWorkerDefaults(IHostBuilder)" />
    ///     method does on
    ///     startup in an Azure project
    /// </summary>
    private static IHostBuilder InvokeAutoGeneratedConfigureMethods<TProgram>(this IHostBuilder builder)
    {
        var startupTypes = typeof(TProgram).Assembly
            .GetTypes()
            .Where(t => typeof(IAutoConfigureStartup).IsAssignableFrom(t)
                        && t is { IsInterface: false, IsAbstract: false });

        foreach (var type in startupTypes)
        {
            var instance = (IAutoConfigureStartup)Activator.CreateInstance(type)!;
            instance.Configure(builder);
        }

        return builder;
    }
}