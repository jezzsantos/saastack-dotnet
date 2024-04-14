using Application.Common.Extensions;
using Application.Interfaces;
using Application.Interfaces.Services;
using Application.Resources.Shared;
using Application.Services.Shared;
using Common;
using Common.Extensions;
using Domain.Common.Identity;
using Domain.Common.ValueObjects;
using Domain.Interfaces.Authorization;
using Domain.Interfaces.Services;
using Domain.Shared;
using OrganizationsApplication.Persistence;
using OrganizationsDomain;
using OrganizationOwnership = Domain.Shared.Organizations.OrganizationOwnership;

namespace OrganizationsApplication;

public partial class OrganizationsApplication : IOrganizationsApplication
{
    private readonly IEndUsersService _endUsersService;
    private readonly IIdentifierFactory _identifierFactory;
    private readonly IImagesService _imagesService;
    private readonly IRecorder _recorder;
    private readonly IOrganizationRepository _repository;
    private readonly ITenantSettingService _tenantSettingService;
    private readonly ITenantSettingsService _tenantSettingsService;

    public OrganizationsApplication(IRecorder recorder, IIdentifierFactory identifierFactory,
        ITenantSettingsService tenantSettingsService, ITenantSettingService tenantSettingService,
        IEndUsersService endUsersService, IImagesService imagesService,
        IOrganizationRepository repository)
    {
        _recorder = recorder;
        _identifierFactory = identifierFactory;
        _tenantSettingService = tenantSettingService;
        _endUsersService = endUsersService;
        _imagesService = imagesService;
        _tenantSettingsService = tenantSettingsService;
        _repository = repository;
    }

    public async Task<Result<Error>> ChangeSettingsAsync(ICallerContext caller, string id,
        TenantSettings settings, CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var org = retrieved.Value;
        var newSettings = settings.ToSettings();
        if (!newSettings.IsSuccessful)
        {
            return newSettings.Error;
        }

        var updated = org.UpdateSettings(newSettings.Value);
        if (!updated.IsSuccessful)
        {
            return updated.Error;
        }

        var saved = await _repository.SaveAsync(org, cancellationToken);
        if (!saved.IsSuccessful)
        {
            return saved.Error;
        }

        _recorder.TraceInformation(caller.ToCall(), "Updated the settings of organization: {Id}", org.Id);

        return Result.Ok;
    }

    public async Task<Result<Organization, Error>> CreateSharedOrganizationAsync(ICallerContext caller, string name,
        CancellationToken cancellationToken)
    {
        var creatorId = caller.CallerId;
        var created = await CreateOrganizationAsync(caller, creatorId, name,
            Application.Resources.Shared.OrganizationOwnership.Shared, cancellationToken);
        if (!created.IsSuccessful)
        {
            return created.Error;
        }

        return created.Value;
    }

    public async Task<Result<Organization, Error>> GetOrganizationAsync(ICallerContext caller, string id,
        CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var org = retrieved.Value;

        _recorder.TraceInformation(caller.ToCall(), "Retrieved organization: {Id}", org.Id);

        return org.ToOrganization();
    }

#if TESTINGONLY
    public async Task<Result<OrganizationWithSettings, Error>> GetOrganizationSettingsAsync(ICallerContext caller,
        string id, CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var org = retrieved.Value;

        _recorder.TraceInformation(caller.ToCall(), "Retrieved organization: {Id}", org.Id);

        return org.ToOrganizationWithSettings();
    }
#endif

    public async Task<Result<TenantSettings, Error>> GetSettingsAsync(ICallerContext caller, string id,
        CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var org = retrieved.Value;
        var settings = org.Settings;

        _recorder.TraceInformation(caller.ToCall(), "Retrieved organization: {Id} settings", org.Id);

        return settings.ToSettings();
    }

    public async Task<Result<Organization, Error>> InviteMemberToOrganizationAsync(ICallerContext caller, string id,
        string? userId, string? emailAddress, CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var organization = retrieved.Value;
        var inviterRoles = Roles.Create(caller.Roles.Tenant);
        if (!inviterRoles.IsSuccessful)
        {
            return inviterRoles.Error;
        }

        if (emailAddress.HasValue())
        {
            var email = EmailAddress.Create(emailAddress);
            if (!email.IsSuccessful)
            {
                return email.Error;
            }

            var added = organization.AddMembership(caller.ToCallerId(), inviterRoles.Value, Optional<Identifier>.None,
                email.Value);
            if (!added.IsSuccessful)
            {
                return added.Error;
            }

            var saved = await _repository.SaveAsync(organization, cancellationToken);
            if (!saved.IsSuccessful)
            {
                return saved.Error;
            }

            organization = saved.Value;
            _recorder.TraceInformation(caller.ToCall(), "Organization {Id} has invited {UserEmail} to be a member",
                organization.Id, emailAddress);

            return organization.ToOrganization();
        }

        if (userId.HasValue())
        {
            var added = organization.AddMembership(caller.ToCallerId(), inviterRoles.Value, userId.ToId(),
                Optional<EmailAddress>.None);
            if (!added.IsSuccessful)
            {
                return added.Error;
            }

            var saved = await _repository.SaveAsync(organization, cancellationToken);
            if (!saved.IsSuccessful)
            {
                return saved.Error;
            }

            organization = saved.Value;
            _recorder.TraceInformation(caller.ToCall(), "Organization {Id} has invited {UserId} to be a member",
                organization.Id, userId);

            return organization.ToOrganization();
        }

        return Error.RuleViolation(Resources.OrganizationApplication_InvitedNoUserNorEmail);
    }

    public async Task<Result<SearchResults<OrganizationMember>, Error>> ListMembersForOrganizationAsync(
        ICallerContext caller, string? id, SearchOptions searchOptions,
        GetOptions getOptions, CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var organization = retrieved.Value;
        var memberships =
            await _endUsersService.ListMembershipsForOrganizationAsync(caller, organization.Id, searchOptions,
                getOptions, cancellationToken);
        if (!memberships.IsSuccessful)
        {
            return memberships.Error;
        }

        return searchOptions.ApplyWithMetadata(memberships.Value.Results.ConvertAll(x => x.ToMember()));
    }

    public async Task<Result<Organization, Error>> ChangeAvatarAsync(ICallerContext caller, string id,
        FileUpload upload, CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var modifierRoles = Roles.Create(caller.Roles.Tenant);
        if (!modifierRoles.IsSuccessful)
        {
            return modifierRoles.Error;
        }

        var org = retrieved.Value;
        var avatared = await ChangeAvatarInternalAsync(caller, caller.ToCallerId(), modifierRoles.Value, org, upload,
            cancellationToken);
        if (!avatared.IsSuccessful)
        {
            return avatared.Error;
        }

        var saved = await _repository.SaveAsync(org, cancellationToken);
        if (!saved.IsSuccessful)
        {
            return saved.Error;
        }

        org = saved.Value;
        _recorder.TraceInformation(caller.ToCall(), "Changed avatar for organization: {Id}", org.Id);

        return org.ToOrganization();
    }

    public async Task<Result<Organization, Error>> DeleteAvatarAsync(ICallerContext caller, string id,
        CancellationToken cancellationToken)
    {
        var retrieved = await _repository.LoadAsync(id.ToId(), cancellationToken);
        if (!retrieved.IsSuccessful)
        {
            return retrieved.Error;
        }

        var deleterRoles = Roles.Create(caller.Roles.Tenant);
        if (!deleterRoles.IsSuccessful)
        {
            return deleterRoles.Error;
        }

        var org = retrieved.Value;
        var deleted = await org.DeleteAvatarAsync(caller.ToCallerId(), deleterRoles.Value, async avatarId =>
        {
            var removed = await _imagesService.DeleteImageAsync(caller, avatarId, cancellationToken);
            return !removed.IsSuccessful
                ? removed.Error
                : Result.Ok;
        });
        if (!deleted.IsSuccessful)
        {
            return deleted.Error;
        }

        var saved = await _repository.SaveAsync(org, cancellationToken);
        if (!saved.IsSuccessful)
        {
            return saved.Error;
        }

        org = saved.Value;
        _recorder.TraceInformation(caller.ToCall(), "Organization {Id} avatar was deleted", org.Id);

        return org.ToOrganization();
    }

    private async Task<Result<Organization, Error>> CreateOrganizationAsync(ICallerContext caller, string creatorId,
        string name, Application.Resources.Shared.OrganizationOwnership ownership, CancellationToken cancellationToken)
    {
        var displayName = DisplayName.Create(name);
        if (!displayName.IsSuccessful)
        {
            return displayName.Error;
        }

        var created = OrganizationRoot.Create(_recorder, _identifierFactory, _tenantSettingService,
            ownership.ToEnumOrDefault(OrganizationOwnership.Shared), creatorId.ToId(), displayName.Value);
        if (!created.IsSuccessful)
        {
            return created.Error;
        }

        var org = created.Value;
        var newSettings = await _tenantSettingsService.CreateForTenantAsync(caller, org.Id, cancellationToken);
        if (!newSettings.IsSuccessful)
        {
            return newSettings.Error;
        }

        var organizationSettings = newSettings.Value.ToSettings();
        if (!organizationSettings.IsSuccessful)
        {
            return organizationSettings.Error;
        }

        var configured = org.CreateSettings(organizationSettings.Value);
        if (!configured.IsSuccessful)
        {
            return configured.Error;
        }

        //TODO: Get the billing details for the creator and add the billing subscription for them

        var saved = await _repository.SaveAsync(org, cancellationToken);
        if (!saved.IsSuccessful)
        {
            return saved.Error;
        }

        _recorder.TraceInformation(caller.ToCall(), "Created organization: {Id}, by {CreatedBy}", org.Id,
            saved.Value.CreatedById);

        return saved.Value.ToOrganization();
    }

    private async Task<Result<Error>> ChangeAvatarInternalAsync(ICallerContext caller, Identifier modifierId,
        Roles modifierRoles,
        OrganizationRoot organization, FileUpload upload, CancellationToken cancellationToken)
    {
        return await organization.ChangeAvatarAsync(modifierId, modifierRoles, async name =>
        {
            var created = await _imagesService.CreateImageAsync(caller, upload, name.Text, cancellationToken);
            if (!created.IsSuccessful)
            {
                return created.Error;
            }

            return Avatar.Create(created.Value.Id.ToId(), created.Value.Url);
        }, async avatarId =>
        {
            var removed = await _imagesService.DeleteImageAsync(caller, avatarId, cancellationToken);
            return !removed.IsSuccessful
                ? removed.Error
                : Result.Ok;
        });
    }
}

internal static class OrganizationConversionExtensions
{
    public static OrganizationMember ToMember(this MembershipWithUserProfile membership)
    {
        var dto = new OrganizationMember
        {
            Id = membership.Id,
            UserId = membership.UserId,
            IsDefault = membership.IsDefault,
            IsRegistered = membership.Status == EndUserStatus.Registered,
            IsOwner = membership.Roles.Contains(TenantRoles.Owner.Name),
            Roles = membership.Roles,
            Features = membership.Features,
            EmailAddress = membership.Profile.EmailAddress,
            Name = membership.Profile.Name,
            Classification = membership.Profile.Classification
        };

        return dto;
    }

    public static Organization ToOrganization(this OrganizationRoot organization)
    {
        return new Organization
        {
            Id = organization.Id,
            Name = organization.Name,
            CreatedById = organization.CreatedById,
            Ownership = organization.Ownership.ToEnumOrDefault(
                Application.Resources.Shared.OrganizationOwnership.Shared),
            AvatarUrl = organization.Avatar.HasValue
                ? organization.Avatar.Value.Url
                : null
        };
    }

    public static OrganizationWithSettings ToOrganizationWithSettings(this OrganizationRoot organization)
    {
        var dto = organization.ToOrganization().Convert<Organization, OrganizationWithSettings>();
        dto.Settings =
            organization.Settings.Properties.ToDictionary(pair => pair.Key,
                pair => pair.Value.Value.ToString() ?? string.Empty);
        return dto;
    }

    public static Result<Settings, Error> ToSettings(this TenantSettings tenantSettings)
    {
        var settings = Settings.Empty;
        foreach (var (key, tenantSetting) in tenantSettings)
        {
            if (tenantSetting.Value.NotExists())
            {
                continue;
            }

            var value = tenantSetting.Value;
            var setting = Setting.Create(value, tenantSetting.IsEncrypted);
            if (!setting.IsSuccessful)
            {
                return setting.Error;
            }

            var added = settings.AddOrUpdate(key, setting.Value);
            if (!added.IsSuccessful)
            {
                return added.Error;
            }

            settings = added.Value;
        }

        return settings;
    }

    public static TenantSettings ToSettings(this Settings settings)
    {
        var dictionary = settings.Properties.ToDictionary(pair => pair.Key, pair => new TenantSetting
        {
            Value = pair.Value.Value,
            IsEncrypted = pair.Value.IsEncrypted
        });

        return new TenantSettings(dictionary);
    }
}