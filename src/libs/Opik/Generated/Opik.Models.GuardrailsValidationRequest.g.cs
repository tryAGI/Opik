
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailsValidationRequest
    {
        /// <summary>
        /// The text to check, at most 16384 characters as the decision service counts them: on the text's JSON encoding, so the two quotes count, a quote, backslash or line break counts as 2, and any other control or non-ASCII character as 6 (an emoji as 12). In practice about 16,380 characters of English text fit, about 2,730 of text in Cyrillic, Greek, Hebrew, Arabic, Chinese or Japanese, and about 1,365 emoji. A longer text is rejected rather than cut.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The checks to run. Together they must fit in 64 questions to the decision service, asked in up to two calls of 32: each PII class and each topic list is one question, prompt injection is one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.ValidationDescriptor> Validations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidationRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to check, at most 16384 characters as the decision service counts them: on the text's JSON encoding, so the two quotes count, a quote, backslash or line break counts as 2, and any other control or non-ASCII character as 6 (an emoji as 12). In practice about 16,380 characters of English text fit, about 2,730 of text in Cyrillic, Greek, Hebrew, Arabic, Chinese or Japanese, and about 1,365 emoji. A longer text is rejected rather than cut.
        /// </param>
        /// <param name="validations">
        /// The checks to run. Together they must fit in 64 questions to the decision service, asked in up to two calls of 32: each PII class and each topic list is one question, prompt injection is one
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsValidationRequest(
            string text,
            global::System.Collections.Generic.IList<global::Opik.ValidationDescriptor> validations)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Validations = validations ?? throw new global::System.ArgumentNullException(nameof(validations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidationRequest" /> class.
        /// </summary>
        public GuardrailsValidationRequest()
        {
        }

    }
}