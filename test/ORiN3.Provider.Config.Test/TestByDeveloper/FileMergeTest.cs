﻿using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace ORiN3.Provider.Config.Test.TestByDeveloper;

public class FileMergeTest
{
    [Fact(DisplayName = "Configファイルのマージ")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    public async Task Test001()
    {
        var sut = new ORiN3ProviderConfigMerger();

        // act
        var actual = await sut.MergeAsync(new FileInfo(Path.Combine("TestByDeveloper", "TestData", "Merge", ".orin3providerconfig"))).ConfigureAwait(true);

        // assert
        Assert.Equal("Prov.dll", actual.ProviderPath);
        Assert.Equal("second", actual.Author);
        Assert.Equal("2.0.0", actual.Version);
    }
}