
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Side
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lanes")]
        public global::System.Collections.Generic.IList<global::Opik.Lane>? Lanes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Side" /> class.
        /// </summary>
        /// <param name="totalTokens"></param>
        /// <param name="lanes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Side(
            long? totalTokens,
            global::System.Collections.Generic.IList<global::Opik.Lane>? lanes)
        {
            this.TotalTokens = totalTokens;
            this.Lanes = lanes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Side" /> class.
        /// </summary>
        public Side()
        {
        }

    }
}