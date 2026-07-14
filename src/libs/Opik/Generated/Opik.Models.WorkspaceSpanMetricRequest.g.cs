
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceSpanMetricRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.WorkspaceSpanMetricRequestMetricTypeJsonConverter))]
        public global::Opik.WorkspaceSpanMetricRequestMetricType? MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.WorkspaceSpanMetricRequestIntervalJsonConverter))]
        public global::Opik.WorkspaceSpanMetricRequestInterval? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::Opik.BreakdownConfig? Breakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Opik.SpanFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_end")]
        public global::System.DateTime? IntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_before_end")]
        public bool? StartBeforeEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSpanMetricRequest" /> class.
        /// </summary>
        /// <param name="intervalStart"></param>
        /// <param name="projectIds"></param>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="breakdown"></param>
        /// <param name="filters"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="startBeforeEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceSpanMetricRequest(
            global::System.DateTime intervalStart,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            global::Opik.WorkspaceSpanMetricRequestMetricType? metricType,
            global::Opik.WorkspaceSpanMetricRequestInterval? interval,
            global::Opik.BreakdownConfig? breakdown,
            global::System.Collections.Generic.IList<global::Opik.SpanFilter>? filters,
            global::System.DateTime? intervalEnd,
            bool? startBeforeEnd)
        {
            this.ProjectIds = projectIds;
            this.MetricType = metricType;
            this.Interval = interval;
            this.Breakdown = breakdown;
            this.Filters = filters;
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
            this.StartBeforeEnd = startBeforeEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSpanMetricRequest" /> class.
        /// </summary>
        public WorkspaceSpanMetricRequest()
        {
        }

    }
}