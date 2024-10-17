using Design.ORiN3.Provider.V1.Characteristic;
using Design.ORiN3.Provider.V1.Type;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1.Base;

/// <summary>
/// ORiN3 object status
/// </summary>
[Flags]
public enum ORiN3ObjectStatus
{
    /// <summary>
    /// 
    /// </summary>
    Mask = 0b_00000000_0000000_00000000_11111111,

    /// <summary>
    /// Alive or Dead
    /// </summary>
    Alive = 0b_00000000_0000000_00000000_00000001,

    /// <summary>
    /// Opend or Closed
    /// </summary>
    Opened = 0b_00000000_0000000_00000000_00000010,

    /// <summary>
    /// Connected or Disconnected
    /// </summary>
    Connected = 0b_00000000_0000000_00000000_00000010,

    /// <summary>
    /// Started or Stopped
    /// </summary>
    Started = 0b_00000000_0000000_00000000_00000010,

    /// <summary>
    /// Done or Not
    /// </summary>
    Done = 0b_00000000_0000000_00000000_00000100,
}

/// <summary>
/// Base interface for ORiN3 objects
/// </summary>
public interface IORiN3Object : IExecutable
{
    /// <summary>
    /// ID to identify the ORiN3 object
    /// </summary>
    /// <remarks>
    /// Unique for each ORiN3 object.
    /// </remarks>
    Guid Id { get; }

    /// <summary>
    /// ORiN3 object type
    /// </summary>
    ORiN3ObjectType ORiN3ObjectType { get; }

    /// <summary>
    /// Creation date and time of the ORiN3 object
    /// </summary>
    DateTime CreatedDateTime { get; }

    /// <summary>
    /// Name
    /// </summary>
    /// <remarks>
    /// It can be used to identify ORiN3 objects in the application layer, but it does not check for duplicate names in the ORiN3 layer.
    /// </remarks>
    string Name { get; }

    /// <summary>
    /// TypeName
    /// </summary>
    /// <remarks>
    /// Type name of the ORiN3 object
    /// </remarks>
    string TypeName { get; }

    /// <summary>
    /// Options used to create the ORiN3 object
    /// </summary>
    /// <remarks>
    /// If the object is destroyed, it will be empty.
    /// </remarks>
    string Option { get; }

    /// <summary>
    /// Get an arbitrary object (Tag) by specifying a key
    /// </summary>
    /// <param name="key">A key to bind to an arbitrary object</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>An arbitrary object</returns>
    Task<object?> GetTagAsync(string key, CancellationToken token = default);

    /// <summary>
    /// Set an arbitrary object (Tag) by specifying a key
    /// </summary>
    /// <param name="key">A key to bind to an arbitrary object</param>
    /// <param name="tag">An arbitrary object</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task SetTagAsync(string key, object? tag, CancellationToken token = default);

    /// <summary>
    /// Get keys of an arbitrary object (Tag) 
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns></returns>
    Task<string[]> GetTagKeysAsync(CancellationToken token = default);

    /// <summary>
    /// Remove an arbitrary object (Tag) by specifying a key
    /// </summary>
    /// <param name="key">A key to bind to an arbitrary object</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns></returns>
    Task RemoveTagAsync(string key, CancellationToken token = default);

    /// <summary>
    /// Get the status of an ORiN3 instance
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>State of the instance. Each state is stored in a bit flag</returns>
    Task<int> GetStatusAsync(CancellationToken token = default);
}
