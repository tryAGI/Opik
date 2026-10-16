
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentInsightsIssueUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AgentInsightsIssueUpdateStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AgentInsightsIssueUpdateStatus Status { get; set; }

        /// <summary>
        /// Why the issue is closed as not useful. Stored only with status closed; any other status clears it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("close_note")]
        public string? CloseNote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsIssueUpdate" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="status"></param>
        /// <param name="closeNote">
        /// Why the issue is closed as not useful. Stored only with status closed; any other status clears it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightsIssueUpdate(
            global::System.Guid projectId,
            global::Opik.AgentInsightsIssueUpdateStatus status,
            string? closeNote)
        {
            this.ProjectId = projectId;
            this.Status = status;
            this.CloseNote = closeNote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsIssueUpdate" /> class.
        /// </summary>
        public AgentInsightsIssueUpdate()
        {
        }

    }
}