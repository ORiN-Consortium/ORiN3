using System;

namespace ORiN3.Provider.Config;

public static class RuleTypeSwitcher
{
    public static void Execute(string ruleType, IRuleTypeBranch ruleTypeBranch)
    {
        if (ruleType == RuleType.Integer)
        {
            ruleTypeBranch.CaseOfInteger();
        }
        else if (ruleType == RuleType.String)
        {
            ruleTypeBranch.CaseOfString();
        }
        else if (ruleType == RuleType.Boolean)
        {
            ruleTypeBranch.CaseOfBool();
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
