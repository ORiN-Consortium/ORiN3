using System.Collections.Generic;
using System.Globalization;

namespace ORiN3.Provider.Config;

public static class ORiN3ProviderConfigExtensions
{
    public static string GetComment(this ORiN3ProviderConfig? providerConfig) => GetComment(providerConfig?.Comment);

    public static string GetComment(this ClassInfo? classInfo) => GetComment(classInfo?.Comment);

    public static string GetComment(this Option? option) => GetComment(option?.Comment);

    private static string GetComment(Dictionary<string, string>? commentDictionary)
    {
        var comment = string.Empty;
        if (commentDictionary != null && !commentDictionary.TryGetValue(CultureInfo.CurrentUICulture.Name, out comment))
        {
            if (!commentDictionary.TryGetValue("default", out comment))
            {
                comment = string.Empty;
            }
        }
        return comment;
    }
}
