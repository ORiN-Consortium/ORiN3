using System.Text.Json.Serialization;

namespace ORiN3.Provider.Config;

public record Script(string Command, [property: JsonPropertyName("os")] string OS)
{
    internal bool EqualsSpecifically(Script compared)
    {
        return Command == compared.Command
            && OS == compared.OS;
    }
}
