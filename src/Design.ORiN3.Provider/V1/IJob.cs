using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Characteristic;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface of the Job object, an ORiN3 object.
/// </summary>
public interface IJob : IORiN3Object, IChild, IResourceOpener
{
    /// <summary>
    /// Start Execution
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task StartAsync(CancellationToken token = default);

    /// <summary>
    /// Start Execution
    /// </summary>
    /// <param name="argument">Arguments to be passed at runtime</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task StartAsync(IDictionary<string, object?> argument, CancellationToken token = default);

    /// <summary>
    /// Stop execution
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task StopAsync(CancellationToken token = default);

    /// <summary>
    /// Stop execution
    /// </summary>
    /// <param name="argument">Arguments to be passed at runtime</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task StopAsync(IDictionary<string, object?> argument, CancellationToken token = default);

    /// <summary>
    /// Get the contents equivalent to the standard output at runtime as a string
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>String with content equivalent to the current standard output</returns>
    Task<string> GetStandardOutputAsync(CancellationToken token = default);

    /// <summary>
    /// Get the contents equivalent to the standard error output at runtime as a string
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>String with content equivalent to the current standard error output</returns>
    Task<string> GetStandardErrorAsync(CancellationToken token = default);

    /// <summary>
    /// Get execution result
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Execution Result</returns>
    Task<object?> GetResultAsync(CancellationToken token = default);
}