
#nullable enable

namespace Opik
{
    /// <summary>
    /// One entry per day of the window, oldest first, today last
    /// </summary>
    public sealed partial class DayCount
    {
        /// <summary>
        /// A UTC date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        public global::System.DateTime? Day { get; set; }

        /// <summary>
        /// Traces created on the day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DayCount" /> class.
        /// </summary>
        /// <param name="day">
        /// A UTC date
        /// </param>
        /// <param name="count">
        /// Traces created on the day
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DayCount(
            global::System.DateTime? day,
            long? count)
        {
            this.Day = day;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DayCount" /> class.
        /// </summary>
        public DayCount()
        {
        }

    }
}