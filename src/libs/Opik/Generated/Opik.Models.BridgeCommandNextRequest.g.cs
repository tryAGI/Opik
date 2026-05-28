
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BridgeCommandNextRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_commands")]
        public int? MaxCommands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandNextRequest" /> class.
        /// </summary>
        /// <param name="maxCommands"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BridgeCommandNextRequest(
            int? maxCommands)
        {
            this.MaxCommands = maxCommands;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BridgeCommandNextRequest" /> class.
        /// </summary>
        public BridgeCommandNextRequest()
        {
        }

    }
}