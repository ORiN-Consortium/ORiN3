using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace ORiN3.Provider.Config;

public record ORiN3ProviderConfig
(
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
    string? Category
)
{
    [JsonIgnore]
    internal DirectoryInfo? BaseDirectory { get; set; }

    /// <summary>
    /// A full paths of ProviderPath.
    /// </summary>
    [JsonIgnore]
    public string ProvidersFullPath => GetFullPath(ProviderPath);

    /// <summary>
    /// 
    /// </summary>
    [JsonIgnore]
    private string AssemblyName
    {
        get
        {
            if (ProviderPath is null)
            {
                throw new FormatException($"No {nameof(ProviderPath)} in the orin3 provider config data.");
            }
            return new FileInfo(ProviderPath).Name;
        }
    }

    /// <summary>
    /// The unique id. It returns ProviderId. If ProviderId is null, it returns AssemblyName
    /// </summary>
    [JsonIgnore]
    public string UniqueId => ProviderId ?? AssemblyName;

    /// <summary>
    /// The actual provider's name. It returns ProviderName. If ProviderName is null, it returns AssemblyName
    /// </summary>
    [JsonIgnore]
    public string ActualProviderName => ProviderName ?? AssemblyName;

    [JsonIgnore]
    public string SecretKey => Secret ?? UniqueId;

    public bool EqualsSpecifically(ORiN3ProviderConfig compared)
    {
        bool classInfosEquals(ClassInfo[]? first, ClassInfo[]? second)
        {
            if (first is null && second is null)
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }

            if (first.Length != second.Length)
            {
                return false;
            }

            for (var i = 0; i < first.Length; i++)
            {
                if (!first[i].EqualsSpecifically(second[i]))
                {
                    return false;
                }
            }

            return true;
        }

        bool scriptsEquals(Script[]? first, Script[]? second)
        {
            if (first is null && second is null)
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }

            if (first.Length != second.Length)
            {
                return false;
            }

            for (var i = 0; i < first.Length; i++)
            {
                if (!first[i].EqualsSpecifically(second[i]))
                {
                    return false;
                }
            }

            return true;
        }

        return ProviderPath == compared.ProviderPath
            && Version == compared.Version
            && ProviderId == compared.ProviderId
            && ProviderName == compared.ProviderName
            && Author == compared.Author
            && Log == compared.Log
            && OutputLogDir == compared.OutputLogDir
            && LogByteSizePerFile == compared.LogByteSizePerFile
            && LogFileCountLimit == compared.LogFileCountLimit
            && Comment.DataEquals(compared.Comment)
            && Manual.DataEquals(compared.Manual)
            && License.DataEquals(compared.License)
            && classInfosEquals(ClassInfos, compared.ClassInfos)
            && scriptsEquals(Scripts, compared.Scripts)
            && Category == compared.Category;
    }

    private string GetFullPath(string? path)
    {
        if (path is null)
        {
            throw new InvalidOperationException("The path was not set.");
        }
        if (BaseDirectory is null)
        {
            throw new InvalidOperationException($"Cannot get full path of {path} because base directory is null.");
        }
        return Path.IsPathRooted(path) ? path : Path.GetFullPath(path, BaseDirectory.FullName);
    }

    public string GetDefaultOptions(Option[] options)
    {
        var dict = new Dictionary<string, object?>
            {
                { "@Version", Version ?? string.Empty }
            };
        foreach (var option in options)
        {
            if (option.Optional || option.Name is null)
            {
                continue;
            }
            dict[option.Name] = option.Default;
        }
        return JsonHelper.Serialize(dict);
    }
}
