
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectMetricResponsePublicMetricType
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
    public static class ProjectMetricResponsePublicMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMetricResponsePublicMetricType value)
        {
            return value switch
            {
                ProjectMetricResponsePublicMetricType.Cost => "COST",
                ProjectMetricResponsePublicMetricType.Duration => "DURATION",
                ProjectMetricResponsePublicMetricType.FeedbackScores => "FEEDBACK_SCORES",
                ProjectMetricResponsePublicMetricType.GuardrailsFailedCount => "GUARDRAILS_FAILED_COUNT",
                ProjectMetricResponsePublicMetricType.SpanAverageDuration => "SPAN_AVERAGE_DURATION",
                ProjectMetricResponsePublicMetricType.SpanCost => "SPAN_COST",
                ProjectMetricResponsePublicMetricType.SpanCount => "SPAN_COUNT",
                ProjectMetricResponsePublicMetricType.SpanDuration => "SPAN_DURATION",
                ProjectMetricResponsePublicMetricType.SpanErrorRate => "SPAN_ERROR_RATE",
                ProjectMetricResponsePublicMetricType.SpanFeedbackScores => "SPAN_FEEDBACK_SCORES",
                ProjectMetricResponsePublicMetricType.SpanTokenUsage => "SPAN_TOKEN_USAGE",
                ProjectMetricResponsePublicMetricType.ThreadAverageDuration => "THREAD_AVERAGE_DURATION",
                ProjectMetricResponsePublicMetricType.ThreadCost => "THREAD_COST",
                ProjectMetricResponsePublicMetricType.ThreadCount => "THREAD_COUNT",
                ProjectMetricResponsePublicMetricType.ThreadDuration => "THREAD_DURATION",
                ProjectMetricResponsePublicMetricType.ThreadFeedbackScores => "THREAD_FEEDBACK_SCORES",
                ProjectMetricResponsePublicMetricType.TokenUsage => "TOKEN_USAGE",
                ProjectMetricResponsePublicMetricType.TraceAverageDuration => "TRACE_AVERAGE_DURATION",
                ProjectMetricResponsePublicMetricType.TraceCount => "TRACE_COUNT",
                ProjectMetricResponsePublicMetricType.TraceErrorRate => "TRACE_ERROR_RATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMetricResponsePublicMetricType? ToEnum(string value)
        {
            return value switch
            {
                "COST" => ProjectMetricResponsePublicMetricType.Cost,
                "DURATION" => ProjectMetricResponsePublicMetricType.Duration,
                "FEEDBACK_SCORES" => ProjectMetricResponsePublicMetricType.FeedbackScores,
                "GUARDRAILS_FAILED_COUNT" => ProjectMetricResponsePublicMetricType.GuardrailsFailedCount,
                "SPAN_AVERAGE_DURATION" => ProjectMetricResponsePublicMetricType.SpanAverageDuration,
                "SPAN_COST" => ProjectMetricResponsePublicMetricType.SpanCost,
                "SPAN_COUNT" => ProjectMetricResponsePublicMetricType.SpanCount,
                "SPAN_DURATION" => ProjectMetricResponsePublicMetricType.SpanDuration,
                "SPAN_ERROR_RATE" => ProjectMetricResponsePublicMetricType.SpanErrorRate,
                "SPAN_FEEDBACK_SCORES" => ProjectMetricResponsePublicMetricType.SpanFeedbackScores,
                "SPAN_TOKEN_USAGE" => ProjectMetricResponsePublicMetricType.SpanTokenUsage,
                "THREAD_AVERAGE_DURATION" => ProjectMetricResponsePublicMetricType.ThreadAverageDuration,
                "THREAD_COST" => ProjectMetricResponsePublicMetricType.ThreadCost,
                "THREAD_COUNT" => ProjectMetricResponsePublicMetricType.ThreadCount,
                "THREAD_DURATION" => ProjectMetricResponsePublicMetricType.ThreadDuration,
                "THREAD_FEEDBACK_SCORES" => ProjectMetricResponsePublicMetricType.ThreadFeedbackScores,
                "TOKEN_USAGE" => ProjectMetricResponsePublicMetricType.TokenUsage,
                "TRACE_AVERAGE_DURATION" => ProjectMetricResponsePublicMetricType.TraceAverageDuration,
                "TRACE_COUNT" => ProjectMetricResponsePublicMetricType.TraceCount,
                "TRACE_ERROR_RATE" => ProjectMetricResponsePublicMetricType.TraceErrorRate,
                _ => null,
            };
        }
    }
}