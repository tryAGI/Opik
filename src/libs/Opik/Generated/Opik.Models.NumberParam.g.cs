
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NumberParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        public bool? Accepted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberParam" /> class.
        /// </summary>
        /// <param name="accepted"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="default"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumberParam(
            bool? accepted,
            double? min,
            double? max,
            double? @default)
        {
            this.Accepted = accepted;
            this.Min = min;
            this.Max = max;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberParam" /> class.
        /// </summary>
        public NumberParam()
        {
        }

    }
}