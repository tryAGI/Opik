
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateDatasetItemsFromTracesRequest
    {
        /// <summary>
        /// Set of trace IDs to add to the dataset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TraceIds { get; set; }

        /// <summary>
        /// Options for enriching trace data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichment_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.TraceEnrichmentOptions EnrichmentOptions { get; set; }

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
        /// Optional mapping of dataset item field name to a path into the trace, e.g. 'input.input_text'. Takes precedence over the fields produced by enrichment_options. Ignored for test suite datasets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_mappings")]
        public global::System.Collections.Generic.Dictionary<string, string>? FieldMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromTracesRequest" /> class.
        /// </summary>
        /// <param name="traceIds">
        /// Set of trace IDs to add to the dataset
        /// </param>
        /// <param name="enrichmentOptions">
        /// Options for enriching trace data
        /// </param>
        /// <param name="evaluators">
        /// Optional evaluators to apply to the created items
        /// </param>
        /// <param name="executionPolicy">
        /// Included only in responses
        /// </param>
        /// <param name="fieldMappings">
        /// Optional mapping of dataset item field name to a path into the trace, e.g. 'input.input_text'. Takes precedence over the fields produced by enrichment_options. Ignored for test suite datasets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetItemsFromTracesRequest(
            global::System.Collections.Generic.IList<global::System.Guid> traceIds,
            global::Opik.TraceEnrichmentOptions enrichmentOptions,
            global::System.Collections.Generic.IList<global::Opik.EvaluatorItem>? evaluators,
            global::Opik.ExecutionPolicy? executionPolicy,
            global::System.Collections.Generic.Dictionary<string, string>? fieldMappings)
        {
            this.TraceIds = traceIds ?? throw new global::System.ArgumentNullException(nameof(traceIds));
            this.EnrichmentOptions = enrichmentOptions ?? throw new global::System.ArgumentNullException(nameof(enrichmentOptions));
            this.Evaluators = evaluators;
            this.ExecutionPolicy = executionPolicy;
            this.FieldMappings = fieldMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromTracesRequest" /> class.
        /// </summary>
        public CreateDatasetItemsFromTracesRequest()
        {
        }

    }
}