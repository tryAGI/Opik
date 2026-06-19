
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentInsightsIssue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cause")]
        public string? Cause { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggested_fix")]
        public string? SuggestedFix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AgentInsightsIssueStatusJsonConverter))]
        public global::Opik.AgentInsightsIssueStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AgentInsightsIssueSeverityJsonConverter))]
        public global::Opik.AgentInsightsIssueSeverity? Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traces_query")]
        public string? TracesQuery { get; set; }

        /// <summary>
        /// SUM(count) over the requested window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_occurrences")]
        public long? TotalOccurrences { get; set; }

        /// <summary>
        /// SUM(total_count) over the requested window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// SUM(users_impacted) over the requested window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_impacted")]
        public long? UsersImpacted { get; set; }

        /// <summary>
        /// SUM(total_users) over the requested window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_users")]
        public long? TotalUsers { get; set; }

        /// <summary>
        /// MIN(report_day) in the requested window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen")]
        public global::System.DateTime? FirstSeen { get; set; }

        /// <summary>
        /// MAX(report_day) in the requested window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        public global::System.DateTime? LastSeen { get; set; }

        /// <summary>
        /// COUNT(DISTINCT report_day) in the requested window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days_reported")]
        public long? DaysReported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsIssue" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cause"></param>
        /// <param name="suggestedFix"></param>
        /// <param name="status"></param>
        /// <param name="severity"></param>
        /// <param name="tracesQuery"></param>
        /// <param name="totalOccurrences">
        /// SUM(count) over the requested window
        /// </param>
        /// <param name="total">
        /// SUM(total_count) over the requested window
        /// </param>
        /// <param name="usersImpacted">
        /// SUM(users_impacted) over the requested window
        /// </param>
        /// <param name="totalUsers">
        /// SUM(total_users) over the requested window
        /// </param>
        /// <param name="firstSeen">
        /// MIN(report_day) in the requested window
        /// </param>
        /// <param name="lastSeen">
        /// MAX(report_day) in the requested window
        /// </param>
        /// <param name="daysReported">
        /// COUNT(DISTINCT report_day) in the requested window
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="lastUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightsIssue(
            global::System.Guid? id,
            string? name,
            string? description,
            string? cause,
            string? suggestedFix,
            global::Opik.AgentInsightsIssueStatus? status,
            global::Opik.AgentInsightsIssueSeverity? severity,
            string? tracesQuery,
            long? totalOccurrences,
            long? total,
            long? usersImpacted,
            long? totalUsers,
            global::System.DateTime? firstSeen,
            global::System.DateTime? lastSeen,
            long? daysReported,
            string? createdBy,
            global::System.DateTime? createdAt,
            string? lastUpdatedBy,
            global::System.DateTime? lastUpdatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Cause = cause;
            this.SuggestedFix = suggestedFix;
            this.Status = status;
            this.Severity = severity;
            this.TracesQuery = tracesQuery;
            this.TotalOccurrences = totalOccurrences;
            this.Total = total;
            this.UsersImpacted = usersImpacted;
            this.TotalUsers = totalUsers;
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.DaysReported = daysReported;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsIssue" /> class.
        /// </summary>
        public AgentInsightsIssue()
        {
        }

    }
}