
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpanLlmAsJudgeCodePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.LlmAsJudgeModelParametersPublic Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessagePublic> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Variables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaPublic> Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanLlmAsJudgeCodePublic" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="variables"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpanLlmAsJudgeCodePublic(
            global::Opik.LlmAsJudgeModelParametersPublic model,
            global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessagePublic> messages,
            global::System.Collections.Generic.Dictionary<string, string> variables,
            global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaPublic> schema)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanLlmAsJudgeCodePublic" /> class.
        /// </summary>
        public SpanLlmAsJudgeCodePublic()
        {
        }

    }
}