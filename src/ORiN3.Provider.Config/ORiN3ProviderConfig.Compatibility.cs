using System.Collections.Generic;

namespace ORiN3.Provider.Config;

public partial record ORiN3ProviderConfig
{
#pragma warning disable IDE1006 // Preserve the parameter names of the generated constructor for named arguments.
    public ORiN3ProviderConfig(
        string? ProviderPath,
        string? Version,
        ClassInfo[]? ClassInfos,
        string? ProviderId,
        string? ProviderName,
        string? Secret,
        string? Author,
        Dictionary<string, string>? Comment,
        Script[]? Scripts,
        int? ReadingFileBufferSize,
        Dictionary<string, string>? Manual,
        Dictionary<string, string>? License,
        string? Log,
        string? OutputLogDir,
        int? LogByteSizePerFile,
        int? LogFileCountLimit,
        string? Category)
        : this(
            ProviderPath,
            Version,
            null,
            ClassInfos,
            ProviderId,
            ProviderName,
            Secret,
            Author,
            Comment,
            Scripts,
            ReadingFileBufferSize,
            Manual,
            License,
            Log,
            OutputLogDir,
            LogByteSizePerFile,
            LogFileCountLimit,
            Category)
    {
    }
#pragma warning restore IDE1006
}
