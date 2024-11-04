using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ORiN3.Provider.Config;

internal static class DictionaryExtension
{
    internal static bool DataEquals<T, U>(this Dictionary<T, U>? first, Dictionary<T, U>? second)
    {
        if (first is null && second is null)
        {
            return true;
        }

        if (first is null || second is null)
        {
            return false;
        }

        if (first.Count != second.Count)
        {
            return false;
        }

        for (var i = 0; i < first.Count; i++)
        {
            var firstElement = first.ElementAt(i);
            var secondElement = second.ElementAt(i);
            Debug.Assert(firstElement.Key is not null);
            Debug.Assert(firstElement.Value is not null);
            Debug.Assert(secondElement.Key is not null);
            Debug.Assert(secondElement.Value is not null);
            if (!firstElement.Key.Equals(secondElement.Key))
            {
                return false;
            }

            if (!firstElement.Value.Equals(secondElement.Value))
            {
                return false;
            }
        }

        return true;
    }
}
