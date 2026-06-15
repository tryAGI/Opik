
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendSummaryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Opik.Result>? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_current")]
        public global::System.Collections.Generic.IList<global::Opik.ModelTiers>? SpendCurrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_previous")]
        public global::System.Collections.Generic.IList<global::Opik.ModelTiers>? SpendPrevious { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendSummaryResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="spendCurrent"></param>
        /// <param name="spendPrevious"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendSummaryResponse(
            global::System.Collections.Generic.IList<global::Opik.Result>? results,
            global::System.Collections.Generic.IList<global::Opik.ModelTiers>? spendCurrent,
            global::System.Collections.Generic.IList<global::Opik.ModelTiers>? spendPrevious)
        {
            this.Results = results;
            this.SpendCurrent = spendCurrent;
            this.SpendPrevious = spendPrevious;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendSummaryResponse" /> class.
        /// </summary>
        public SpendSummaryResponse()
        {
        }

    }
}