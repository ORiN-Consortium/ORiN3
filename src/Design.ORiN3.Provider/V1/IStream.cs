using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Characteristic;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface of the Stream object, an ORiN3 object
/// </summary>
public interface IStream : IORiN3Object, IChild, IResourceOpener
{
    /// <summary>
    /// Asynchronously reads a sequence of bytes from the current stream and advances the position
    /// within the stream by the number of bytes read, and monitors cancellation requests.
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>
    /// Returns the read data in an asynchronous stream.
    /// </returns>
    IAsyncEnumerable<ReadOnlyMemory<byte>> ReadAsync(CancellationToken token = default);
}