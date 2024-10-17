using System.Threading;
using System.Threading.Tasks;

namespace Design.ORiN3.Provider.V1.Characteristic;

/// <summary>
/// The interface of the ORiN3 object, which creates an ORiN3Controller object for the child object
/// </summary>
public interface IControllerCreator
{
    /// <summary>
    /// An ORiN3Controller instance is created as a child instance of an ORiN3 object
    /// </summary>
    /// <param name="name">Name to be set for the ORiN3Controller instance</param>
    /// <param name="typeName">Name representing the type of ORiN3Controller</param>
    /// <param name="option">Option string</param>
    /// <param name="token">A cancellation token that can be used to signal the asynchronous operation should be canceled</param>
    /// <returns>Generated ORiN3Controller instance</returns>
    Task<IController> CreateControllerAsync(string name, string typeName, string option, CancellationToken token = default);
}
