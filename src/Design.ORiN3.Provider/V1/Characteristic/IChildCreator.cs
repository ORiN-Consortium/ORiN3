using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1.Characteristic;

/// <summary>
/// Child creator interface for ORiN3 objects
/// </summary>
public interface IChildCreator
{
    /// <summary>
    /// An ORiN3Variable instance is created as a child instance of an ORiN3 object
    /// </summary>
    /// <typeparam name="T">ORiN3Variable object value type</typeparam>
    /// <param name="name">Name to be set for the ORiN3Variable instance</param>
    /// <param name="typeName">Name representing the type of ORiN3Variable</param>
    /// <param name="option">Option string</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Generated ORiN3Variable instance</returns>
    Task<IVariable<T>> CreateVariableAsync<T>(string name, string typeName, string option, CancellationToken token = default);

    /// <summary>
    /// An ORiN3Event instance is created as a child instance of an ORiN3 object
    /// </summary>
    /// <param name="name">Name to be set for the ORiN3Event instance</param>
    /// <param name="typeName">Name representing the type of ORiN3Event</param>
    /// <param name="option">Option string</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Generated ORiN3Event instance</returns>
    Task<IEvent> CreateEventAsync(string name, string typeName, string option, CancellationToken token = default);

    /// <summary>
    /// An ORiN3File instance is created as a child instance of an ORiN3 object
    /// </summary>
    /// <param name="name">Name to be set for the ORiN3File instance</param>
    /// <param name="typeName">Name representing the type of ORiN3File</param>
    /// <param name="option">Option string</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Generated ORiN3File instance</returns>
    Task<IFile> CreateFileAsync(string name, string typeName, string option, CancellationToken token = default);

    /// <summary>
    /// An ORiN3Stream instance is created as a child instance of an ORiN3 object
    /// </summary>
    /// <param name="name">Name to be set for the ORiN3Stream instance</param>
    /// <param name="typeName">Name representing the type of ORiN3Stream</param>
    /// <param name="option">Option string</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Generated ORiN3Stream instance</returns>
    Task<IStream> CreateStreamAsync(string name, string typeName, string option, CancellationToken token = default);

    /// <summary>
    /// An ORiN3Job instance is created as a child instance of an ORiN3 object
    /// </summary>
    /// <param name="name">Name to be set for the ORiN3Job instance</param>
    /// <param name="typeName">Name representing the type of ORiN3Job</param>
    /// <param name="option">Option string</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Generated ORiN3Job instance</returns>
    Task<IJob> CreateJobAsync(string name, string typeName, string option, CancellationToken token = default);

    /// <summary>
    /// An ORiN3Module instance is created as a child instance of an ORiN3 object
    /// </summary>
    /// <param name="name">Name to be set for the ORiN3Module instance</param>
    /// <param name="typeName">Name representing the type of ORiN3Module</param>
    /// <param name="option">Option string</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Generated ORiN3Module instance</returns>
    Task<IModule> CreateModuleAsync(string name, string typeName, string option, CancellationToken token = default);
}
