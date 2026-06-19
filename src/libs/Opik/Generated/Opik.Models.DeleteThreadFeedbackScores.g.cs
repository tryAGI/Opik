
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteThreadFeedbackScores
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ThreadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_queue_id")]
        public global::System.Guid? SourceQueueId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteThreadFeedbackScores" /> class.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="threadId"></param>
        /// <param name="names"></param>
        /// <param name="author"></param>
        /// <param name="sourceQueueId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteThreadFeedbackScores(
            string projectName,
            string threadId,
            global::System.Collections.Generic.IList<string> names,
            string? author,
            global::System.Guid? sourceQueueId)
        {
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.ThreadId = threadId ?? throw new global::System.ArgumentNullException(nameof(threadId));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Author = author;
            this.SourceQueueId = sourceQueueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteThreadFeedbackScores" /> class.
        /// </summary>
        public DeleteThreadFeedbackScores()
        {
        }

    }
}