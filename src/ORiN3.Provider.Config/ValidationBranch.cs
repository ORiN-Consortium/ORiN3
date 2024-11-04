using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ORiN3.Provider.Config;

internal class ValidationBranch : IRuleTypeBranch
{
    private readonly string _value;
    private readonly Rule _rule;

    internal ValidationBranch(string value, Rule rule)
    {
        _value = value;
        _rule = rule;
    }

    public ORiN3ProviderConfigValidationResult Result { get; private set; }

    public void CaseOfInteger()
    {
        Result = ValidateInteger(_value, _rule);
    }

    private static ORiN3ProviderConfigValidationResult ValidateInteger(string valueString, Rule rule)
    {
        Debug.Assert(rule.Type == RuleType.Integer);
        if (!decimal.TryParse(valueString, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out var value))
        {
            return ORiN3ProviderConfigValidationResult.TypeMismatch;
        }
        if (rule.Minimum is not null)
        {
            if (value < rule.Minimum)
            {
                return ORiN3ProviderConfigValidationResult.TooSmall;
            }
        }
        if (rule.Maximum is not null)
        {
            if (value > rule.Maximum)
            {
                return ORiN3ProviderConfigValidationResult.TooBig;
            }
        }
        return ORiN3ProviderConfigValidationResult.Ok;
    }

    public void CaseOfString()
    {
        Result = ValidateString(_value, _rule);
    }


    private static ORiN3ProviderConfigValidationResult ValidateString(string value, Rule rule)
    {
        Debug.Assert(rule.Type == RuleType.String);
        if (rule.Pattern is not null)
        {
            if (value is null || !Regex.IsMatch(value, rule.Pattern))
            {
                return ORiN3ProviderConfigValidationResult.PatternMismatch;
            }
        }
        return ORiN3ProviderConfigValidationResult.Ok;
    }

    public void CaseOfBool()
    {
        Result = ValidateBool(_value, _rule);
    }

    private static ORiN3ProviderConfigValidationResult ValidateBool(string _, Rule rule)
    {
        Debug.Assert(rule.Type == RuleType.Boolean);

        // Boolに該当するRuleが追加されたらここでチェックを行う

        return ORiN3ProviderConfigValidationResult.Ok;
    }
}
