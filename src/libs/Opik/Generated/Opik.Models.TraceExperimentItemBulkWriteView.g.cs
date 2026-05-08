
#nullable enable

namespace Opik
{
    /// <summary>
    /// Please provide either none, only one of evaluate_task_result or trace, but never both
    /// </summary>
    public sealed partial class TraceExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// If null, the default project is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.JsonListStringExperimentItemBulkWriteViewJsonConverter))]
        public global::Opik.JsonListStringExperimentItemBulkWriteView? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.JsonListStringExperimentItemBulkWriteViewJsonConverter))]
        public global::Opik.JsonListStringExperimentItemBulkWriteView? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.JsonListStringExperimentItemBulkWriteViewJsonConverter))]
        public global::Opik.JsonListStringExperimentItemBulkWriteView? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_info")]
        public global::Opik.ErrorInfoExperimentItemBulkWriteView? ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Time to first token in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft")]
        public double? Ttft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.TraceExperimentItemBulkWriteViewSourceJsonConverter))]
        public global::Opik.TraceExperimentItemBulkWriteViewSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// If null, the default project is used
        /// </param>
        /// <param name="name"></param>
        /// <param name="endTime"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="errorInfo"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="ttft">
        /// Time to first token in milliseconds
        /// </param>
        /// <param name="threadId"></param>
        /// <param name="source"></param>
        /// <param name="environment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceExperimentItemBulkWriteView(
            global::System.DateTime startTime,
            global::System.Guid? id,
            string? projectName,
            string? name,
            global::System.DateTime? endTime,
            global::Opik.JsonListStringExperimentItemBulkWriteView? input,
            global::Opik.JsonListStringExperimentItemBulkWriteView? output,
            global::Opik.JsonListStringExperimentItemBulkWriteView? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::Opik.ErrorInfoExperimentItemBulkWriteView? errorInfo,
            global::System.DateTime? lastUpdatedAt,
            double? ttft,
            string? threadId,
            global::Opik.TraceExperimentItemBulkWriteViewSource? source,
            string? environment)
        {
            this.Id = id;
            this.ProjectName = projectName;
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Input = input;
            this.Output = output;
            this.Metadata = metadata;
            this.Tags = tags;
            this.ErrorInfo = errorInfo;
            this.LastUpdatedAt = lastUpdatedAt;
            this.Ttft = ttft;
            this.ThreadId = threadId;
            this.Source = source;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceExperimentItemBulkWriteView" /> class.
        /// </summary>
        public TraceExperimentItemBulkWriteView()
        {
        }
    }
}