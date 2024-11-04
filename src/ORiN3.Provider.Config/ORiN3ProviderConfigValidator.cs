namespace ORiN3.Provider.Config;

public static class ORiN3ProviderConfigValidator
{
    public static ORiN3ProviderConfigValidationResult Validate(string value, Rule rule)
    {
        var branch = new ValidationBranch(value, rule);
        RuleTypeSwitcher.Execute(rule.Type, branch);
        return branch.Result;
    }
}
