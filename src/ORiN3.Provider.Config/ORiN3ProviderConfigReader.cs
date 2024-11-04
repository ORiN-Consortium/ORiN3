using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ORiN3.Provider.Config;

public static class ORiN3ProviderConfigReader
{
    public static async Task<ORiN3ProviderConfig> ReadAsync(FileInfo file, CancellationToken cancellationToken = default)
    {
        var orin3ProviderConfig = await JsonHelper.DeserializeAsync<ORiN3ProviderConfig>(file, cancellationToken).ConfigureAwait(false) ?? throw new InvalidOperationException("Failed to read config file.");
        orin3ProviderConfig.BaseDirectory = file.Directory;
        return orin3ProviderConfig;
    }

    public static async Task<ORiN3ProviderConfig> ReadAsync(string json, CancellationToken cancellationToken = default)
    {
        var orin3Providerconfig = await JsonHelper.DeserializeAsync<ORiN3ProviderConfig>(json, cancellationToken).ConfigureAwait(false);
        return orin3Providerconfig is null ? throw new InvalidOperationException("Failed to read config text.") : orin3Providerconfig;
    }
}
