
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectMetricResponsePublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ProjectMetricResponsePublicMetricTypeJsonConverter))]
        public global::Opik.ProjectMetricResponsePublicMetricType? MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ProjectMetricResponsePublicIntervalJsonConverter))]
        public global::Opik.ProjectMetricResponsePublicInterval? Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Opik.ResultsNumberPublic>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricResponsePublic" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectMetricResponsePublic(
            global::System.Guid? projectId,
            global::Opik.ProjectMetricResponsePublicMetricType? metricType,
            global::Opik.ProjectMetricResponsePublicInterval? interval,
            global::System.Collections.Generic.IList<global::Opik.ResultsNumberPublic>? results)
        {
            this.ProjectId = projectId;
            this.MetricType = metricType;
            this.Interval = interval;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetricResponsePublic" /> class.
        /// </summary>
        public ProjectMetricResponsePublic()
        {
        }
    }
}