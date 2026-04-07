
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BridgeCommandBatchResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commands")]
        public global::System.Collections.Generic.IList<global::Opik.BridgeCommandItem>? Commands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandBatchResponse" /> class.
        /// </summary>
        /// <param name="commands"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BridgeCommandBatchResponse(
            global::System.Collections.Generic.IList<global::Opik.BridgeCommandItem>? commands)
        {
            this.Commands = commands;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandBatchResponse" /> class.
        /// </summary>
        public BridgeCommandBatchResponse()
        {
        }
    }
}