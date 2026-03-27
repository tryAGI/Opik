
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetentionRuleWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Set to true to create an organization-level rule<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_level")]
        public bool? OrganizationLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.RetentionRuleWriteRetentionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.RetentionRuleWriteRetention Retention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to_past")]
        public bool? ApplyToPast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRuleWrite" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationLevel">
        /// Set to true to create an organization-level rule<br/>
        /// Included only in requests
        /// </param>
        /// <param name="retention"></param>
        /// <param name="applyToPast"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionRuleWrite(
            global::Opik.RetentionRuleWriteRetention retention,
            global::System.Guid? projectId,
            bool? organizationLevel,
            bool? applyToPast)
        {
            this.Retention = retention;
            this.ProjectId = projectId;
            this.OrganizationLevel = organizationLevel;
            this.ApplyToPast = applyToPast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionRuleWrite" /> class.
        /// </summary>
        public RetentionRuleWrite()
        {
        }
    }
}