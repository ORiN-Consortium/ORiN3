namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Represents the result of a set operation for grouped ORiN3Variable data.
/// </summary>
public interface ISetValuesResult
{
    /// <summary>
    /// Gets a value indicating whether the set operation was successful.
    /// </summary>
    bool Succeeded { get; }

    /// <summary>
    /// Gets a detailed message about the result of the set operation.
    /// This may contain error information if the operation was not successful.
    /// </summary>
    string Detail { get; }
}
