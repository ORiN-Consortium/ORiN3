using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Common.V1;

/// <summary>
/// Class used to branch the process for each object type in ORiN3. (asynchronous version)
/// </summary>
public interface IObjectTypeBranchAsync
{
    /// <summary>
    /// For provider root
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfProviderRoot(CancellationToken token = default);

    /// <summary>
    /// For controller
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfController(CancellationToken token = default);

    /// <summary>
    /// For module
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfModule(CancellationToken token = default);

    /// <summary>
    /// For variable
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfVariable(CancellationToken token = default);

    /// <summary>
    /// For file
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfFile(CancellationToken token = default);

    /// <summary>
    /// For event
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfEvent(CancellationToken token = default);

    /// <summary>
    /// For job
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfJob(CancellationToken token = default);

    /// <summary>
    /// For stream
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfStream(CancellationToken token = default);

    /// <summary>
    /// For error
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CaseOfError(CancellationToken token = default);
}
