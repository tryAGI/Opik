
#nullable enable

namespace Opik
{
    /// <summary>
    /// Per-day breakdown within the requested window, ordered by report_day ascending
    /// </summary>
    public sealed partial class AgentInsightsIssueDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_day")]
        public global::System.DateTime? ReportDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_impacted")]
        public long? UsersImpacted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_users")]
        public long? TotalUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Opik.JsonNode? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsIssueDetail" /> class.
        /// </summary>
        /// <param name="reportDay"></param>
        /// <param name="count"></param>
        /// <param name="totalCount"></param>
        /// <param name="usersImpacted"></param>
        /// <param name="totalUsers"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentInsightsIssueDetail(
            global::System.DateTime? reportDay,
            long? count,
            long? totalCount,
            long? usersImpacted,
            long? totalUsers,
            global::Opik.JsonNode? metadata)
        {
            this.ReportDay = reportDay;
            this.Count = count;
            this.TotalCount = totalCount;
            this.UsersImpacted = usersImpacted;
            this.TotalUsers = totalUsers;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentInsightsIssueDetail" /> class.
        /// </summary>
        public AgentInsightsIssueDetail()
        {
        }

    }
}