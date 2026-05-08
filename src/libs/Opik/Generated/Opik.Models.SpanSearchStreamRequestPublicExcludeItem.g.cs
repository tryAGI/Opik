
#nullable enable

namespace Opik
{
    /// <summary>
    /// Fields to exclude from the response
    /// </summary>
    public enum SpanSearchStreamRequestPublicExcludeItem
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
        Environment,
        /// <summary>
        /// 
        /// </summary>
        ErrorInfo,
        /// <summary>
        /// 
        /// </summary>
        FeedbackScores,
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
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Model,
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
        Provider,
        /// <summary>
        /// 
        /// </summary>
        Source,
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
        TotalEstimatedCost,
        /// <summary>
        /// 
        /// </summary>
        TotalEstimatedCostVersion,
        /// <summary>
        /// 
        /// </summary>
        Ttft,
        /// <summary>
        /// 
        /// </summary>
        Type,
        /// <summary>
        /// 
        /// </summary>
        Usage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanSearchStreamRequestPublicExcludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanSearchStreamRequestPublicExcludeItem value)
        {
            return value switch
            {
                SpanSearchStreamRequestPublicExcludeItem.Comments => "comments",
                SpanSearchStreamRequestPublicExcludeItem.CreatedAt => "created_at",
                SpanSearchStreamRequestPublicExcludeItem.CreatedBy => "created_by",
                SpanSearchStreamRequestPublicExcludeItem.Duration => "duration",
                SpanSearchStreamRequestPublicExcludeItem.EndTime => "end_time",
                SpanSearchStreamRequestPublicExcludeItem.Environment => "environment",
                SpanSearchStreamRequestPublicExcludeItem.ErrorInfo => "error_info",
                SpanSearchStreamRequestPublicExcludeItem.FeedbackScores => "feedback_scores",
                SpanSearchStreamRequestPublicExcludeItem.Input => "input",
                SpanSearchStreamRequestPublicExcludeItem.LastUpdatedBy => "last_updated_by",
                SpanSearchStreamRequestPublicExcludeItem.Metadata => "metadata",
                SpanSearchStreamRequestPublicExcludeItem.Model => "model",
                SpanSearchStreamRequestPublicExcludeItem.Name => "name",
                SpanSearchStreamRequestPublicExcludeItem.Output => "output",
                SpanSearchStreamRequestPublicExcludeItem.Provider => "provider",
                SpanSearchStreamRequestPublicExcludeItem.Source => "source",
                SpanSearchStreamRequestPublicExcludeItem.StartTime => "start_time",
                SpanSearchStreamRequestPublicExcludeItem.Tags => "tags",
                SpanSearchStreamRequestPublicExcludeItem.TotalEstimatedCost => "total_estimated_cost",
                SpanSearchStreamRequestPublicExcludeItem.TotalEstimatedCostVersion => "total_estimated_cost_version",
                SpanSearchStreamRequestPublicExcludeItem.Ttft => "ttft",
                SpanSearchStreamRequestPublicExcludeItem.Type => "type",
                SpanSearchStreamRequestPublicExcludeItem.Usage => "usage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanSearchStreamRequestPublicExcludeItem? ToEnum(string value)
        {
            return value switch
            {
                "comments" => SpanSearchStreamRequestPublicExcludeItem.Comments,
                "created_at" => SpanSearchStreamRequestPublicExcludeItem.CreatedAt,
                "created_by" => SpanSearchStreamRequestPublicExcludeItem.CreatedBy,
                "duration" => SpanSearchStreamRequestPublicExcludeItem.Duration,
                "end_time" => SpanSearchStreamRequestPublicExcludeItem.EndTime,
                "environment" => SpanSearchStreamRequestPublicExcludeItem.Environment,
                "error_info" => SpanSearchStreamRequestPublicExcludeItem.ErrorInfo,
                "feedback_scores" => SpanSearchStreamRequestPublicExcludeItem.FeedbackScores,
                "input" => SpanSearchStreamRequestPublicExcludeItem.Input,
                "last_updated_by" => SpanSearchStreamRequestPublicExcludeItem.LastUpdatedBy,
                "metadata" => SpanSearchStreamRequestPublicExcludeItem.Metadata,
                "model" => SpanSearchStreamRequestPublicExcludeItem.Model,
                "name" => SpanSearchStreamRequestPublicExcludeItem.Name,
                "output" => SpanSearchStreamRequestPublicExcludeItem.Output,
                "provider" => SpanSearchStreamRequestPublicExcludeItem.Provider,
                "source" => SpanSearchStreamRequestPublicExcludeItem.Source,
                "start_time" => SpanSearchStreamRequestPublicExcludeItem.StartTime,
                "tags" => SpanSearchStreamRequestPublicExcludeItem.Tags,
                "total_estimated_cost" => SpanSearchStreamRequestPublicExcludeItem.TotalEstimatedCost,
                "total_estimated_cost_version" => SpanSearchStreamRequestPublicExcludeItem.TotalEstimatedCostVersion,
                "ttft" => SpanSearchStreamRequestPublicExcludeItem.Ttft,
                "type" => SpanSearchStreamRequestPublicExcludeItem.Type,
                "usage" => SpanSearchStreamRequestPublicExcludeItem.Usage,
                _ => null,
            };
        }
    }
}