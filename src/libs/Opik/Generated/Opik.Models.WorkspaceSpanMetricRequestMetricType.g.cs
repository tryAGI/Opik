
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkspaceSpanMetricRequestMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        FeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        GuardrailsFailedCount,
        /// <summary>
        /// 
        /// </summary>
        SpanAverageDuration,
        /// <summary>
        /// 
        /// </summary>
        SpanCost,
        /// <summary>
        /// 
        /// </summary>
        SpanCount,
        /// <summary>
        /// 
        /// </summary>
        SpanDuration,
        /// <summary>
        /// 
        /// </summary>
        SpanErrorRate,
        /// <summary>
        /// 
        /// </summary>
        SpanFeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        SpanTokenUsage,
        /// <summary>
        /// 
        /// </summary>
        ThreadAverageDuration,
        /// <summary>
        /// 
        /// </summary>
        ThreadCost,
        /// <summary>
        /// 
        /// </summary>
        ThreadCount,
        /// <summary>
        /// 
        /// </summary>
        ThreadDuration,
        /// <summary>
        /// 
        /// </summary>
        ThreadFeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        TokenUsage,
        /// <summary>
        /// 
        /// </summary>
        TraceAverageDuration,
        /// <summary>
        /// 
        /// </summary>
        TraceCount,
        /// <summary>
        /// 
        /// </summary>
        TraceErrorRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceSpanMetricRequestMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceSpanMetricRequestMetricType value)
        {
            return value switch
            {
                WorkspaceSpanMetricRequestMetricType.Cost => "COST",
                WorkspaceSpanMetricRequestMetricType.Duration => "DURATION",
                WorkspaceSpanMetricRequestMetricType.FeedbackScores => "FEEDBACK_SCORES",
                WorkspaceSpanMetricRequestMetricType.GuardrailsFailedCount => "GUARDRAILS_FAILED_COUNT",
                WorkspaceSpanMetricRequestMetricType.SpanAverageDuration => "SPAN_AVERAGE_DURATION",
                WorkspaceSpanMetricRequestMetricType.SpanCost => "SPAN_COST",
                WorkspaceSpanMetricRequestMetricType.SpanCount => "SPAN_COUNT",
                WorkspaceSpanMetricRequestMetricType.SpanDuration => "SPAN_DURATION",
                WorkspaceSpanMetricRequestMetricType.SpanErrorRate => "SPAN_ERROR_RATE",
                WorkspaceSpanMetricRequestMetricType.SpanFeedbackScores => "SPAN_FEEDBACK_SCORES",
                WorkspaceSpanMetricRequestMetricType.SpanTokenUsage => "SPAN_TOKEN_USAGE",
                WorkspaceSpanMetricRequestMetricType.ThreadAverageDuration => "THREAD_AVERAGE_DURATION",
                WorkspaceSpanMetricRequestMetricType.ThreadCost => "THREAD_COST",
                WorkspaceSpanMetricRequestMetricType.ThreadCount => "THREAD_COUNT",
                WorkspaceSpanMetricRequestMetricType.ThreadDuration => "THREAD_DURATION",
                WorkspaceSpanMetricRequestMetricType.ThreadFeedbackScores => "THREAD_FEEDBACK_SCORES",
                WorkspaceSpanMetricRequestMetricType.TokenUsage => "TOKEN_USAGE",
                WorkspaceSpanMetricRequestMetricType.TraceAverageDuration => "TRACE_AVERAGE_DURATION",
                WorkspaceSpanMetricRequestMetricType.TraceCount => "TRACE_COUNT",
                WorkspaceSpanMetricRequestMetricType.TraceErrorRate => "TRACE_ERROR_RATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceSpanMetricRequestMetricType? ToEnum(string value)
        {
            return value switch
            {
                "COST" => WorkspaceSpanMetricRequestMetricType.Cost,
                "DURATION" => WorkspaceSpanMetricRequestMetricType.Duration,
                "FEEDBACK_SCORES" => WorkspaceSpanMetricRequestMetricType.FeedbackScores,
                "GUARDRAILS_FAILED_COUNT" => WorkspaceSpanMetricRequestMetricType.GuardrailsFailedCount,
                "SPAN_AVERAGE_DURATION" => WorkspaceSpanMetricRequestMetricType.SpanAverageDuration,
                "SPAN_COST" => WorkspaceSpanMetricRequestMetricType.SpanCost,
                "SPAN_COUNT" => WorkspaceSpanMetricRequestMetricType.SpanCount,
                "SPAN_DURATION" => WorkspaceSpanMetricRequestMetricType.SpanDuration,
                "SPAN_ERROR_RATE" => WorkspaceSpanMetricRequestMetricType.SpanErrorRate,
                "SPAN_FEEDBACK_SCORES" => WorkspaceSpanMetricRequestMetricType.SpanFeedbackScores,
                "SPAN_TOKEN_USAGE" => WorkspaceSpanMetricRequestMetricType.SpanTokenUsage,
                "THREAD_AVERAGE_DURATION" => WorkspaceSpanMetricRequestMetricType.ThreadAverageDuration,
                "THREAD_COST" => WorkspaceSpanMetricRequestMetricType.ThreadCost,
                "THREAD_COUNT" => WorkspaceSpanMetricRequestMetricType.ThreadCount,
                "THREAD_DURATION" => WorkspaceSpanMetricRequestMetricType.ThreadDuration,
                "THREAD_FEEDBACK_SCORES" => WorkspaceSpanMetricRequestMetricType.ThreadFeedbackScores,
                "TOKEN_USAGE" => WorkspaceSpanMetricRequestMetricType.TokenUsage,
                "TRACE_AVERAGE_DURATION" => WorkspaceSpanMetricRequestMetricType.TraceAverageDuration,
                "TRACE_COUNT" => WorkspaceSpanMetricRequestMetricType.TraceCount,
                "TRACE_ERROR_RATE" => WorkspaceSpanMetricRequestMetricType.TraceErrorRate,
                _ => null,
            };
        }
    }
}