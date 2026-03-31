
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectMetricRequestPublicMetricType
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
    public static class ProjectMetricRequestPublicMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMetricRequestPublicMetricType value)
        {
            return value switch
            {
                ProjectMetricRequestPublicMetricType.Cost => "COST",
                ProjectMetricRequestPublicMetricType.Duration => "DURATION",
                ProjectMetricRequestPublicMetricType.FeedbackScores => "FEEDBACK_SCORES",
                ProjectMetricRequestPublicMetricType.GuardrailsFailedCount => "GUARDRAILS_FAILED_COUNT",
                ProjectMetricRequestPublicMetricType.SpanAverageDuration => "SPAN_AVERAGE_DURATION",
                ProjectMetricRequestPublicMetricType.SpanCost => "SPAN_COST",
                ProjectMetricRequestPublicMetricType.SpanCount => "SPAN_COUNT",
                ProjectMetricRequestPublicMetricType.SpanDuration => "SPAN_DURATION",
                ProjectMetricRequestPublicMetricType.SpanErrorRate => "SPAN_ERROR_RATE",
                ProjectMetricRequestPublicMetricType.SpanFeedbackScores => "SPAN_FEEDBACK_SCORES",
                ProjectMetricRequestPublicMetricType.SpanTokenUsage => "SPAN_TOKEN_USAGE",
                ProjectMetricRequestPublicMetricType.ThreadAverageDuration => "THREAD_AVERAGE_DURATION",
                ProjectMetricRequestPublicMetricType.ThreadCost => "THREAD_COST",
                ProjectMetricRequestPublicMetricType.ThreadCount => "THREAD_COUNT",
                ProjectMetricRequestPublicMetricType.ThreadDuration => "THREAD_DURATION",
                ProjectMetricRequestPublicMetricType.ThreadFeedbackScores => "THREAD_FEEDBACK_SCORES",
                ProjectMetricRequestPublicMetricType.TokenUsage => "TOKEN_USAGE",
                ProjectMetricRequestPublicMetricType.TraceAverageDuration => "TRACE_AVERAGE_DURATION",
                ProjectMetricRequestPublicMetricType.TraceCount => "TRACE_COUNT",
                ProjectMetricRequestPublicMetricType.TraceErrorRate => "TRACE_ERROR_RATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMetricRequestPublicMetricType? ToEnum(string value)
        {
            return value switch
            {
                "COST" => ProjectMetricRequestPublicMetricType.Cost,
                "DURATION" => ProjectMetricRequestPublicMetricType.Duration,
                "FEEDBACK_SCORES" => ProjectMetricRequestPublicMetricType.FeedbackScores,
                "GUARDRAILS_FAILED_COUNT" => ProjectMetricRequestPublicMetricType.GuardrailsFailedCount,
                "SPAN_AVERAGE_DURATION" => ProjectMetricRequestPublicMetricType.SpanAverageDuration,
                "SPAN_COST" => ProjectMetricRequestPublicMetricType.SpanCost,
                "SPAN_COUNT" => ProjectMetricRequestPublicMetricType.SpanCount,
                "SPAN_DURATION" => ProjectMetricRequestPublicMetricType.SpanDuration,
                "SPAN_ERROR_RATE" => ProjectMetricRequestPublicMetricType.SpanErrorRate,
                "SPAN_FEEDBACK_SCORES" => ProjectMetricRequestPublicMetricType.SpanFeedbackScores,
                "SPAN_TOKEN_USAGE" => ProjectMetricRequestPublicMetricType.SpanTokenUsage,
                "THREAD_AVERAGE_DURATION" => ProjectMetricRequestPublicMetricType.ThreadAverageDuration,
                "THREAD_COST" => ProjectMetricRequestPublicMetricType.ThreadCost,
                "THREAD_COUNT" => ProjectMetricRequestPublicMetricType.ThreadCount,
                "THREAD_DURATION" => ProjectMetricRequestPublicMetricType.ThreadDuration,
                "THREAD_FEEDBACK_SCORES" => ProjectMetricRequestPublicMetricType.ThreadFeedbackScores,
                "TOKEN_USAGE" => ProjectMetricRequestPublicMetricType.TokenUsage,
                "TRACE_AVERAGE_DURATION" => ProjectMetricRequestPublicMetricType.TraceAverageDuration,
                "TRACE_COUNT" => ProjectMetricRequestPublicMetricType.TraceCount,
                "TRACE_ERROR_RATE" => ProjectMetricRequestPublicMetricType.TraceErrorRate,
                _ => null,
            };
        }
    }
}