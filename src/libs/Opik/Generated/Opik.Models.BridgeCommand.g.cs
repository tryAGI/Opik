
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BridgeCommand
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_id")]
        public global::System.Guid? CommandId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        public global::System.Guid? RunnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.BridgeCommandTypeJsonConverter))]
        public global::Opik.BridgeCommandType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.BridgeCommandStatusJsonConverter))]
        public global::Opik.BridgeCommandStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::Opik.JsonNode? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::Opik.JsonNode? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Opik.JsonNode? Error { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picked_up_at")]
        public global::System.DateTime? PickedUpAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public long? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommand" /> class.
        /// </summary>
        /// <param name="commandId"></param>
        /// <param name="runnerId"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="args"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="submittedAt"></param>
        /// <param name="pickedUpAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="durationMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BridgeCommand(
            global::System.Guid? commandId,
            global::System.Guid? runnerId,
            global::Opik.BridgeCommandType? type,
            global::Opik.BridgeCommandStatus? status,
            global::Opik.JsonNode? args,
            global::Opik.JsonNode? result,
            global::Opik.JsonNode? error,
            int? timeoutSeconds,
            global::System.DateTime? submittedAt,
            global::System.DateTime? pickedUpAt,
            global::System.DateTime? completedAt,
            long? durationMs)
        {
            this.CommandId = commandId;
            this.RunnerId = runnerId;
            this.Type = type;
            this.Status = status;
            this.Args = args;
            this.Result = result;
            this.Error = error;
            this.TimeoutSeconds = timeoutSeconds;
            this.SubmittedAt = submittedAt;
            this.PickedUpAt = pickedUpAt;
            this.CompletedAt = completedAt;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommand" /> class.
        /// </summary>
        public BridgeCommand()
        {
        }
    }
}