using System;
using System.Collections.Generic;
using Xunit;

namespace ORiN3.Provider.Config.Test.TestByDeveloper;

public class ClassInfoTest
{
    [Theory(DisplayName = "Check Is property")]
    [Trait("Category", nameof(ClassInfoTest))]
    [InlineData(null, "typename")]
    [InlineData("id", "id")]
    public void ClassInfoTest01(string id1, string id2)
    {
        var info = new ClassInfo(null, "typename", null, null, id1, null, null, null);
        Assert.True(info.Is(id2));
    }

    public class GetClassInfoData : TheoryData<ClassInfo, ClassInfo, bool>
    {
        public GetClassInfoData()
        {
            Add(new ClassInfo(null, null, null, null, null, null, null, null),
                new ClassInfo(null, null, null, null, null, null, null, null), true);
            Add(new ClassInfo(null, null, null, null, null, null, null, null),
                new ClassInfo(null, null, ["test"], null, null, null, null, null), false);
            Add(new ClassInfo(null, null, ["test"], null, null, null, null, null),
                new ClassInfo(null, null, null, null, null, null, null, null), false);
            Add(new ClassInfo(null, null, ["test"], null, null, null, null, null),
                new ClassInfo(null, null, ["test1", "test2"], null, null, null, null, null), false);
            Add(new ClassInfo(null, null, ["test1"], null, null, null, null, null),
                new ClassInfo(null, null, ["test2"], null, null, null, null, null), false);
            Add(new ClassInfo("test1", null, null, null, null, null, null, null),
                new ClassInfo("test2", null, null, null, null, null, null, null), false);
        }
    }

    [Theory(DisplayName = "Check EqualsSpecifically and parentsEquals at ClassInfo")]
    [Trait("Category", nameof(ClassInfoTest))]
    [ClassData(typeof(GetClassInfoData))]
    public void ClassInfoTest02(ClassInfo info1, ClassInfo info2, bool isEqual)
    {
        var configdata1 = new ORiN3ProviderConfig(
            ProviderPath: "test.dll",
            Version: "1.0.0",
            ClassInfos: [info1],
            ProviderId: "1.0.0",
            ProviderName: "test",
            Secret: null,
            Author: "test",
            Comment: new Dictionary<string, string>() { { "test", "test" } },
            Scripts: null,
            ReadingFileBufferSize: null,
            Manual: null,
            License: null,
            Log: null,
            OutputLogDir: null,
            LogByteSizePerFile: null,
            LogFileCountLimit: null,
            Category: null);
        var configdata2 = configdata1 with { ClassInfos = [info2] };
        var result = configdata1.EqualsSpecifically(configdata2);
        Assert.Equal(result, isEqual);
    }

    public class GetOptionData : TheoryData<Option[], Option[], bool>
    {
        public GetOptionData()
        {
            Add(null, null, true);
            Add([new(null, null, null, false, null)], null, false);
            Add(null, [new(null, null, null, false, null)], false);
            Add([new(null, null, null, false, null), new(null, null, null, false, null)],
                [new(null, null, null, false, null)], false);
            Add([new("test1", null, null, false, null)],
                [new("test2", null, null, false, null)], false);
        }
    }

    [Theory(DisplayName = "Check EqualsSpecifically and optionsEquals at ClassInfo")]
    [Trait("Category", nameof(ClassInfoTest))]
    [ClassData(typeof(GetOptionData))]
    public void ClassInfoTest03(Option[] options1, Option[] options2, bool isEqual)
    {
        var classinfo1 = new ClassInfo(null, null, ["test"], options1, null, null, null, null);
        var classinfo2 = classinfo1 with { Options = options2 };

        var configdata1 = new ORiN3ProviderConfig(
            ProviderPath: "test.dll",
            Version: "1.0.0",
            ClassInfos: [classinfo1],
            ProviderId: "1.0.0",
            ProviderName: "test",
            Secret: null,
            Author: "test",
            Comment: new Dictionary<string, string>() { { "test", "test" } },
            Scripts: null,
            ReadingFileBufferSize: null,
            Manual: null,
            License: null,
            Log: null,
            OutputLogDir: null,
            LogByteSizePerFile: null,
            LogFileCountLimit: null,
            Category: null);
        var configdata2 = configdata1 with { ClassInfos = [classinfo2] };

        var result = configdata1.EqualsSpecifically(configdata2);
        Assert.Equal(result, isEqual);
    }

    [Theory(DisplayName = "Check UniqueId property")]
    [Trait("Category", nameof(ClassInfoTest))]
    [InlineData(null, "typename")]
    [InlineData("id", "id")]
    public void ClassInfoTest04(string id, string expected)
    {
        var info = new ClassInfo(null, "typename", null, null, id, null, null, null);
        Assert.Equal(id, info.Id);
        Assert.Equal(expected, info.UniqueId);
    }

    [Fact(DisplayName = "Check UniqueId property")]
    [Trait("Category", nameof(ClassInfoTest))]
    public void ClassInfoTest05()
    {
        var info = new ClassInfo(null, null, null, null, null, null, null, null);
        Assert.Throws<FormatException>(() => info.UniqueId);
    }

    [Theory(DisplayName = "Check ActualDisplayName property")]
    [Trait("Category", nameof(ClassInfoTest))]
    [InlineData(null, "typename")]
    [InlineData("displayname", "displayname")]
    public void ClassInfoTest06(string displayName, string expected)
    {
        var info = new ClassInfo(null, "typename", null, null, null, displayName, null, null);
        Assert.Equal(displayName, info.DisplayName);
        Assert.Equal(expected, info.ActualDisplayName);
    }

    [Fact(DisplayName = "Check ActualDisplayName property")]
    [Trait("Category", nameof(ClassInfoTest))]
    public void ClassInfoTest07()
    {
        var info = new ClassInfo(null, null, null, null, null, null, null, null);
        Assert.Throws<FormatException>(() => info.ActualDisplayName);
    }
}
