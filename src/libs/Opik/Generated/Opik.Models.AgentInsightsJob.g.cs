
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentInsightsJob
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AgentInsightsJobStatusJsonConverter))]
        public global::Opik.AgentInsightsJobStatus? Status { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_first_run_enrolled")]
        public bool? AutoFirstRunEnrolled { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_first_run_at")]
        public global::System.DateTime? AutoFirstRunAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_scan_at")]
        public global::System.DateTime? LastScanAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_failure_reason")]
        public string? LastFailureReason { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_failure_detail")]
        public string? LastFailureDetail { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_failed_at")]
        public global::System.DateTime? LastFailedAt { get; set; }

        /// <summary>
        /// Project guidance sent to every run; null when none<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance")]
        public string? Guidance { get; set; }

        /// <summary>
        /// Who last saved the guidance<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_updated_by")]
        public string? GuidanceUpdatedBy { get; set; }

        /// <summary>
        /// When the guidance was last saved<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_updated_at")]
        public global::System.DateTime? GuidanceUpdatedAt { get; set; }

        /// <summary>
        /// Bumped each time the guidance text changes; 0 = never saved<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_version")]
        public int? GuidanceVersion { get; set; }

        /// <summary>
        /// Guidance version the current results were produced with; null = no run since guidance existed<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results_guidance_version")]
        public int? ResultsGuidanceVersion { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="autoFirstRunEnrolled">
        /// Included only in responses
        /// </param>
        /// <param name="autoFirstRunAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastScanAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastFailureReason">
        /// Included only in responses
        /// </param>
        /// <param name="lastFailureDetail">
        /// Included only in responses
        /// </param>
        /// <param name="lastFailedAt">
        /// Included only in responses
        /// </param>
        /// <param name="guidance">
        /// Project guidance sent to every run; null when none<br/>
        /// Included only in responses
        /// </param>
        /// <param name="guidanceUpdatedBy">
        /// Who last saved the guidance<br/>
        /// Included only in responses
        /// </param>
        /// <param name="guidanceUpdatedAt">
        /// When the guidance was last saved<br/>
        /// Included only in responses
        /// </param>
        /// <param name="guidanceVersion">
        /// Bumped each time the guidance text changes; 0 = never saved<br/>
        /// Included only in responses
        /// </param>
        /// <param name="resultsGuidanceVersion">
        /// Guidance version the current results were produced with; null = no run since guidance existed<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightsJob(
            global::System.Guid? id,
            global::Opik.AgentInsightsJobStatus? status,
            bool? autoFirstRunEnrolled,
            global::System.DateTime? autoFirstRunAt,
            global::System.DateTime? lastScanAt,
            string? lastFailureReason,
            string? lastFailureDetail,
            global::System.DateTime? lastFailedAt,
            string? guidance,
            string? guidanceUpdatedBy,
            global::System.DateTime? guidanceUpdatedAt,
            int? guidanceVersion,
            int? resultsGuidanceVersion,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            global::System.Guid projectId = default!)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Status = status;
            this.AutoFirstRunEnrolled = autoFirstRunEnrolled;
            this.AutoFirstRunAt = autoFirstRunAt;
            this.LastScanAt = lastScanAt;
            this.LastFailureReason = lastFailureReason;
            this.LastFailureDetail = lastFailureDetail;
            this.LastFailedAt = lastFailedAt;
            this.Guidance = guidance;
            this.GuidanceUpdatedBy = guidanceUpdatedBy;
            this.GuidanceUpdatedAt = guidanceUpdatedAt;
            this.GuidanceVersion = guidanceVersion;
            this.ResultsGuidanceVersion = resultsGuidanceVersion;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsJob" /> class.
        /// </summary>
        public AgentInsightsJob()
        {
        }

    }
}