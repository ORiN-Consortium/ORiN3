using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1.Characteristic;

/// <summary>
/// The interface of ORiN3 objects that need to open/close resources.
/// </summary>
public interface IResourceOpener
{
    /// <summary>
    /// Open a resource of ORiN3 object
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task OpenAsync(CancellationToken token = default);

    /// <summary>
    /// Open a resource of ORiN3 object
    /// </summary>
    /// <param name="argument">Arguments for opening the resource</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task OpenAsync(IDictionary<string, object?> argument, CancellationToken token = default);

    /// <summary>
    /// Closes the resource of the ORiN3 object
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task CloseAsync(CancellationToken token = default);

    /// <summary>
    /// Closes the resource of the ORiN3 object
    /// </summary>
    /// <param name="argument">Arguments for closing the resource</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task CloseAsync(IDictionary<string, object?> argument, CancellationToken token = default);
}
