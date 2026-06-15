
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendBreakdownResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lane_key")]
        public string? LaneKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_model")]
        public global::System.Collections.Generic.IList<global::Opik.ModelTiers>? ByModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_count")]
        public int? ItemCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_unit")]
        public string? ItemUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Opik.Item>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBreakdownResponse" /> class.
        /// </summary>
        /// <param name="laneKey"></param>
        /// <param name="title"></param>
        /// <param name="subtitle"></param>
        /// <param name="totalTokens"></param>
        /// <param name="byModel"></param>
        /// <param name="itemCount"></param>
        /// <param name="itemUnit"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendBreakdownResponse(
            string? laneKey,
            string? title,
            string? subtitle,
            long? totalTokens,
            global::System.Collections.Generic.IList<global::Opik.ModelTiers>? byModel,
            int? itemCount,
            string? itemUnit,
            global::System.Collections.Generic.IList<global::Opik.Item>? items)
        {
            this.LaneKey = laneKey;
            this.Title = title;
            this.Subtitle = subtitle;
            this.TotalTokens = totalTokens;
            this.ByModel = byModel;
            this.ItemCount = itemCount;
            this.ItemUnit = itemUnit;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBreakdownResponse" /> class.
        /// </summary>
        public SpendBreakdownResponse()
        {
        }

    }
}