namespace Design.ORiN3.Provider.V1;

/// <summary>
/// Represents the result of a get operation for grouped ORiN3Variable data.
/// </summary>
public interface IGetValuesResult
{
    /// <summary>
    /// Gets a value indicating whether the get operation was successful.
    /// </summary>
    bool Succeeded { get; }

    /// <summary>
    /// Gets a detailed message about the result of the get operation.
    /// This may contain error information if the operation was not successful.
    /// </summary>
    string Detail { get; }

    /// <summary>
    /// Gets the value retrieved from the ORiN3Variable.
    /// </summary>
    object? Value { get; }
}
