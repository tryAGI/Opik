
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BridgeCommandItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_id")]
        public global::System.Guid? CommandId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.BridgeCommandItemTypeJsonConverter))]
        public global::Opik.BridgeCommandItemType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::Opik.JsonNode? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandItem" /> class.
        /// </summary>
        /// <param name="commandId"></param>
        /// <param name="type"></param>
        /// <param name="args"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="submittedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BridgeCommandItem(
            global::System.Guid? commandId,
            global::Opik.BridgeCommandItemType? type,
            global::Opik.JsonNode? args,
            int? timeoutSeconds,
            global::System.DateTime? submittedAt)
        {
            this.CommandId = commandId;
            this.Type = type;
            this.Args = args;
            this.TimeoutSeconds = timeoutSeconds;
            this.SubmittedAt = submittedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandItem" /> class.
        /// </summary>
        public BridgeCommandItem()
        {
        }
    }
}