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

    public void Deconstruct(
        out string? providerPath,
        out string? version,
        out ClassInfo[]? classInfos,
        out string? providerId,
        out string? providerName,
        out string? secret,
        out string? author,
        out Dictionary<string, string>? comment,
        out Script[]? scripts,
        out int? readingFileBufferSize,
        out Dictionary<string, string>? manual,
        out Dictionary<string, string>? license,
        out string? log,
        out string? outputLogDir,
        out int? logByteSizePerFile,
        out int? logFileCountLimit,
        out string? category)
    {
        providerPath = ProviderPath;
        version = Version;
        classInfos = ClassInfos;
        providerId = ProviderId;
        providerName = ProviderName;
        secret = Secret;
        author = Author;
        comment = Comment;
        scripts = Scripts;
        readingFileBufferSize = ReadingFileBufferSize;
        manual = Manual;
        license = License;
        log = Log;
        outputLogDir = OutputLogDir;
        logByteSizePerFile = LogByteSizePerFile;
        logFileCountLimit = LogFileCountLimit;
        category = Category;
    }
}
