
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendMetricRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime IntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_before_end")]
        public bool? StartBeforeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_provided")]
        public bool? ProjectProvided { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendMetricRequest" /> class.
        /// </summary>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="userId"></param>
        /// <param name="startBeforeEnd"></param>
        /// <param name="projectProvided"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendMetricRequest(
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            global::System.Guid? projectId,
            string? projectName,
            string? userId,
            bool? startBeforeEnd,
            bool? projectProvided)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.IntervalStart = intervalStart;
            this.IntervalEnd = intervalEnd;
            this.UserId = userId;
            this.StartBeforeEnd = startBeforeEnd;
            this.ProjectProvided = projectProvided;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendMetricRequest" /> class.
        /// </summary>
        public SpendMetricRequest()
        {
        }

    }
}