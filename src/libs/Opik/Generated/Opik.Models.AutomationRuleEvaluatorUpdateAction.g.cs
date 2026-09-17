
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public enum AutomationRuleEvaluatorUpdateAction
    {
        /// <summary>
        ///
        /// </summary>
        AnnotationQueueRouter,
        /// <summary>
        ///
        /// </summary>
        Evaluator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationRuleEvaluatorUpdateActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorUpdateAction value)
        {
            return value switch
            {
                AutomationRuleEvaluatorUpdateAction.AnnotationQueueRouter => "annotation_queue_router",
                AutomationRuleEvaluatorUpdateAction.Evaluator => "evaluator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorUpdateAction? ToEnum(string value)
        {
            return value switch
            {
                "annotation_queue_router" => AutomationRuleEvaluatorUpdateAction.AnnotationQueueRouter,
                "evaluator" => AutomationRuleEvaluatorUpdateAction.Evaluator,
                _ => null,
            };
        }
    }
}