
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentInsightsJobUpdate
    {
        /// <summary>
        /// New status for the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AgentInsightsJobUpdateStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AgentInsightsJobUpdateStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsJobUpdate" /> class.
        /// </summary>
        /// <param name="status">
        /// New status for the job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightsJobUpdate(
            global::Opik.AgentInsightsJobUpdateStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsJobUpdate" /> class.
        /// </summary>
        public AgentInsightsJobUpdate()
        {
        }

    }
}