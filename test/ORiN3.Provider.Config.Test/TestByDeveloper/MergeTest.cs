using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace ORiN3.Provider.Config.Test.TestByDeveloper;

public class MergeTest
{
    [Theory(DisplayName = ".orin3providerconfig merge test")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    [ClassData(typeof(GetConfigData))]
    public async Task MergeTest01(string first, string second, string expected)
    {
        var firstDeserialized = await ORiN3ProviderConfigReader.ReadAsync(first);
        var secondDeserialized = await ORiN3ProviderConfigReader.ReadAsync(second);
        var expectedDeserialized = await ORiN3ProviderConfigReader.ReadAsync(expected);
        Assert.True(expectedDeserialized.EqualsSpecifically(ORiN3ProviderConfigMerger.Merge(firstDeserialized, secondDeserialized)));
    }

    public class GetConfigData : TheoryData<string, string, string>
    {
        public GetConfigData()
        {
            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                }",

            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }",
            @"{
                    ""providerId"": ""93368288-96BE-4E5E-A355-73DFE211E702"",
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""providerId"": ""93368288-96BE-4E5E-A355-73DFE211E702"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController2, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        },
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController2, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""displayName"": ""EthernetController"",
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""displayName"": ""EthernetController"",
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""displayName"": ""EthernetController"",
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""displayName"": ""EthernetController2"",
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""displayName"": ""EthernetController2"",
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"", ""3505D969-3203-4516-A3BC-284D8D4D5F59"" ],
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"", ""3505D969-3203-4516-A3BC-284D8D4D5F59"" ],
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address"",
                                        ""ja-JP"": ""IPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                }
                            ]
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""options"": [
                                {
                                      ""name"": ""IP Address2"",
                                      ""comment"": {
                                        ""default"": ""IP Address"",
                                        ""ja-JP"": ""IPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                }
                            ],
                            ""id"": ""E698D089-EE52-4E44-BBE4-2E60803DCAD3"",
                            ""configurationId"": ""0""
                        }
                    ],
                    ""secret"": ""secret""
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address"",
                                        ""ja-JP"": ""IPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                },
                                {
                                      ""name"": ""IP Address2"",
                                      ""comment"": {
                                        ""default"": ""IP Address"",
                                        ""ja-JP"": ""IPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                }
                            ],
                            ""id"": ""E698D089-EE52-4E44-BBE4-2E60803DCAD3"",
                            ""configurationId"": ""0""
                        }
                    ],
                    ""secret"": ""secret""
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address"",
                                        ""ja-JP"": ""IPアドレスを指定します。""
                                      }
                                }
                            ]
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                }
                            ]
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address"",
                                        ""ja-JP"": ""IPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                }
                            ]
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address of Hoge"",
                                        ""ja-JP"": ""HogeのIPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                }
                            ]
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address of Hoge2"",
                                        ""ja-JP"": ""HogeのIPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string"",
                                        ""pattern"": ""A-Z0-9""
                                      }
                                }
                            ]
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address of Hoge2"",
                                        ""ja-JP"": ""HogeのIPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string"",
                                        ""pattern"": ""A-Z0-9""
                                      }
                                }
                            ]
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address of Hoge"",
                                        ""ja-JP"": ""HogeのIPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""string""
                                      }
                                }
                            ]
                        }
                    ]
                }",
            @"{
                    ""classInfos"": [
                        {
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""rule"": {
                                        ""type"": ""int"",
                                        ""minimum"": 0,
                                        ""maximum"": 100,
                                      }
                                }
                            ]
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address of Hoge"",
                                        ""ja-JP"": ""HogeのIPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""int"",
                                        ""minimum"": 0,
                                        ""maximum"": 100,
                                      }
                                }
                            ]
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ],
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ],
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ],
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ],
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""windows""
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ],
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        },
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""windows""
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ],
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge2.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }",
            @"{
                    ""providerPath"": ""HogeHoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge.HogeController, Hoge"",
                            ""parents"": [ ""Root"" ]
                        }
                    ],
                    ""scripts"":
                    [
                        {
                            ""command"": ""sh hoge.sh"",
                            ""os"": ""linux""
                        },
                        {
                            ""command"": ""sh hoge2.sh"",
                            ""os"": ""linux""
                        }
                    ]
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll""
                }",
            @"{
                    ""log"": ""enabled"",
                    ""outputLogDir"": ""."",
                    ""logByteSizePerFile"": 1000,
                    ""logFileCountLimit"": 100
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""log"": ""enabled"",
                    ""outputLogDir"": ""."",
                    ""logByteSizePerFile"": 1000,
                    ""logFileCountLimit"": 100
                }"
            );

            Add(
            @"{
                    ""log"": ""enabled"",
                    ""outputLogDir"": ""."",
                    ""logByteSizePerFile"": 1000,
                    ""logFileCountLimit"": 100
                }",
            @"{
                    ""providerPath"": ""Hoge.dll""
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""log"": ""enabled"",
                    ""outputLogDir"": ""."",
                    ""logByteSizePerFile"": 1000,
                    ""logFileCountLimit"": 100
                }"
            );

            Add(
            @"{
                    ""providerPath"": ""Hoge.dll""
                }",
            @"{
                    ""category"": ""123456789""
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""category"": ""123456789""
                }"
            );

            Add(
            @"{
                    ""category"": ""123456789""
                }",
            @"{
                    ""providerPath"": ""Hoge.dll""
                }",
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""category"": ""123456789""
                }"
            );
        }
    }

    [Fact(DisplayName = "Check Exception occurred if config is null")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    public async Task MergeTest02Async()
    {
        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_simple");
        var orin3ProviderConfig = await ORiN3ProviderConfigReader.ReadAsync(file);
        _ = Assert.Throws<ArgumentNullException>(() =>
        {
            _ = ORiN3ProviderConfigMerger.Merge(null, orin3ProviderConfig);
        });
        _ = Assert.Throws<ArgumentNullException>(() =>
        {
            _ = ORiN3ProviderConfigMerger.Merge(orin3ProviderConfig, null);
        });
    }

    [Fact(DisplayName = "Check that if each data of 2nd config is null, substitute the data of 1st config")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    public async Task MergeTest03Async()
    {
        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        var first = await ORiN3ProviderConfigReader.ReadAsync(file);
        var second = new ORiN3ProviderConfig(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);

        var merger = ORiN3ProviderConfigMerger.Merge(first, second);
        Assert.Equal(merger.Version, first.Version);
        Assert.Equal(merger.ProviderName, first.ProviderName);
        Assert.Equal(merger.Secret, first.Secret);
        Assert.Equal(merger.Author, first.Author);
    }

    [Fact(DisplayName = "Check that if one classinfos is null, substitute another classinfos")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    public async Task MergeTest04Async()
    {
        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        var second = await ORiN3ProviderConfigReader.ReadAsync(file);
        var first = second with { ClassInfos = null };

        var merger = ORiN3ProviderConfigMerger.Merge(first, second);
        Assert.Equal(merger.ClassInfos, second.ClassInfos);
    }

    [Fact(DisplayName = "Check that if 2nd classinfos is null, substitute 1st classinfos")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    public async Task MergeTest05Async()
    {
        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        var first = await ORiN3ProviderConfigReader.ReadAsync(file);
        var second = first with { ClassInfos = null };

        var merger = ORiN3ProviderConfigMerger.Merge(first, second);
        Assert.Equal(merger.ClassInfos, first.ClassInfos);
    }

    [Fact(DisplayName = "Check that if the type name of classinfos is null, Exception occurred")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    public async Task MergeTest06Async()
    {
        var file = new FileInfo("TestByDeveloper/TestData/.orin3providerconfig_sample");
        var one = await ORiN3ProviderConfigReader.ReadAsync(file);
        var classinfo = new ClassInfo[] { new(null, null, null, null, null, null, null, null) };
        var another = one with { ClassInfos = classinfo };

        _ = Assert.Throws<ArgumentException>(() =>
        {
            _ = ORiN3ProviderConfigMerger.Merge(another, one);
        });

        _ = Assert.Throws<ArgumentException>(() =>
        {
            _ = ORiN3ProviderConfigMerger.Merge(one, another);
        });
    }

    public class GetConfigData2 : TheoryData<string>
    {
        public GetConfigData2()
        {
            Add(
            @"{
                    ""providerPath"": ""Hoge.dll"",
                    ""version"": ""1.0.0"",
                    ""classInfos"": [
                        {
                            ""orin3ObjectType"": ""ORiN3Controller"",
                            ""typeName"": ""Hoge"",
                            ""parents"": [ ""Root"" ],
                            ""options"": [
                                {
                                      ""name"": ""IP Address"",
                                      ""comment"": {
                                        ""default"": ""IP Address of Hoge"",
                                        ""ja-JP"": ""HogeのIPアドレスを指定します。""
                                      },
                                      ""rule"": {
                                        ""type"": ""int"",
                                        ""minimum"": 0,
                                        ""maximum"": 100,
                                      }
                                }
                            ]
                        }
                    ]
                }"
            );
        }
    }

    [Theory(DisplayName = "Check that if the data of 2nd classinfo is null, substitute the data of 1st")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    [ClassData(typeof(GetConfigData2))]
    public async Task MergeTest07Async(string configdata)
    {
        var first = await ORiN3ProviderConfigReader.ReadAsync(configdata);
        var classinfo = new ClassInfo[] { new(null, "Hoge", null, null, null, null, null, null) };
        var second = first with { ClassInfos = classinfo };

        var mergerclassinfo = ORiN3ProviderConfigMerger.Merge(first, second).ClassInfos[0];
        var firstclassinfo = first.ClassInfos[0];
        Assert.Equal(mergerclassinfo.TypeName, firstclassinfo.TypeName);
        Assert.Equal(mergerclassinfo.Id, firstclassinfo.Id);
        Assert.Equal(mergerclassinfo.ConfigurationId, firstclassinfo.ConfigurationId);
        Assert.Equal(mergerclassinfo.DisplayName, firstclassinfo.DisplayName);
        Assert.Equal(mergerclassinfo.Options, firstclassinfo.Options);
        Assert.Equal(mergerclassinfo.Parents, firstclassinfo.Parents);
        Assert.Equal(mergerclassinfo.Comment, firstclassinfo.Comment);
    }

    [Theory(DisplayName = "Check that if each data of option of 2nd classinfo is null, substitute the data of option of 1st")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    [ClassData(typeof(GetConfigData2))]
    public async Task MergeTest08Async(string configdata)
    {
        var first = await ORiN3ProviderConfigReader.ReadAsync(configdata);
        var classinfo = new ClassInfo[] { new(null, "Hoge", null,
            [new("IP Address", null, null, false, null)], null, null, null, null) };
        var second = first with { ClassInfos = classinfo };

        var mergeroption = ORiN3ProviderConfigMerger.Merge(first, second).ClassInfos[0].Options[0];
        var firstoption = first.ClassInfos[0].Options[0];
        Assert.Equal(mergeroption.Optional, firstoption.Optional);
        Assert.Equal(mergeroption.Default, firstoption.Default);
        Assert.Equal(mergeroption.Rule, firstoption.Rule);
        Assert.Equal(mergeroption.Comment, firstoption.Comment);
    }

    [Theory(DisplayName = "Check that if the name of option of 1st classinfos is null, Exception occurred")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    [ClassData(typeof(GetConfigData2))]
    public async Task MergeTest09Async(string configdata)
    {
        var one = await ORiN3ProviderConfigReader.ReadAsync(configdata);
        var classinfo = new ClassInfo[] { new(null, "Hoge", null,
            [new(null, null, null, false, null)], null, null, null, null) };
        var another = one with { ClassInfos = classinfo };

        _ = Assert.Throws<ArgumentException>(() =>
        {
            _ = ORiN3ProviderConfigMerger.Merge(another, one);
        });

        _ = Assert.Throws<ArgumentException>(() =>
        {
            _ = ORiN3ProviderConfigMerger.Merge(one, another);
        });
    }

    [Theory(DisplayName = "Check that if each data of rule of option of 2nd classinfos is null, substitute the data of 1st")]
    [Trait("Category", nameof(ORiN3ProviderConfigMerger))]
    [ClassData(typeof(GetConfigData2))]
    public async Task MergeTest10Async(string configdata)
    {
        var first = await ORiN3ProviderConfigReader.ReadAsync(configdata);
        var classinfo = new ClassInfo[] { new(null, "testname", null,
            [new("IP Address", new Rule(null, null, null, null, false), null, false, null)], null, null, null, null) };
        var second = first with { ClassInfos = classinfo };
        var mergerrule = ORiN3ProviderConfigMerger.Merge(first, second).ClassInfos[0].Options[0].Rule;
        var firstrule = first.ClassInfos[0].Options[0].Rule;

        Assert.Equal(mergerrule.Pattern, firstrule.Pattern);
        Assert.Equal(mergerrule.Type, firstrule.Type);
        Assert.Equal(mergerrule.Maximum, firstrule.Maximum);
        Assert.Equal(mergerrule.Minimum, firstrule.Minimum);
    }
}
