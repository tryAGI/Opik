
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatCompletions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ToolsParamChatCompletionsJsonConverter))]
        public global::Opik.ToolsParamChatCompletions? ChatCompletions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forcedChoice")]
        public global::Opik.FlagParam? ForcedChoice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsParam" /> class.
        /// </summary>
        /// <param name="chatCompletions"></param>
        /// <param name="forcedChoice"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsParam(
            global::Opik.ToolsParamChatCompletions? chatCompletions,
            global::Opik.FlagParam? forcedChoice)
        {
            this.ChatCompletions = chatCompletions;
            this.ForcedChoice = forcedChoice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsParam" /> class.
        /// </summary>
        public ToolsParam()
        {
        }

    }
}