using System.Collections.Generic;

namespace ORiN3.Provider.Config;

public record Option(
    string? Name,
    Rule? Rule,
    object? Default,
    bool Optional,
    Dictionary<string, string>? Comment
    )
{
    internal bool EqualsSpecifically(Option compared)
    {
        return Name == compared.Name
            && Rule == compared.Rule
            && Default == compared.Default
            && Optional == compared.Optional
            && Comment.DataEquals(compared.Comment);
    }
}
