using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Characteristic;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Specifies the position in a stream to use for seeking
/// </summary>
public enum ORiN3FileSeekOrigin
{
    /// <summary>
    /// Specifies the beginning of a stream
    /// </summary>
    Begin,

    /// <summary>
    /// Specifies the current position within a stream
    /// </summary>
    Current,

    /// <summary>
    /// Specifies the end of a stream
    /// </summary>
    End
}

/// <summary>
/// Interface of the File object, an ORiN3 object.
/// </summary>
public interface IFile : IORiN3Object, IChild, IResourceOpener
{
    /// <summary>
    /// Read from the file pointer at the current position
    /// </summary>
    /// <param name="buffer">Buffer of data to be read. The read data is stored here.</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Size of data read</returns>
    Task<int> ReadAsync(Memory<byte> buffer, CancellationToken token = default);

    /// <summary>
    /// Write to the file pointer at the current location
    /// </summary>
    /// <param name="buffer">Data to write</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken token = default);

    /// <summary>
    /// Move a file to a specific read/write position
    /// </summary>
    /// <param name="offset">Seek position</param>
    /// <param name="origin">Position of stream used for seek</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Read/write position after move</returns>
    Task<long> SeekAsync(long offset, ORiN3FileSeekOrigin origin, CancellationToken token = default);

    /// <summary>
    /// Whether the file can be read or not
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Read permission</returns>
    Task<bool> CanReadAsync(CancellationToken token = default);

    /// <summary>
    /// Whether the file is writable or not
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Write permission</returns>
    Task<bool> CanWriteAsync(CancellationToken token = default);

    /// <summary>
    /// Get file size
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>file size</returns>
    Task<long> GetLengthAsync(CancellationToken token = default);

    /// <summary>
    /// Set file size
    /// </summary>
    /// <param name="value">file size</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task SetLengthAsync(long value, CancellationToken token = default);
}