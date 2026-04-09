
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        public global::System.Guid? ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_index")]
        public int? PromptIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentInfo" /> class.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="promptIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentInfo(
            global::System.Guid? experimentId,
            int? promptIndex)
        {
            this.ExperimentId = experimentId;
            this.PromptIndex = promptIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentInfo" /> class.
        /// </summary>
        public ExperimentInfo()
        {
        }
    }
}