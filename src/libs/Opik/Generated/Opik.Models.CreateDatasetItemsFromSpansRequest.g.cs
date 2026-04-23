
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetItemsFromSpansRequest
    {
        /// <summary>
        /// Set of span IDs to add to the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SpanIds { get; set; }

        /// <summary>
        /// Options for enriching span data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichment_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.SpanEnrichmentOptions EnrichmentOptions { get; set; }

        /// <summary>
        /// Optional evaluators to apply to the created items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItem>? Evaluators { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_policy")]
        public global::Opik.ExecutionPolicy? ExecutionPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromSpansRequest" /> class.
        /// </summary>
        /// <param name="spanIds">
        /// Set of span IDs to add to the dataset
        /// </param>
        /// <param name="enrichmentOptions">
        /// Options for enriching span data
        /// </param>
        /// <param name="evaluators">
        /// Optional evaluators to apply to the created items
        /// </param>
        /// <param name="executionPolicy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetItemsFromSpansRequest(
            global::System.Collections.Generic.IList<global::System.Guid> spanIds,
            global::Opik.SpanEnrichmentOptions enrichmentOptions,
            global::System.Collections.Generic.IList<global::Opik.EvaluatorItem>? evaluators,
            global::Opik.ExecutionPolicy? executionPolicy)
        {
            this.SpanIds = spanIds ?? throw new global::System.ArgumentNullException(nameof(spanIds));
            this.EnrichmentOptions = enrichmentOptions ?? throw new global::System.ArgumentNullException(nameof(enrichmentOptions));
            this.Evaluators = evaluators;
            this.ExecutionPolicy = executionPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromSpansRequest" /> class.
        /// </summary>
        public CreateDatasetItemsFromSpansRequest()
        {
        }
    }
}