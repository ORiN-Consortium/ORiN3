using Xunit;

namespace ORiN3.Provider.Config.Test.TestByDeveloper;

public class ValidatorTest
{
    [Theory(DisplayName = "条件なし文字列")]
    [Trait("Category", nameof(ORiN3ProviderConfigValidator))]
    [InlineData("test")]
    [InlineData("")]
    [InlineData(null)]
    public void Test01(string input)
    {
        var rule = new Rule(RuleType.String, null, null, null, false);
        var actual = ORiN3ProviderConfigValidator.Validate(input, rule);
        Assert.Equal(ORiN3ProviderConfigValidationResult.Ok, actual);
    }

    [Theory(DisplayName = "正規表現文字列")]
    [Trait("Category", nameof(ORiN3ProviderConfigValidator))]
    [InlineData("test", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("tent", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("atent", ORiN3ProviderConfigValidationResult.PatternMismatch)]
    [InlineData("tt", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("t", ORiN3ProviderConfigValidationResult.PatternMismatch)]
    [InlineData("", ORiN3ProviderConfigValidationResult.PatternMismatch)]
    [InlineData(null, ORiN3ProviderConfigValidationResult.PatternMismatch)]
    public void Test02(string input, ORiN3ProviderConfigValidationResult expected)
    {
        var rule = new Rule(RuleType.String, null, null, "^t.*t$", false);
        var actual = ORiN3ProviderConfigValidator.Validate(input, rule);
        Assert.Equal(expected, actual);
    }

    [Theory(DisplayName = "条件なし整数値")]
    [Trait("Category", nameof(ORiN3ProviderConfigValidator))]
    [InlineData("1", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("3", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("-1", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("5.5", ORiN3ProviderConfigValidationResult.TypeMismatch)]
    [InlineData("t", ORiN3ProviderConfigValidationResult.TypeMismatch)]
    [InlineData("", ORiN3ProviderConfigValidationResult.TypeMismatch)]
    [InlineData(null, ORiN3ProviderConfigValidationResult.TypeMismatch)]
    [InlineData("18446744073709551615", ORiN3ProviderConfigValidationResult.Ok)] // ulong.Max
    [InlineData("-9223372036854775808", ORiN3ProviderConfigValidationResult.Ok)] // long.Min
    public void Test03(string input, ORiN3ProviderConfigValidationResult expected)
    {
        var rule = new Rule(RuleType.Integer, null, null, null, false);
        var actual = ORiN3ProviderConfigValidator.Validate(input, rule);
        Assert.Equal(expected, actual);
    }

    [Theory(DisplayName = "最小値条件付き整数値")]
    [Trait("Category", nameof(ORiN3ProviderConfigValidator))]
    [InlineData("1", ORiN3ProviderConfigValidationResult.TooSmall)]
    [InlineData("4", ORiN3ProviderConfigValidationResult.TooSmall)]
    [InlineData("5", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("6", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("10", ORiN3ProviderConfigValidationResult.Ok)]
    public void Test04(string input, ORiN3ProviderConfigValidationResult expected)
    {
        var rule = new Rule(RuleType.Integer, 5, null, null, false);
        var actual = ORiN3ProviderConfigValidator.Validate(input, rule);
        Assert.Equal(expected, actual);
    }

    [Theory(DisplayName = "最大値条件付き整数値")]
    [Trait("Category", nameof(ORiN3ProviderConfigValidator))]
    [InlineData("1", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("4", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("5", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("6", ORiN3ProviderConfigValidationResult.TooBig)]
    [InlineData("10", ORiN3ProviderConfigValidationResult.TooBig)]
    public void Test05(string input, ORiN3ProviderConfigValidationResult expected)
    {
        var rule = new Rule(RuleType.Integer, null, 5, null, false);
        var actual = ORiN3ProviderConfigValidator.Validate(input, rule);
        Assert.Equal(expected, actual);
    }


    [Theory(DisplayName = "最大/最小値条件付き整数値")]
    [Trait("Category", nameof(ORiN3ProviderConfigValidator))]
    [InlineData("1", ORiN3ProviderConfigValidationResult.TooSmall)]
    [InlineData("4", ORiN3ProviderConfigValidationResult.TooSmall)]
    [InlineData("5", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("6", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("9", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("10", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("11", ORiN3ProviderConfigValidationResult.TooBig)]
    [InlineData("20", ORiN3ProviderConfigValidationResult.TooBig)]
    public void Test06(string input, ORiN3ProviderConfigValidationResult expected)
    {
        var rule = new Rule(RuleType.Integer, 5, 10, null, false);
        var actual = ORiN3ProviderConfigValidator.Validate(input, rule);
        Assert.Equal(expected, actual);
    }

    [Theory(DisplayName = "boolean型")]
    [InlineData("true", ORiN3ProviderConfigValidationResult.Ok)]
    [InlineData("false", ORiN3ProviderConfigValidationResult.Ok)]
    public void Test07(string input, ORiN3ProviderConfigValidationResult expected)
    {
        var rule = new Rule(RuleType.Boolean, null, null, null, false);
        var actual = ORiN3ProviderConfigValidator.Validate(input, rule);
        Assert.Equal(expected, actual);
    }
}
