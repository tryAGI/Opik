
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Opik.JsonNode? Metadata { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Tags to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_to_add")]
        public global::System.Collections.Generic.IList<string>? TagsToAdd { get; set; }

        /// <summary>
        /// Tags to remove
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags_to_remove")]
        public global::System.Collections.Generic.IList<string>? TagsToRemove { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ExperimentUpdateTypeJsonConverter))]
        public global::Opik.ExperimentUpdateType? Type { get; set; }

        /// <summary>
        /// The status of the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ExperimentUpdateStatusJsonConverter))]
        public global::Opik.ExperimentUpdateStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_scores")]
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScore>? ExperimentScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="tags">
        /// Tags
        /// </param>
        /// <param name="tagsToAdd">
        /// Tags to add
        /// </param>
        /// <param name="tagsToRemove">
        /// Tags to remove
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// The status of the experiment
        /// </param>
        /// <param name="experimentScores"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentUpdate(
            string? name,
            global::Opik.JsonNode? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::Opik.ExperimentUpdateType? type,
            global::Opik.ExperimentUpdateStatus? status,
            global::System.Collections.Generic.IList<global::Opik.ExperimentScore>? experimentScores)
        {
            this.Name = name;
            this.Metadata = metadata;
            this.Tags = tags;
            this.TagsToAdd = tagsToAdd;
            this.TagsToRemove = tagsToRemove;
            this.Type = type;
            this.Status = status;
            this.ExperimentScores = experimentScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentUpdate" /> class.
        /// </summary>
        public ExperimentUpdate()
        {
        }
    }
}