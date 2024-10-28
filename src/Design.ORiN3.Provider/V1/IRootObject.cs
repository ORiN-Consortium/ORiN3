using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Characteristic;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface of the Root object, which is an ORiN3 object.
/// </summary>
public interface IRootObject : IORiN3Object, IParent, IChildCreator, IControllerCreator
{
    /// <summary>
    /// Get the contents of .orin3providerconfig of the ORiN3 provider
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Contents of the .orin3providerconfig file</returns>
    Task<string> GetInformationAsync(CancellationToken token = default);

    /// <summary>
    /// Id given to the provider by RemoteEngine
    /// </summary>
    Guid UserDefinedId { get; }

    /// <summary>
    /// Stop the ORiN3 provider process
    /// </summary>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task ShutdownAsync(CancellationToken token = default);

    /// <summary>
    /// Group and register ORiN3Variable
    /// </summary>
    /// <param name="variableIds">GUID list of ORiN3Varaible to be grouped</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Registered group identifier</returns>
    Task<int> RegisterValuesAsync(Guid[] variableIds, CancellationToken token = default);

    /// <summary>
    /// Unregister the grouped ORiN3Variable
    /// </summary>
    /// <param name="registrationId">Registered group identifier</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>The task object representing the asynchronous operation</returns>
    Task UnregisterValuesAsync(int registrationId, CancellationToken token = default);

    /// <summary>
    /// Batch acquisition of grouped ORiN3Variable data
    /// </summary>
    /// <param name="registrationId">Registered group identifier</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Data acquired in batch</returns>
    Task<IGetValuesResult[]> GetValuesAsync(int registrationId, CancellationToken token = default);

    /// <summary>
    /// Batch writing of grouped ORiN3 variable data
    /// </summary>
    /// <param name="registrationId">Registered group identifier</param>
    /// <param name="values">Values to set</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Setting results</returns>
    Task<ISetValuesResult[]> SetValuesAsync(int registrationId, object?[] values, CancellationToken token = default);

    /// <summary>
    /// Batch acquisition of ORiN3Object status
    /// </summary>
    /// <param name="ids">GUID list of ORiN3Object</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>ORiN3Object statuses</returns>
    Task<int[]> GetStatusesAsync(Guid[] ids, CancellationToken token = default);
}
