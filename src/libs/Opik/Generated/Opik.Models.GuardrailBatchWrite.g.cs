
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailBatchWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.GuardrailWrite> Guardrails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBatchWrite" /> class.
        /// </summary>
        /// <param name="guardrails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailBatchWrite(
            global::System.Collections.Generic.IList<global::Opik.GuardrailWrite> guardrails)
        {
            this.Guardrails = guardrails ?? throw new global::System.ArgumentNullException(nameof(guardrails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailBatchWrite" /> class.
        /// </summary>
        public GuardrailBatchWrite()
        {
        }

    }
}