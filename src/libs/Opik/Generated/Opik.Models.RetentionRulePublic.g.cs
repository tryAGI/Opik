
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetentionRulePublic
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Computed from projectId and organizationLevel<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.RetentionRulePublicLevelJsonConverter))]
        public global::Opik.RetentionRulePublicLevel? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.RetentionRulePublicRetentionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.RetentionRulePublicRetention Retention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to_past")]
        public bool? ApplyToPast { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRulePublic" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="workspaceId">
        /// Included only in responses
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="level">
        /// Computed from projectId and organizationLevel<br/>
        /// Included only in responses
        /// </param>
        /// <param name="retention"></param>
        /// <param name="applyToPast"></param>
        /// <param name="enabled">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionRulePublic(
            global::Opik.RetentionRulePublicRetention retention,
            global::System.Guid? id,
            string? workspaceId,
            global::System.Guid? projectId,
            global::Opik.RetentionRulePublicLevel? level,
            bool? applyToPast,
            bool? enabled,
            string? createdBy,
            global::System.DateTime? createdAt,
            string? lastUpdatedBy,
            global::System.DateTime? lastUpdatedAt)
        {
            this.Retention = retention;
            this.Id = id;
            this.WorkspaceId = workspaceId;
            this.ProjectId = projectId;
            this.Level = level;
            this.ApplyToPast = applyToPast;
            this.Enabled = enabled;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRulePublic" /> class.
        /// </summary>
        public RetentionRulePublic()
        {
        }
    }
}