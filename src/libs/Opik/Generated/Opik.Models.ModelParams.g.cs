
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public global::Opik.NumberParam? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public global::Opik.NumberParam? TopP { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public global::Opik.NumberParam? TopK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequencyPenalty")]
        public global::Opik.NumberParam? FrequencyPenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presencePenalty")]
        public global::Opik.NumberParam? PresencePenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOutputTokens")]
        public global::Opik.NumberParam? MaxOutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::Opik.FlagParam? Stop { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public global::Opik.FlagParam? Seed { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::Opik.EffortParam? Effort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::Opik.ToolsParam? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samplingExclusive")]
        public bool? SamplingExclusive { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinksByDefault")]
        public bool? ThinksByDefault { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ModelParams>? Routes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParams" /> class.
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="stop"></param>
        /// <param name="seed"></param>
        /// <param name="effort"></param>
        /// <param name="tools"></param>
        /// <param name="samplingExclusive"></param>
        /// <param name="thinksByDefault"></param>
        /// <param name="routes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelParams(
            global::Opik.NumberParam? temperature,
            global::Opik.NumberParam? topP,
            global::Opik.NumberParam? topK,
            global::Opik.NumberParam? frequencyPenalty,
            global::Opik.NumberParam? presencePenalty,
            global::Opik.NumberParam? maxOutputTokens,
            global::Opik.FlagParam? stop,
            global::Opik.FlagParam? seed,
            global::Opik.EffortParam? effort,
            global::Opik.ToolsParam? tools,
            bool? samplingExclusive,
            bool? thinksByDefault,
            global::System.Collections.Generic.Dictionary<string, global::Opik.ModelParams>? routes)
        {
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.MaxOutputTokens = maxOutputTokens;
            this.Stop = stop;
            this.Seed = seed;
            this.Effort = effort;
            this.Tools = tools;
            this.SamplingExclusive = samplingExclusive;
            this.ThinksByDefault = thinksByDefault;
            this.Routes = routes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelParams" /> class.
        /// </summary>
        public ModelParams()
        {
        }

    }
}