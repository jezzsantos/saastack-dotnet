using Common;

namespace Application.Persistence.Interfaces;

/// <summary>
///     Defines a Application Layer repository (port)
/// </summary>
public interface IApplicationRepository
{
    /// <summary>
    ///     Permanently destroys all records in the repository
    /// </summary>
    Task<Result<Error>> DestroyAllAsync(CancellationToken cancellationToken);
}