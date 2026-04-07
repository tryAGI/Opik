
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BridgeCommandSubmitResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command_id")]
        public global::System.Guid? CommandId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandSubmitResponse" /> class.
        /// </summary>
        /// <param name="commandId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BridgeCommandSubmitResponse(
            global::System.Guid? commandId)
        {
            this.CommandId = commandId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandSubmitResponse" /> class.
        /// </summary>
        public BridgeCommandSubmitResponse()
        {
        }
    }
}