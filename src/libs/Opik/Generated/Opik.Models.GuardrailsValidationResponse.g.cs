
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailsValidationResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_passed")]
        public bool? ValidationPassed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.ValidationResult> Validations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidationResponse" /> class.
        /// </summary>
        /// <param name="validations"></param>
        /// <param name="validationPassed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsValidationResponse(
            global::System.Collections.Generic.IList<global::Opik.ValidationResult> validations,
            bool? validationPassed)
        {
            this.ValidationPassed = validationPassed;
            this.Validations = validations ?? throw new global::System.ArgumentNullException(nameof(validations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsValidationResponse" /> class.
        /// </summary>
        public GuardrailsValidationResponse()
        {
        }

    }
}