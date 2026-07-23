
#nullable enable

namespace Opik
{
    /// <summary>
    /// Controls whether the rule fires on production traces, experiment traces, or both. Defaults to 'production' if omitted.
    /// </summary>
    public enum AutomationRuleEvaluatorWriteTriggerScope
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
    public static class AutomationRuleEvaluatorWriteTriggerScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorWriteTriggerScope value)
        {
            return value switch
            {
                AutomationRuleEvaluatorWriteTriggerScope.Both => "both",
                AutomationRuleEvaluatorWriteTriggerScope.Experiment => "experiment",
                AutomationRuleEvaluatorWriteTriggerScope.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorWriteTriggerScope? ToEnum(string value)
        {
            return value switch
            {
                "both" => AutomationRuleEvaluatorWriteTriggerScope.Both,
                "experiment" => AutomationRuleEvaluatorWriteTriggerScope.Experiment,
                "production" => AutomationRuleEvaluatorWriteTriggerScope.Production,
                _ => null,
            };
        }
    }
}