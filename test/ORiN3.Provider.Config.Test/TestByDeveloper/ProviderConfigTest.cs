using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Xunit;

namespace ORiN3.Provider.Config.Test.TestByDeveloper;

public class ProviderConfigTest
{
    [SkippableFact(DisplayName = "Check that ProvidersFullPath is full path")]
    [Trait("Category", nameof(ProviderConfigTest))]
    public async Task ProviderConfigTest01()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.OSX), "This test is not supported on macOS");

        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_simple");
        file.Attributes &= ~FileAttributes.Hidden;
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        Assert.True(Path.IsPathRooted(orin3ProviderConfig.ProvidersFullPath));
    }

    [SkippableFact(DisplayName = "Check that UniqueId is ProviderId, if ProviderId exists")]
    [Trait("Category", nameof(ProviderConfigTest))]
    public async Task ProviderConfigTest05()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.OSX), "This test is not supported on macOS");

        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        file.Attributes &= ~FileAttributes.Hidden;
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        Assert.Equal(orin3ProviderConfig.ProviderId, orin3ProviderConfig.UniqueId);
    }

    [SkippableFact(DisplayName = "Check that UniqueId is AssemblyName, if ProviderId does not exists")]
    [Trait("Category", nameof(ProviderConfigTest))]
    public async Task ProviderConfigTest06()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.OSX), "This test is not supported on macOS");

        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_simple");
        file.Attributes &= ~FileAttributes.Hidden;
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        Assert.Equal("Hoge.dll", orin3ProviderConfig.UniqueId);
    }

    [SkippableFact(DisplayName = "Check that the returned value of GetDefaultOptions is not null or empty")]
    [Trait("Category", nameof(ProviderConfigTest))]
    public async Task ProviderConfigTest07()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.OSX), "This test is not supported on macOS");

        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        file.Attributes &= ~FileAttributes.Hidden;
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        foreach (var classInfo in orin3ProviderConfig.ClassInfos)
        {
            var options = orin3ProviderConfig.GetDefaultOptions(classInfo.Options);
            Assert.NotNull(options);
            Assert.NotEmpty(options);
        }
    }

    //[Theory(DisplayName = "Check that various options are substituted to GetDefaultOptions")]
    //[Trait("Category", nameof(ProviderConfigTest))]
    //[MemberData(nameof(GetOptionData))]
    //public async Task ProviderConfigTest08(string optiondata)
    //{
    //    var dict = Colda.CommonUtilities.JsonHelper.DeserializeAsDictionaryRecursive(optiondata);
    //    var option = new Option((string)dict["name"], null, dict["default"], false, null);

    //    var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_simple");
    //    var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);

    //    var options = orin3ProviderConfig.GetDefaultOptions([option]);
    //    Assert.NotNull(options);
    //    Assert.NotEmpty(options);
    //}

    //public static IEnumerable<object[]> GetOptionData()
    //{
    //    // default is Int64.MaxValue
    //    yield return new object[] {
    //        @"{ ""name"": ""test"", 
    //                ""default"": 9223372036854775807
    //            }"
    //    };
    //    // default is Int64.MaxValue + 1
    //    yield return new object[] {
    //        @"{ ""name"": ""test"", 
    //                 ""default"": 9223372036854775808
    //            }"
    //    };
    //    //  default is floating-point number
    //    yield return new object[] {
    //        @"{ ""name"": ""test"",
    //                ""default"": 1.1
    //            }"
    //    };
    //}

    [Fact(DisplayName = "Check GetDefaultOptions without version")]
    [Trait("Category", nameof(ProviderConfigTest))]
    public async Task ProviderConfigTest09()
    {
        var configdata = @"{
                   ""classInfos"": [
                        {
                            ""options"": [
                                {
                                      ""name"": ""test"",
                                }
                            ]
                        }
                    ]
                }";
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(configdata);
        var options = orin3ProviderConfig.GetDefaultOptions(orin3ProviderConfig.ClassInfos[0].Options);
        Assert.NotNull(options);
        Assert.NotEmpty(options);
    }

    [SkippableFact(DisplayName = "Check that ActualProviderName is ProviderId, if ProviderName exists")]
    [Trait("Category", nameof(ProviderConfigTest))]
    public async Task ProviderConfigTest10()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.OSX), "This test is not supported on macOS");

        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        file.Attributes &= ~FileAttributes.Hidden;
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        Assert.Equal(orin3ProviderConfig.ProviderName, orin3ProviderConfig.ActualProviderName);
    }

    [SkippableFact(DisplayName = "Check that UniqueId is AssemblyName, if ProviderName does not exists")]
    [Trait("Category", nameof(ProviderConfigTest))]
    public async Task ProviderConfigTest11()
    {
        Skip.If(RuntimeInformation.IsOSPlatform(OSPlatform.OSX), "This test is not supported on macOS");

        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_simple");
        file.Attributes &= ~FileAttributes.Hidden;
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        Assert.Equal("Hoge.dll", orin3ProviderConfig.ActualProviderName);
    }
}
