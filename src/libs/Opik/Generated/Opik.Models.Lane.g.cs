
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Lane
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public long? TotalTokens { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_breakdown")]
        public bool? HasBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Lane" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="label"></param>
        /// <param name="totalTokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="cacheReadTokens"></param>
        /// <param name="cacheCreationTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="hasBreakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Lane(
            string? key,
            string? label,
            long? totalTokens,
            long? inputTokens,
            long? cacheReadTokens,
            long? cacheCreationTokens,
            long? outputTokens,
            bool? hasBreakdown)
        {
            this.Key = key;
            this.Label = label;
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.CacheReadTokens = cacheReadTokens;
            this.CacheCreationTokens = cacheCreationTokens;
            this.OutputTokens = outputTokens;
            this.HasBreakdown = hasBreakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lane" /> class.
        /// </summary>
        public Lane()
        {
        }

    }
}