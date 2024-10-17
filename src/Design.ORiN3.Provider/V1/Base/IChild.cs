using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1.Base;

/// <summary>
/// Child object interface for ORiN3 objects
/// </summary>
public interface IChild : IORiN3Object
{
    /// <summary>
    /// Get ORiN3 parent object
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>ORiN3 parent object</returns>
    Task<IParent> GetParentAsync(CancellationToken token = default);

    /// <summary>
    /// Delete the IChild
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task DeleteAsync(CancellationToken token = default);
}
