
#nullable enable

namespace Opik
{
    /// <summary>
    /// Controls whether the rule fires on production traces, experiment traces, or both. Defaults to 'production' if omitted.
    /// </summary>
    public enum AutomationRuleEvaluatorPublicTriggerScope
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
    public static class AutomationRuleEvaluatorPublicTriggerScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorPublicTriggerScope value)
        {
            return value switch
            {
                AutomationRuleEvaluatorPublicTriggerScope.Both => "both",
                AutomationRuleEvaluatorPublicTriggerScope.Experiment => "experiment",
                AutomationRuleEvaluatorPublicTriggerScope.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorPublicTriggerScope? ToEnum(string value)
        {
            return value switch
            {
                "both" => AutomationRuleEvaluatorPublicTriggerScope.Both,
                "experiment" => AutomationRuleEvaluatorPublicTriggerScope.Experiment,
                "production" => AutomationRuleEvaluatorPublicTriggerScope.Production,
                _ => null,
            };
        }
    }
}