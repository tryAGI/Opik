
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LlmAsJudgeModelParameters
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_parameters")]
        public global::Opik.JsonNode? CustomParameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.LlmAsJudgeModelParametersApiJsonConverter))]
        public global::Opik.LlmAsJudgeModelParametersApi? Api { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeModelParameters" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temperature"></param>
        /// <param name="seed"></param>
        /// <param name="customParameters"></param>
        /// <param name="api"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmAsJudgeModelParameters(
            string name,
            double? temperature,
            int? seed,
            global::Opik.JsonNode? customParameters,
            global::Opik.LlmAsJudgeModelParametersApi? api)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Temperature = temperature;
            this.Seed = seed;
            this.CustomParameters = customParameters;
            this.Api = api;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeModelParameters" /> class.
        /// </summary>
        public LlmAsJudgeModelParameters()
        {
        }

    }
}