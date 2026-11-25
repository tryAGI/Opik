
#nullable enable

namespace Opik
{
    /// <summary>
    /// ready only: the traces per day with no topic, or with a topic that is no longer live. Add it to the topics' series for the project's total per day
    /// </summary>
    public sealed partial class OtherStats
    {
        /// <summary>
        /// One entry per day of the window, oldest first, today last
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.IList<global::Opik.DayCount>? Series { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherStats" /> class.
        /// </summary>
        /// <param name="series">
        /// One entry per day of the window, oldest first, today last
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtherStats(
            global::System.Collections.Generic.IList<global::Opik.DayCount>? series)
        {
            this.Series = series;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherStats" /> class.
        /// </summary>
        public OtherStats()
        {
        }

    }
}