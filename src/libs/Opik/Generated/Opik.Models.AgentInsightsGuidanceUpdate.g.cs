
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentInsightsGuidanceUpdate
    {
        /// <summary>
        /// Project guidance for Agent Insights runs. Empty or whitespace-only clears it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Guidance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsGuidanceUpdate" /> class.
        /// </summary>
        /// <param name="guidance">
        /// Project guidance for Agent Insights runs. Empty or whitespace-only clears it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightsGuidanceUpdate(
            string guidance)
        {
            this.Guidance = guidance ?? throw new global::System.ArgumentNullException(nameof(guidance));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsGuidanceUpdate" /> class.
        /// </summary>
        public AgentInsightsGuidanceUpdate()
        {
        }

    }
}