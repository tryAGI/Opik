
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelTiers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public long? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_tokens")]
        public long? CacheReadTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_tokens")]
        public long? CacheCreationTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public long? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTiers" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="inputTokens"></param>
        /// <param name="cacheReadTokens"></param>
        /// <param name="cacheCreationTokens"></param>
        /// <param name="outputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelTiers(
            string? model,
            long? inputTokens,
            long? cacheReadTokens,
            long? cacheCreationTokens,
            long? outputTokens)
        {
            this.Model = model;
            this.InputTokens = inputTokens;
            this.CacheReadTokens = cacheReadTokens;
            this.CacheCreationTokens = cacheCreationTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTiers" /> class.
        /// </summary>
        public ModelTiers()
        {
        }

    }
}