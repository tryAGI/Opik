
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HarnessEntry
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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HarnessEntry" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="label"></param>
        /// <param name="totalEstimatedCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HarnessEntry(
            string? key,
            string? label,
            double? totalEstimatedCost)
        {
            this.Key = key;
            this.Label = label;
            this.TotalEstimatedCost = totalEstimatedCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HarnessEntry" /> class.
        /// </summary>
        public HarnessEntry()
        {
        }

    }
}