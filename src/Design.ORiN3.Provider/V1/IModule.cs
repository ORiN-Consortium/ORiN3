using Design.ORiN3.Provider.V1.Base;
using Design.ORiN3.Provider.V1.Characteristic;

namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface of the Module object, an ORiN3 object
/// </summary>
public interface IModule : IORiN3Object, IParent, IChild, IChildCreator
{
}
