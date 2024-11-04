using System;
using System.Collections.Generic;

namespace ORiN3.Provider.Config;

public record ClassInfo
    (
        string? Orin3ObjectType,
        string? TypeName,
        string[]? Parents,
        Option[]? Options,
        string? Id,
        string? DisplayName,
        Dictionary<string, string>? Comment,
        string? ConfigurationId
    )
{
    public bool Is(string id)
    {
        if (string.IsNullOrWhiteSpace(Id))
        {
            return TypeName == id;
        }
        else
        {
            return Id == id;
        }
    }

    public string UniqueId
    {
        get
        {
            var uniqueId = Id ?? TypeName;
            return uniqueId is null ? throw new FormatException($"No {nameof(Id)} and {nameof(TypeName)} in the class info object.") : uniqueId;
        }
    }

    public string ActualDisplayName
    {
        get
        {
            var displayName = DisplayName ?? TypeName;
            return displayName is null
                ? throw new FormatException($"No {nameof(DisplayName)} and {nameof(TypeName)} in the class info object.")
                : displayName;
        }
    }

    internal bool EqualsSpecifically(ClassInfo compared)
    {
        bool parentsEquals(string[]? first, string[]? second)
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
                if (!first[i].Equals(second[i]))
                {
                    return false;
                }
            }

            return true;
        }

        bool optionsEquals(Option[]? first, Option[]? second)
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

        return Orin3ObjectType == compared.Orin3ObjectType
            && TypeName == compared.TypeName
            && Id == compared.Id
            && DisplayName == compared.DisplayName
            && ConfigurationId == compared.ConfigurationId
            && Comment.DataEquals(compared.Comment)
            && parentsEquals(Parents, compared.Parents)
            && optionsEquals(Options, compared.Options);
    }
}
