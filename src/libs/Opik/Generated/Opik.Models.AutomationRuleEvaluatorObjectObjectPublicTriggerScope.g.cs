
#nullable enable

namespace Opik
{
    /// <summary>
    /// Controls whether the rule fires on production traces, experiment traces, or both. Defaults to 'production' if omitted.
    /// </summary>
    public enum AutomationRuleEvaluatorObjectObjectPublicTriggerScope
    {
        /// <summary>
        /// 
        /// </summary>
        Both,
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Production,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationRuleEvaluatorObjectObjectPublicTriggerScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorObjectObjectPublicTriggerScope value)
        {
            return value switch
            {
                AutomationRuleEvaluatorObjectObjectPublicTriggerScope.Both => "both",
                AutomationRuleEvaluatorObjectObjectPublicTriggerScope.Experiment => "experiment",
                AutomationRuleEvaluatorObjectObjectPublicTriggerScope.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorObjectObjectPublicTriggerScope? ToEnum(string value)
        {
            return value switch
            {
                "both" => AutomationRuleEvaluatorObjectObjectPublicTriggerScope.Both,
                "experiment" => AutomationRuleEvaluatorObjectObjectPublicTriggerScope.Experiment,
                "production" => AutomationRuleEvaluatorObjectObjectPublicTriggerScope.Production,
                _ => null,
            };
        }
    }
}