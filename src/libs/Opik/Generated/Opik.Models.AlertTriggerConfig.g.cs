
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertTriggerConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_trigger_id")]
        public global::System.Guid? AlertTriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AlertTriggerConfigTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AlertTriggerConfigType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_value")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConfigValue { get; set; }

        /// <summary>
        /// Groups configs within a trigger: same group_index means AND between configs, different group_index means OR between groups. Null means a legacy/singleton group of one config. Always null for scope:project configs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_index")]
        public int? GroupIndex { get; set; }

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
        /// Initializes a new instance of the <see cref="AlertTriggerConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="alertTriggerId">
        /// Included only in responses
        /// </param>
        /// <param name="configValue"></param>
        /// <param name="groupIndex">
        /// Groups configs within a trigger: same group_index means AND between configs, different group_index means OR between groups. Null means a legacy/singleton group of one config. Always null for scope:project configs.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertTriggerConfig(
            global::Opik.AlertTriggerConfigType type,
            global::System.Guid? id,
            global::System.Guid? alertTriggerId,
            global::System.Collections.Generic.Dictionary<string, string>? configValue,
            int? groupIndex,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy)
        {
            this.Id = id;
            this.AlertTriggerId = alertTriggerId;
            this.Type = type;
            this.ConfigValue = configValue;
            this.GroupIndex = groupIndex;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerConfig" /> class.
        /// </summary>
        public AlertTriggerConfig()
        {
        }

    }
}