
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendRecommendationsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_savings")]
        public double? TotalSavings { get; set; }

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
        /// Initializes a new instance of the <see cref="SpendRecommendationsResponse" /> class.
        /// </summary>
        /// <param name="totalSavings"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendRecommendationsResponse(
            double? totalSavings,
            global::System.Collections.Generic.IList<global::Opik.Item>? items)
        {
            this.TotalSavings = totalSavings;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendRecommendationsResponse" /> class.
        /// </summary>
        public SpendRecommendationsResponse()
        {
        }

    }
}