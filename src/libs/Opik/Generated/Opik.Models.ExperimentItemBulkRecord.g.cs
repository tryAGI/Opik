
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemBulkRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluate_task_result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.JsonListStringJsonConverter))]
        public global::Opik.JsonListString? EvaluateTaskResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::Opik.Trace? Trace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Opik.Span>? Spans { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_scores")]
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScore>? FeedbackScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkRecord" /> class.
        /// </summary>
        /// <param name="datasetItemId"></param>
        /// <param name="evaluateTaskResult"></param>
        /// <param name="trace"></param>
        /// <param name="spans"></param>
        /// <param name="feedbackScores"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItemBulkRecord(
            global::System.Guid datasetItemId,
            global::Opik.JsonListString? evaluateTaskResult,
            global::Opik.Trace? trace,
            global::System.Collections.Generic.IList<global::Opik.Span>? spans,
            global::System.Collections.Generic.IList<global::Opik.FeedbackScore>? feedbackScores)
        {
            this.DatasetItemId = datasetItemId;
            this.EvaluateTaskResult = evaluateTaskResult;
            this.Trace = trace;
            this.Spans = spans;
            this.FeedbackScores = feedbackScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkRecord" /> class.
        /// </summary>
        public ExperimentItemBulkRecord()
        {
        }

    }
}