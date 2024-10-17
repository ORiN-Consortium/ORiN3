namespace Design.ORiN3.Provider.V1.Type;

/// <summary>
/// Types of object available in ORiN3
/// </summary>
public enum ORiN3ObjectType
{
    /// <summary>
    /// Root of ORiN3
    /// </summary>
    ProviderRoot = 0,

    /// <summary>
    /// Controller of ORiN3
    /// </summary>
    Controller = 1,

    /// <summary>
    /// Module of ORiN3
    /// </summary>
    Module = 2,

    /// <summary>
    /// Variable of ORiN3
    /// </summary>
    Variable = 3,

    /// <summary>
    /// File of ORiN3
    /// </summary>
    File = 4,

    /// <summary>
    /// Stream of ORiN3
    /// </summary>
    Stream = 5,

    /// <summary>
    /// Event of ORiN3
    /// </summary>
    Event = 6,

    /// <summary>
    /// Job of ORiN3
    /// </summary>
    Job = 7,
}
