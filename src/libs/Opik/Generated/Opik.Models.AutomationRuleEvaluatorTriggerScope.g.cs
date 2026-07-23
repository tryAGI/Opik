
#nullable enable

namespace Opik
{
    /// <summary>
    /// Controls whether the rule fires on production traces, experiment traces, or both. Defaults to 'production' if omitted.
    /// </summary>
    public enum AutomationRuleEvaluatorTriggerScope
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
    public static class AutomationRuleEvaluatorTriggerScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorTriggerScope value)
        {
            return value switch
            {
                AutomationRuleEvaluatorTriggerScope.Both => "both",
                AutomationRuleEvaluatorTriggerScope.Experiment => "experiment",
                AutomationRuleEvaluatorTriggerScope.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorTriggerScope? ToEnum(string value)
        {
            return value switch
            {
                "both" => AutomationRuleEvaluatorTriggerScope.Both,
                "experiment" => AutomationRuleEvaluatorTriggerScope.Experiment,
                "production" => AutomationRuleEvaluatorTriggerScope.Production,
                _ => null,
            };
        }
    }
}