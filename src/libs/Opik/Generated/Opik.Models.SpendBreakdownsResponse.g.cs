
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendBreakdownsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdowns")]
        public global::System.Collections.Generic.IList<global::Opik.SpendBreakdownResponse>? Breakdowns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBreakdownsResponse" /> class.
        /// </summary>
        /// <param name="breakdowns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendBreakdownsResponse(
            global::System.Collections.Generic.IList<global::Opik.SpendBreakdownResponse>? breakdowns)
        {
            this.Breakdowns = breakdowns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendBreakdownsResponse" /> class.
        /// </summary>
        public SpendBreakdownsResponse()
        {
        }

    }
}