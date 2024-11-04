using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ORiN3.Provider.Config;

public class ORiN3ProviderConfigMerger
{
    private static readonly Regex _providerConfigRegex = new(@"^\.orin3providerconfig.+");

    public async Task<ORiN3ProviderConfig> MergeAsync(FileInfo baseConfigFile, CancellationToken cancellationToken = default)
    {
        Debug.Assert(baseConfigFile.Directory is not null);
        var baseConfigJson = await File.ReadAllTextAsync(baseConfigFile.FullName, cancellationToken).ConfigureAwait(false);
        var baseConfig = await ORiN3ProviderConfigReader.ReadAsync(baseConfigJson, cancellationToken).ConfigureAwait(false);
        var additionalConfigTasks = Directory.GetFiles(baseConfigFile.Directory.FullName)
            .Where(fileName => _providerConfigRegex.IsMatch(Path.GetFileName(fileName)))
            .OrderBy(fileName => fileName)
            .Select(async fileName =>
            {
                var json = await File.ReadAllTextAsync(fileName, cancellationToken).ConfigureAwait(false);
                return await ORiN3ProviderConfigReader.ReadAsync(json, cancellationToken).ConfigureAwait(false);
            });
        var additionalConfigs = await Task.WhenAll(additionalConfigTasks).ConfigureAwait(false);
        var merged = additionalConfigs.Prepend(baseConfig).Aggregate(Merge);
        return merged;
    }

    public static ORiN3ProviderConfig Merge(ORiN3ProviderConfig first, ORiN3ProviderConfig second)
    {
        if (first is null)
        {
            throw new ArgumentNullException(nameof(first), $"{nameof(ORiN3ProviderConfig)}.{nameof(Merge)}()");
        }
        if (second is null)
        {
            throw new ArgumentNullException(nameof(second), $"{nameof(ORiN3ProviderConfig)}.{nameof(Merge)}()");
        }

        var providerPath = second.ProviderPath is null ? first.ProviderPath : second.ProviderPath;
        var version = second.Version is null ? first.Version : second.Version;
        var providerId = second.ProviderId is null ? first.ProviderId : second.ProviderId;
        var providerName = second.ProviderName is null ? first.ProviderName : second.ProviderName;
        var secret = second.Secret is null ? first.Secret : second.Secret;
        var author = second.Author is null ? first.Author : second.Author;
        var log = second.Log is null ? first.Log : second.Log;
        var outputLogDir = second.OutputLogDir is null ? first.OutputLogDir : second.OutputLogDir;
        var logByteSizePerFile = second.LogByteSizePerFile is null ? first.LogByteSizePerFile : second.LogByteSizePerFile;
        var logFileCountLimit = second.LogFileCountLimit is null ? first.LogFileCountLimit : second.LogFileCountLimit;
        var comments = Merge(first.Comment, second.Comment);
        var scripts = Merge(first.Scripts, second.Scripts);
        var manuals = Merge(first.Manual, second.Manual);
        var licenses = Merge(first.License, second.License);
        var classInfos = Merge(first.ClassInfos, second.ClassInfos);
        var category = second.Category is null ? first.Category : second.Category;
        return new ORiN3ProviderConfig(
            providerPath,
            version,
            classInfos,
            providerId,
            providerName,
            secret,
            author,
            comments,
            scripts,
            default,
            manuals,
            licenses,
            log,
            outputLogDir,
            logByteSizePerFile,
            logFileCountLimit,
            category);
    }

    private static ClassInfo[]? Merge(ClassInfo[]? first, ClassInfo[]? second)
    {
        if (first is null)
        {
            return second;
        }
        if (second is null)
        {
            return first;
        }

        var firstDictionary = first.ToDictionary(it => it.TypeName ?? throw new ArgumentException($"{nameof(ClassInfo.Orin3ObjectType)} is null."));
        var secondDictionary = second.ToDictionary(it => it.TypeName ?? throw new ArgumentException($"{nameof(ClassInfo.Orin3ObjectType)} is null."));
        foreach (var classInfoKey in secondDictionary.Keys)
        {
            if (!firstDictionary.ContainsKey(classInfoKey))
            {
                firstDictionary[classInfoKey] = secondDictionary[classInfoKey];
            }

            firstDictionary[classInfoKey] = Merge(firstDictionary[classInfoKey], secondDictionary[classInfoKey]);
        }

        return [.. firstDictionary.Values];
    }

    private static ClassInfo Merge(ClassInfo first, ClassInfo second)
    {
        Debug.Assert(first is not null);
        Debug.Assert(second is not null);
        var orin3ObjectType = second.Orin3ObjectType is null ? first.Orin3ObjectType : second.Orin3ObjectType;
        var typeName = second.TypeName is null ? first.TypeName : second.TypeName;
        var id = second.Id is null ? first.Id : second.Id;
        var displayName = second.DisplayName is null ? first.DisplayName : second.DisplayName;
        var configurationId = second.ConfigurationId is null ? first.ConfigurationId : second.ConfigurationId;
        var parents = first.Parents is null && second.Parents is null ? null
            : first.Parents is null ? second.Parents
            : second.Parents is null ? first.Parents
            : first.Parents.Concat(second.Parents).Distinct().ToArray();
        var comments = Merge(first.Comment, second.Comment);
        var options = Merge(first.Options, second.Options);
        return new ClassInfo(
            orin3ObjectType,
            typeName,
            parents,
            options,
            id,
            displayName,
            comments,
            configurationId);
    }

    private static Option[]? Merge(Option[]? first, Option[]? second)
    {
        if (first is null)
        {
            return second;
        }
        if (second is null)
        {
            return first;
        }

        var firstDictionary = first.ToDictionary(it => it.Name ?? throw new ArgumentException($"{nameof(Option.Name)} is null."));
        var secondDictionary = second.ToDictionary(it => it.Name ?? throw new ArgumentException($"{nameof(Option.Name)} is null."));
        foreach (var optionKey in secondDictionary.Keys)
        {
            if (!firstDictionary.ContainsKey(optionKey))
            {
                firstDictionary[optionKey] = secondDictionary[optionKey];
            }

            firstDictionary[optionKey] = Merge(firstDictionary[optionKey], secondDictionary[optionKey]);
        }

        return [.. firstDictionary.Values];
    }

    private static Option Merge(Option first, Option second)
    {
        Debug.Assert(first is not null);
        Debug.Assert(second is not null);

        var name = second.Name is null ? first.Name : second.Name;
        var @default = second.Default is null ? first.Default : second.Default;
        var optional = second.Optional;
        var comments = Merge(first.Comment, second.Comment);
        var rule = Merge(first.Rule, second.Rule);
        return new Option(
            name,
            rule,
            @default,
            optional,
            comments);
    }

    private static Rule? Merge(Rule? first, Rule? second)
    {
        if (first is null)
        {
            return second;
        }
        if (second is null)
        {
            return first;
        }

        var type = second.Type is null ? first.Type : second.Type;
        var minimum = second.Minimum is null ? first.Minimum : second.Minimum;
        var maximum = second.Maximum is null ? first.Maximum : second.Maximum;
        var pattarn = second.Pattern is null ? first.Pattern : second.Pattern;
        var secret = first.Secret | second.Secret;
        return new Rule(type, minimum, maximum, pattarn, secret);
    }

    private static Dictionary<string, string>? Merge(Dictionary<string, string>? first, Dictionary<string, string>? second)
    {
        if (first is null)
        {
            return second;
        }
        if (second is null)
        {
            return first;
        }

        var result = new Dictionary<string, string>(first);
        foreach (var key in second.Keys)
        {
            if (second[key] is not null)
            {
                result[key] = second[key];
            }
        }

        return result;
    }

    private static Script[]? Merge(Script[]? first, Script[]? second)
    {
        if (first is null)
        {
            return second;
        }
        if (second is null)
        {
            return first;
        }
        return [.. first, .. second];
    }

    private static Script Merge(Script first, Script second)
    {
        Debug.Assert(first is not null);
        Debug.Assert(second is not null);

        var command = second.Command is null ? first.Command : second.Command;
        var os = second.OS is null ? first.OS : second.OS;
        return new Script(command, os);
    }
}
