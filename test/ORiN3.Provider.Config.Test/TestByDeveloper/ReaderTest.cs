using System.IO;
using Xunit;

namespace ORiN3.Provider.Config.Test.TestByDeveloper;

public class ReaderTest
{
    [Fact(DisplayName = "read a .orin3providerconfig test")]
    [Trait("Category", nameof(ORiN3ProviderConfigReader))]
    public async void ReadTest01()
    {
        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        Assert.Equal("ORiN3.Provider.ORiNConsortium.Mock.dll", orin3ProviderConfig.ProviderPath);
        Assert.Equal("1.0.0", orin3ProviderConfig.Version);
        Assert.Equal("643D12C8-DCFC-476C-AA15-E8CA004F48E8", orin3ProviderConfig.ProviderId);
        Assert.Equal("ORiNConsortium Mock Provider", orin3ProviderConfig.ProviderName);
        Assert.Equal("ORiN Consortium", orin3ProviderConfig.Author);
        Assert.Equal("This provider can rate ORiN3 in an environment without actual equipment.", orin3ProviderConfig.Comment["default"]);
        Assert.Equal("実機がない環境でORiN3の評価が行えるプロバイダです。", orin3ProviderConfig.Comment["ja-JP"]);
        Assert.Equal("Category", orin3ProviderConfig.Category);
        var classInfos = orin3ProviderConfig.ClassInfos;
        {
            var classInfo = classInfos[0];
            Assert.Equal("136270FE-E793-42CA-89A9-29AD2B6AB952", classInfo.Id);
            Assert.Equal("ORiN3Controller", classInfo.Orin3ObjectType);
            Assert.Equal("General Purpose Controller", classInfo.DisplayName);
            Assert.Equal("ORiN3.Provider.ORiNConsortium.Mock.O3Object.Controller.GeneralPurposeController, ORiN3.Provider.ORiNConsortium.Mock", classInfo.TypeName);
            Assert.Equal("Controller for Variable supported by ORiN3.", classInfo.Comment["default"]);
            Assert.Equal("ORiN3でサポートするVariableに対応したコントローラです。", classInfo.Comment["ja-JP"]);
            Assert.Single(classInfo.Parents);
            Assert.Equal("Root", classInfo.Parents[0]);
            var options = classInfo.Options;
            {
                var option = options[0];
                Assert.Equal("IP Address", option.Name);
                Assert.Equal("Specify the IP address", option.Comment["default"]);
                Assert.Equal("IPアドレスを指定します。", option.Comment["ja-JP"]);
                var rule = option.Rule;
                Assert.Equal("string", rule.Type);
                Assert.Null(rule.Minimum);
                Assert.Null(rule.Maximum);
                Assert.Null(rule.Pattern);
                Assert.False(option.Optional);
            }
            {
                var option = options[1];
                Assert.Equal("Port Number", option.Name);
                Assert.Equal("Specify the port number", option.Comment["default"]);
                Assert.Equal("ポート番号を指定します。", option.Comment["ja-JP"]);
                var rule = option.Rule;
                Assert.Equal("integer", rule.Type);
                Assert.Equal(0, rule.Minimum);
                Assert.Equal(65535, rule.Maximum);
                Assert.Null(rule.Pattern);
                Assert.False(option.Optional);
            }
            {
                var option = options[2];
                Assert.Equal("Src IP Address", option.Name);
                Assert.Equal("IP Address for NIC", option.Comment["default"]);
                Assert.Equal("IPアドレスを指定します。", option.Comment["ja-JP"]);
                var rule = option.Rule;
                Assert.Equal("string", rule.Type);
                Assert.Null(rule.Minimum);
                Assert.Null(rule.Maximum);
                Assert.Null(rule.Pattern);
                Assert.True(option.Optional);
            }
        }
        {
            var classInfo = classInfos[1];
            Assert.Equal("7E1EA851-5898-49B4-B715-BFD29EC34CBC", classInfo.Id);
            Assert.Equal("ORiN3BoolVariable", classInfo.Orin3ObjectType);
            Assert.Equal("BoolVariable", classInfo.DisplayName);
            Assert.Equal("ORiN3.Provider.ORiNConsortium.Mock.O3Object.Variable.BoolVariable, ORiN3.Provider.ORiNConsortium.Mock", classInfo.TypeName);
            Assert.Equal("Bool variable", classInfo.Comment["default"]);
            Assert.Equal("ブール変数", classInfo.Comment["ja-JP"]);
            Assert.Single(classInfo.Parents);
            Assert.Equal("136270FE-E793-42CA-89A9-29AD2B6AB952", classInfo.Parents[0]);
            var options = classInfo.Options;
            {
                var option = options[0];
                Assert.Equal("Device", option.Name);
                Assert.Equal("Specify the Device", option.Comment["default"]);
                Assert.Equal("デバイスを指定する。", option.Comment["ja-JP"]);
                var rule = option.Rule;
                Assert.Equal("string", rule.Type);
                Assert.Null(rule.Minimum);
                Assert.Null(rule.Maximum);
                Assert.Equal("^[A-Z0-9]+$", rule.Pattern);
                Assert.False(option.Optional);
            }
            {
                var option = options[1];
                Assert.Equal("Number", option.Name);
                Assert.Equal("Specify the Number", option.Comment["default"]);
                Assert.Equal("番号を指定する。。", option.Comment["ja-JP"]);
                var rule = option.Rule;
                Assert.Equal("integer", rule.Type);
                Assert.Null(rule.Minimum);
                Assert.Null(rule.Maximum);
                Assert.Null(rule.Pattern);
                Assert.True(option.Optional);
            }
        }
        var scripts = orin3ProviderConfig.Scripts;
        {
            var script = scripts[0];
            Assert.Equal("python3 script.py", script.Command);
            Assert.Equal("linux", script.OS);
        }
        {
            var script = scripts[1];
            Assert.Equal("py script.py", script.Command);
            Assert.Equal("windows", script.OS);
        }
        var manuals = orin3ProviderConfig.Manual;
        {
            Assert.Equal("doc/default/index.html", manuals["default"]);
            Assert.Equal("doc/ja/index.html", manuals["ja-JP"]);
        }
        var licenses = orin3ProviderConfig.License;
        {
            Assert.Equal("license/default", licenses["default"]);
            Assert.Equal("license/ja", licenses["ja-JP"]);
        }
    }

    [Fact(DisplayName = "read a minimum .orin3providerconfig test")]
    [Trait("Category", nameof(ORiN3ProviderConfigReader))]
    public async void ReadTest02()
    {
        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_simple");
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        Assert.Equal("Hoge.dll", orin3ProviderConfig.ProviderPath);
        Assert.Equal("1.0.0", orin3ProviderConfig.Version);
        Assert.Null(orin3ProviderConfig.ProviderId);
        Assert.Null(orin3ProviderConfig.ProviderName);
        Assert.Null(orin3ProviderConfig.Author);
        Assert.Null(orin3ProviderConfig.Comment);
        Assert.Null(orin3ProviderConfig.Category);
        var classInfos = orin3ProviderConfig.ClassInfos;
        {
            var classInfo = classInfos[0];
            Assert.Null(classInfo.Id);
            Assert.Equal("ORiN3Controller", classInfo.Orin3ObjectType);
            Assert.Null(classInfo.DisplayName);
            Assert.Equal("Hoge.HogeController, Hoge", classInfo.TypeName);
            Assert.Null(classInfo.Comment);
            Assert.Single(classInfo.Parents);
            Assert.Equal("Root", classInfo.Parents[0]);
            Assert.Null(classInfo.Options);
        }
        Assert.Null(orin3ProviderConfig.Scripts);
    }
}
