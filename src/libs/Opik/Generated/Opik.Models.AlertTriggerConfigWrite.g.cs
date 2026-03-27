
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertTriggerConfigWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AlertTriggerConfigWriteTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AlertTriggerConfigWriteType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_value")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConfigValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerConfigWrite" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="configValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertTriggerConfigWrite(
            global::Opik.AlertTriggerConfigWriteType type,
            global::System.Guid? id,
            global::System.Collections.Generic.Dictionary<string, string>? configValue)
        {
            this.Type = type;
            this.Id = id;
            this.ConfigValue = configValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerConfigWrite" /> class.
        /// </summary>
        public AlertTriggerConfigWrite()
        {
        }
    }
}