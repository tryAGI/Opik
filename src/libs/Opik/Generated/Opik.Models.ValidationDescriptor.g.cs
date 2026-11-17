
#nullable enable

namespace Opik
{
    /// <summary>
    /// The checks to run. Together they must fit in 64 questions to the decision service, asked in up to two calls of 32: each PII class and each topic list is one question, prompt injection is one
    /// </summary>
    public sealed partial class ValidationDescriptor
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ValidationDescriptorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.ValidationDescriptorType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.JsonNode Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationDescriptor" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationDescriptor(
            global::Opik.ValidationDescriptorType type,
            global::Opik.JsonNode config)
        {
            this.Type = type;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationDescriptor" /> class.
        /// </summary>
        public ValidationDescriptor()
        {
        }

    }
}