
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectMetricRequestPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ProjectMetricRequestPublicMetricTypeJsonConverter))]
        public global::Opik.ProjectMetricRequestPublicMetricType? MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ProjectMetricRequestPublicIntervalJsonConverter))]
        public global::Opik.ProjectMetricRequestPublicInterval? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_start")]
        public global::System.DateTime? IntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_end")]
        public global::System.DateTime? IntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_filters")]
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? SpanFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filters")]
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? TraceFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_filters")]
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>? ThreadFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::Opik.BreakdownConfigPublic? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricRequestPublic" /> class.
        /// </summary>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="spanFilters"></param>
        /// <param name="traceFilters"></param>
        /// <param name="threadFilters"></param>
        /// <param name="breakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectMetricRequestPublic(
            global::Opik.ProjectMetricRequestPublicMetricType? metricType,
            global::Opik.ProjectMetricRequestPublicInterval? interval,
            global::System.DateTime? intervalStart,
            global::System.DateTime? intervalEnd,
            global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? spanFilters,
            global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? traceFilters,
            global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>? threadFilters,
            global::Opik.BreakdownConfigPublic? breakdown)
        {
            this.MetricType = metricType;
            this.Interval = interval;
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
            this.SpanFilters = spanFilters;
            this.TraceFilters = traceFilters;
            this.ThreadFilters = threadFilters;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricRequestPublic" /> class.
        /// </summary>
        public ProjectMetricRequestPublic()
        {
        }
    }
}