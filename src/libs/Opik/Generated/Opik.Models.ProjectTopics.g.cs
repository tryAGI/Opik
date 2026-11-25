
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectTopics
    {
        /// <summary>
        /// disabled: the workspace is not opted in to topics. collecting: the project has no topics yet. ready: topics with counts. too_large: the project has too many traces in the window to count; a retry answers the same
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ProjectTopicsStatusJsonConverter))]
        public global::Opik.ProjectTopicsStatus? Status { get; set; }

        /// <summary>
        /// The UTC date of the request, the window's last day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("today")]
        public global::System.DateTime? Today { get; set; }

        /// <summary>
        /// The window's first UTC day, inclusive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_from")]
        public global::System.DateTime? WindowFrom { get; set; }

        /// <summary>
        /// When the project's last saved run (a discovery run or a nightly update) finished; omitted before the first one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_at")]
        public global::System.DateTime? LastRunAt { get; set; }

        /// <summary>
        /// collecting only: the project's newest run when it is running or failed; omitted when it saved or there is none. The runbook's 'Reading topics' section tells the collecting cases apart
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt")]
        public global::Opik.Attempt? Attempt { get; set; }

        /// <summary>
        /// collecting only: traces with a vector in the window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectors_in_window")]
        public long? VectorsInWindow { get; set; }

        /// <summary>
        /// collecting only: traces with a vector the discovery run needs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_vectors")]
        public long? MinVectors { get; set; }

        /// <summary>
        /// ready only: traces with a topic in the window, Other included
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_traces")]
        public long? TotalTraces { get; set; }

        /// <summary>
        /// ready only: the first day in the window with a labelled trace; earlier days are 0 because nothing was labelled. Omitted when the window has none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labelled_from")]
        public global::System.DateTime? LabelledFrom { get; set; }

        /// <summary>
        /// The live topics in rank order; empty unless ready
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Opik.TopicStats>? Topics { get; set; }

        /// <summary>
        /// ready only: the traces per day with no topic, or with a topic that is no longer live. Add it to the topics' series for the project's total per day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public global::Opik.OtherStats? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTopics" /> class.
        /// </summary>
        /// <param name="status">
        /// disabled: the workspace is not opted in to topics. collecting: the project has no topics yet. ready: topics with counts. too_large: the project has too many traces in the window to count; a retry answers the same
        /// </param>
        /// <param name="today">
        /// The UTC date of the request, the window's last day
        /// </param>
        /// <param name="windowFrom">
        /// The window's first UTC day, inclusive
        /// </param>
        /// <param name="lastRunAt">
        /// When the project's last saved run (a discovery run or a nightly update) finished; omitted before the first one
        /// </param>
        /// <param name="attempt">
        /// collecting only: the project's newest run when it is running or failed; omitted when it saved or there is none. The runbook's 'Reading topics' section tells the collecting cases apart
        /// </param>
        /// <param name="vectorsInWindow">
        /// collecting only: traces with a vector in the window
        /// </param>
        /// <param name="minVectors">
        /// collecting only: traces with a vector the discovery run needs
        /// </param>
        /// <param name="totalTraces">
        /// ready only: traces with a topic in the window, Other included
        /// </param>
        /// <param name="labelledFrom">
        /// ready only: the first day in the window with a labelled trace; earlier days are 0 because nothing was labelled. Omitted when the window has none
        /// </param>
        /// <param name="topics">
        /// The live topics in rank order; empty unless ready
        /// </param>
        /// <param name="other">
        /// ready only: the traces per day with no topic, or with a topic that is no longer live. Add it to the topics' series for the project's total per day
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectTopics(
            global::Opik.ProjectTopicsStatus? status,
            global::System.DateTime? today,
            global::System.DateTime? windowFrom,
            global::System.DateTime? lastRunAt,
            global::Opik.Attempt? attempt,
            long? vectorsInWindow,
            long? minVectors,
            long? totalTraces,
            global::System.DateTime? labelledFrom,
            global::System.Collections.Generic.IList<global::Opik.TopicStats>? topics,
            global::Opik.OtherStats? other)
        {
            this.Status = status;
            this.Today = today;
            this.WindowFrom = windowFrom;
            this.LastRunAt = lastRunAt;
            this.Attempt = attempt;
            this.VectorsInWindow = vectorsInWindow;
            this.MinVectors = minVectors;
            this.TotalTraces = totalTraces;
            this.LabelledFrom = labelledFrom;
            this.Topics = topics;
            this.Other = other;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectTopics" /> class.
        /// </summary>
        public ProjectTopics()
        {
        }

    }
}