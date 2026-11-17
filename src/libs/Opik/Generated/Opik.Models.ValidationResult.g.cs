
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidationResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_passed")]
        public bool? ValidationPassed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ValidationResultTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.ValidationResultType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.JsonNode ValidationConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.JsonNode ValidationDetails { get; set; }

        /// <summary>
        /// Set when the check could not run; the entry then passes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="validationConfig"></param>
        /// <param name="validationDetails"></param>
        /// <param name="validationPassed"></param>
        /// <param name="error">
        /// Set when the check could not run; the entry then passes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationResult(
            global::Opik.ValidationResultType type,
            global::Opik.JsonNode validationConfig,
            global::Opik.JsonNode validationDetails,
            bool? validationPassed,
            string? error)
        {
            this.ValidationPassed = validationPassed;
            this.Type = type;
            this.ValidationConfig = validationConfig ?? throw new global::System.ArgumentNullException(nameof(validationConfig));
            this.ValidationDetails = validationDetails ?? throw new global::System.ArgumentNullException(nameof(validationDetails));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult" /> class.
        /// </summary>
        public ValidationResult()
        {
        }

    }
}