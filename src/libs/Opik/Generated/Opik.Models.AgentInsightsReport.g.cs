
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentInsightsReport
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
        [global::System.Text.Json.Serialization.JsonPropertyName("report_day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReportDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.ReportedIssue> Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsReport" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="reportDay"></param>
        /// <param name="issues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightsReport(
            global::System.Guid projectId,
            global::System.DateTime reportDay,
            global::System.Collections.Generic.IList<global::Opik.ReportedIssue> issues)
        {
            this.ProjectId = projectId;
            this.ReportDay = reportDay;
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsReport" /> class.
        /// </summary>
        public AgentInsightsReport()
        {
        }

    }
}