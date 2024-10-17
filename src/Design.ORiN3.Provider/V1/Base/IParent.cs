using System;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1.Base;

/// <summary>
/// Parent object interface for ORiN3 objects
/// </summary>
public interface IParent : IORiN3Object
{
    /// <summary>
    /// Get ORiN3 child object identifiers
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>ORiN3 child object identifiers.</returns>
    Task<Guid[]> GetChildIdsAsync(CancellationToken token = default);

    /// <summary>
    /// Get ORiN3 child object
    /// </summary>
    /// <param name="id">ORiN3 child object identifier</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>ORiN3 child object</returns>
    Task<IChild> GetChildAsync(Guid id, CancellationToken token = default);

    /// <summary>
    /// Get ORiN3 child object informations
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>ORiN3 child object informations.</returns>
    Task<IORiN3ObjectInformation[]> GetChildInformationsAsync(CancellationToken token = default);
}
