using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1.Characteristic;

/// <summary>
/// The interface of the ORiN3 object that executes the command.
/// </summary>
public interface IExecutable
{
    /// <summary>
    /// Execute commands of ORiN3 objects.
    /// </summary>
    /// <param name="commandName">Name of the command to execute.</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Result of command execution.</returns>
    Task<IDictionary<string, object?>> ExecuteAsync(string commandName, CancellationToken token = default);

    /// <summary>
    /// Execute commands of ORiN3 objects.
    /// </summary>
    /// <param name="commandName">Name of the command to execute.</param>
    /// <param name="argument">Arguments of the command.</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Result of command execution.</returns>
    Task<IDictionary<string, object?>> ExecuteAsync(string commandName, IDictionary<string, object?> argument, CancellationToken token = default);
}
