
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendCompositionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Opik.Side? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness")]
        public global::System.Collections.Generic.IList<global::Opik.HarnessEntry>? Harness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Opik.Side? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCompositionResponse" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="harness"></param>
        /// <param name="output"></param>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendCompositionResponse(
            global::Opik.Side? input,
            global::System.Collections.Generic.IList<global::Opik.HarnessEntry>? harness,
            global::Opik.Side? output,
            global::System.Collections.Generic.IList<string>? models)
        {
            this.Input = input;
            this.Harness = harness;
            this.Output = output;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendCompositionResponse" /> class.
        /// </summary>
        public SpendCompositionResponse()
        {
        }

    }
}