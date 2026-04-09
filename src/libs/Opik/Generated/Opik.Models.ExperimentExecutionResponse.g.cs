
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentExecutionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiments")]
        public global::System.Collections.Generic.IList<global::Opik.ExperimentInfo>? Experiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_items")]
        public int? TotalItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentExecutionResponse" /> class.
        /// </summary>
        /// <param name="experiments"></param>
        /// <param name="totalItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentExecutionResponse(
            global::System.Collections.Generic.IList<global::Opik.ExperimentInfo>? experiments,
            int? totalItems)
        {
            this.Experiments = experiments;
            this.TotalItems = totalItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentExecutionResponse" /> class.
        /// </summary>
        public ExperimentExecutionResponse()
        {
        }
    }
}