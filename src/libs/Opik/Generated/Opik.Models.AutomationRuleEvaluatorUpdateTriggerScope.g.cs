
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutomationRuleEvaluatorUpdateTriggerScope
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
    public static class AutomationRuleEvaluatorUpdateTriggerScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorUpdateTriggerScope value)
        {
            return value switch
            {
                AutomationRuleEvaluatorUpdateTriggerScope.Both => "both",
                AutomationRuleEvaluatorUpdateTriggerScope.Experiment => "experiment",
                AutomationRuleEvaluatorUpdateTriggerScope.Production => "production",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorUpdateTriggerScope? ToEnum(string value)
        {
            return value switch
            {
                "both" => AutomationRuleEvaluatorUpdateTriggerScope.Both,
                "experiment" => AutomationRuleEvaluatorUpdateTriggerScope.Experiment,
                "production" => AutomationRuleEvaluatorUpdateTriggerScope.Production,
                _ => null,
            };
        }
    }
}