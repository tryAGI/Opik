
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssertionResultBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AssertionResultBatchEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AssertionResultBatchEntityType EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assertion_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.AssertionResultBatchItem> AssertionResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionResultBatch" /> class.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="assertionResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssertionResultBatch(
            global::Opik.AssertionResultBatchEntityType entityType,
            global::System.Collections.Generic.IList<global::Opik.AssertionResultBatchItem> assertionResults)
        {
            this.EntityType = entityType;
            this.AssertionResults = assertionResults ?? throw new global::System.ArgumentNullException(nameof(assertionResults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertionResultBatch" /> class.
        /// </summary>
        public AssertionResultBatch()
        {
        }
    }
}