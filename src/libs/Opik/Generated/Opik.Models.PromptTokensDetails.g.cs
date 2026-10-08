
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptTokensDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedTokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWriteTokens")]
        public int? CacheWriteTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens"></param>
        /// <param name="cacheWriteTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptTokensDetails(
            int? cachedTokens,
            int? cacheWriteTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTokensDetails" /> class.
        /// </summary>
        public PromptTokensDetails()
        {
        }

    }
}