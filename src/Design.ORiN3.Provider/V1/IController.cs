using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Characteristic;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface of the Controller object, which is an ORiN3 object
/// </summary>
public interface IController : IORiN3Object, IParent, IChild, IChildCreator, IResourceOpener, IControllerCreator
{
    /// <summary>
    /// Connecting ORiN3Controller objects to devices
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task ConnectAsync(CancellationToken token = default);

    /// <summary>
    /// Connecting ORiN3Controller objects to devices
    /// </summary>
    /// <param name="argument">Arguments for connecting to the device</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task ConnectAsync(IDictionary<string, object?> argument, CancellationToken token = default);

    /// <summary>
    /// Disconnect the ORiN3Controller object from the device
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task DisconnectAsync(CancellationToken token = default);

    /// <summary>
    /// Disconnect the ORiN3Controller object from the device
    /// </summary>
    /// <param name="argument">Arguments for disconnecting to the device</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task DisconnectAsync(IDictionary<string, object?> argument, CancellationToken token = default);
}
