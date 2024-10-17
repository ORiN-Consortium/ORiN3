using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Characteristic;
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
}
