namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Interface of the Root object information
/// </summary>
public interface IRootObjectInformation
{
    /// <summary>
    /// The contents of .orin3providerconfig of the ORiN3 provider
    /// </summary>
    string ORiN3ProviderConfig { get; }

    /// <summary>
    /// The number of active socket connections
    /// </summary>
    int ConnectionCount { get; }
}
