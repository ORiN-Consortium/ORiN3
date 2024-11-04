using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace ORiN3.Provider.Config;

internal static class JsonHelper
{
    private static readonly JsonSerializerOptions _serializerOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
    };

    public static string Serialize<T>(T value)
    {
        return JsonSerializer.Serialize(value, _serializerOptions);
    }

    public static async ValueTask<T?> DeserializeAsync<T>(string json, CancellationToken cancellationToken = default)
    {
        using var utf8Json = new MemoryStream(Encoding.UTF8.GetBytes(json));
        return await DeserializeAsync<T>(utf8Json, cancellationToken).ConfigureAwait(false);
    }

    public static async Task<T?> DeserializeAsync<T>(FileInfo file, CancellationToken cancellationToken = default)
    {
        using var stream = File.OpenRead(file.FullName);
        return await DeserializeAsync<T>(stream, cancellationToken).ConfigureAwait(false);
    }

    public static ValueTask<T?> DeserializeAsync<T>(Stream utf8Json, CancellationToken cancellationToken = default)
    {
        return JsonSerializer.DeserializeAsync<T>(utf8Json, _serializerOptions, cancellationToken);
    }
}
