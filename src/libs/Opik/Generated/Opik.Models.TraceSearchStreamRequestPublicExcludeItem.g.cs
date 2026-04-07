
#nullable enable

namespace Opik
{
    /// <summary>
    /// Fields to exclude from the response
    /// </summary>
    public enum TraceSearchStreamRequestPublicExcludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Comments,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        CreatedBy,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        EndTime,
        /// <summary>
        /// 
        /// </summary>
        ErrorInfo,
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        FeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        GuardrailsValidations,
        /// <summary>
        /// 
        /// </summary>
        HasToolSpans,
        /// <summary>
        /// 
        /// </summary>
        Input,
        /// <summary>
        /// 
        /// </summary>
        LastUpdatedBy,
        /// <summary>
        /// 
        /// </summary>
        LlmSpanCount,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        Providers,
        /// <summary>
        /// 
        /// </summary>
        Source,
        /// <summary>
        /// 
        /// </summary>
        SpanCount,
        /// <summary>
        /// 
        /// </summary>
        SpanFeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        StartTime,
        /// <summary>
        /// 
        /// </summary>
        Tags,
        /// <summary>
        /// 
        /// </summary>
        ThreadId,
        /// <summary>
        /// 
        /// </summary>
        TotalEstimatedCost,
        /// <summary>
        /// 
        /// </summary>
        Ttft,
        /// <summary>
        /// 
        /// </summary>
        Usage,
        /// <summary>
        /// 
        /// </summary>
        VisibilityMode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceSearchStreamRequestPublicExcludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceSearchStreamRequestPublicExcludeItem value)
        {
            return value switch
            {
                TraceSearchStreamRequestPublicExcludeItem.Comments => "comments",
                TraceSearchStreamRequestPublicExcludeItem.CreatedAt => "created_at",
                TraceSearchStreamRequestPublicExcludeItem.CreatedBy => "created_by",
                TraceSearchStreamRequestPublicExcludeItem.Duration => "duration",
                TraceSearchStreamRequestPublicExcludeItem.EndTime => "end_time",
                TraceSearchStreamRequestPublicExcludeItem.ErrorInfo => "error_info",
                TraceSearchStreamRequestPublicExcludeItem.Experiment => "experiment",
                TraceSearchStreamRequestPublicExcludeItem.FeedbackScores => "feedback_scores",
                TraceSearchStreamRequestPublicExcludeItem.GuardrailsValidations => "guardrails_validations",
                TraceSearchStreamRequestPublicExcludeItem.HasToolSpans => "has_tool_spans",
                TraceSearchStreamRequestPublicExcludeItem.Input => "input",
                TraceSearchStreamRequestPublicExcludeItem.LastUpdatedBy => "last_updated_by",
                TraceSearchStreamRequestPublicExcludeItem.LlmSpanCount => "llm_span_count",
                TraceSearchStreamRequestPublicExcludeItem.Metadata => "metadata",
                TraceSearchStreamRequestPublicExcludeItem.Name => "name",
                TraceSearchStreamRequestPublicExcludeItem.Output => "output",
                TraceSearchStreamRequestPublicExcludeItem.Providers => "providers",
                TraceSearchStreamRequestPublicExcludeItem.Source => "source",
                TraceSearchStreamRequestPublicExcludeItem.SpanCount => "span_count",
                TraceSearchStreamRequestPublicExcludeItem.SpanFeedbackScores => "span_feedback_scores",
                TraceSearchStreamRequestPublicExcludeItem.StartTime => "start_time",
                TraceSearchStreamRequestPublicExcludeItem.Tags => "tags",
                TraceSearchStreamRequestPublicExcludeItem.ThreadId => "thread_id",
                TraceSearchStreamRequestPublicExcludeItem.TotalEstimatedCost => "total_estimated_cost",
                TraceSearchStreamRequestPublicExcludeItem.Ttft => "ttft",
                TraceSearchStreamRequestPublicExcludeItem.Usage => "usage",
                TraceSearchStreamRequestPublicExcludeItem.VisibilityMode => "visibility_mode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceSearchStreamRequestPublicExcludeItem? ToEnum(string value)
        {
            return value switch
            {
                "comments" => TraceSearchStreamRequestPublicExcludeItem.Comments,
                "created_at" => TraceSearchStreamRequestPublicExcludeItem.CreatedAt,
                "created_by" => TraceSearchStreamRequestPublicExcludeItem.CreatedBy,
                "duration" => TraceSearchStreamRequestPublicExcludeItem.Duration,
                "end_time" => TraceSearchStreamRequestPublicExcludeItem.EndTime,
                "error_info" => TraceSearchStreamRequestPublicExcludeItem.ErrorInfo,
                "experiment" => TraceSearchStreamRequestPublicExcludeItem.Experiment,
                "feedback_scores" => TraceSearchStreamRequestPublicExcludeItem.FeedbackScores,
                "guardrails_validations" => TraceSearchStreamRequestPublicExcludeItem.GuardrailsValidations,
                "has_tool_spans" => TraceSearchStreamRequestPublicExcludeItem.HasToolSpans,
                "input" => TraceSearchStreamRequestPublicExcludeItem.Input,
                "last_updated_by" => TraceSearchStreamRequestPublicExcludeItem.LastUpdatedBy,
                "llm_span_count" => TraceSearchStreamRequestPublicExcludeItem.LlmSpanCount,
                "metadata" => TraceSearchStreamRequestPublicExcludeItem.Metadata,
                "name" => TraceSearchStreamRequestPublicExcludeItem.Name,
                "output" => TraceSearchStreamRequestPublicExcludeItem.Output,
                "providers" => TraceSearchStreamRequestPublicExcludeItem.Providers,
                "source" => TraceSearchStreamRequestPublicExcludeItem.Source,
                "span_count" => TraceSearchStreamRequestPublicExcludeItem.SpanCount,
                "span_feedback_scores" => TraceSearchStreamRequestPublicExcludeItem.SpanFeedbackScores,
                "start_time" => TraceSearchStreamRequestPublicExcludeItem.StartTime,
                "tags" => TraceSearchStreamRequestPublicExcludeItem.Tags,
                "thread_id" => TraceSearchStreamRequestPublicExcludeItem.ThreadId,
                "total_estimated_cost" => TraceSearchStreamRequestPublicExcludeItem.TotalEstimatedCost,
                "ttft" => TraceSearchStreamRequestPublicExcludeItem.Ttft,
                "usage" => TraceSearchStreamRequestPublicExcludeItem.Usage,
                "visibility_mode" => TraceSearchStreamRequestPublicExcludeItem.VisibilityMode,
                _ => null,
            };
        }
    }
}