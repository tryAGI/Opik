
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DashboardWidgetQueryRequest
    {
        /// <summary>
        /// Start of the date range, bound to {{window_start}} in the dashboard saved query. Omit for all time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_start")]
        public global::System.DateTime? IntervalStart { get; set; }

        /// <summary>
        /// End of the date range, bound to {{window_end}} in the dashboard saved query. Omit for now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_end")]
        public global::System.DateTime? IntervalEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardWidgetQueryRequest" /> class.
        /// </summary>
        /// <param name="intervalStart">
        /// Start of the date range, bound to {{window_start}} in the dashboard saved query. Omit for all time.
        /// </param>
        /// <param name="intervalEnd">
        /// End of the date range, bound to {{window_end}} in the dashboard saved query. Omit for now.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DashboardWidgetQueryRequest(
            global::System.DateTime? intervalStart,
            global::System.DateTime? intervalEnd)
        {
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardWidgetQueryRequest" /> class.
        /// </summary>
        public DashboardWidgetQueryRequest()
        {
        }

    }
}