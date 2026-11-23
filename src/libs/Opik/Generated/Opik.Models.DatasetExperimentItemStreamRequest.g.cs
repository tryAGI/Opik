
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetExperimentItemStreamRequest
    {
        /// <summary>
        /// Dataset ID. Set this or dataset_name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Dataset name. Set this or dataset_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// Project of the dataset, used with dataset_name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Dataset version hashes or tags, such as 'latest'. Only experiments run against one of these versions are included; omit for every version. Returns 404 if any version does not exist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_versions")]
        public global::System.Collections.Generic.IList<string>? DatasetVersions { get; set; }

        /// <summary>
        /// JSON array of dataset item filters, evaluated against the newest version of each item that the experiments reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public string? Filters { get; set; }

        /// <summary>
        /// Maximum number of experiment items to return<br/>
        /// Default Value: 2000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Optional hint: experiment_id of the last experiment item received. Used only if that item was deleted, to resume from the start of its experiment instead of from the start of the stream. Requires last_retrieved_id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_retrieved_experiment_id")]
        public global::System.Guid? LastRetrievedExperimentId { get; set; }

        /// <summary>
        /// id of the last experiment item received
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_retrieved_id")]
        public global::System.Guid? LastRetrievedId { get; set; }

        /// <summary>
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExperimentItemStreamRequest" /> class.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset ID. Set this or dataset_name
        /// </param>
        /// <param name="datasetName">
        /// Dataset name. Set this or dataset_id
        /// </param>
        /// <param name="projectName">
        /// Project of the dataset, used with dataset_name
        /// </param>
        /// <param name="datasetVersions">
        /// Dataset version hashes or tags, such as 'latest'. Only experiments run against one of these versions are included; omit for every version. Returns 404 if any version does not exist
        /// </param>
        /// <param name="filters">
        /// JSON array of dataset item filters, evaluated against the newest version of each item that the experiments reference
        /// </param>
        /// <param name="limit">
        /// Maximum number of experiment items to return<br/>
        /// Default Value: 2000
        /// </param>
        /// <param name="lastRetrievedExperimentId">
        /// Optional hint: experiment_id of the last experiment item received. Used only if that item was deleted, to resume from the start of its experiment instead of from the start of the stream. Requires last_retrieved_id
        /// </param>
        /// <param name="lastRetrievedId">
        /// id of the last experiment item received
        /// </param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetExperimentItemStreamRequest(
            global::System.Guid? datasetId,
            string? datasetName,
            string? projectName,
            global::System.Collections.Generic.IList<string>? datasetVersions,
            string? filters,
            int? limit,
            global::System.Guid? lastRetrievedExperimentId,
            global::System.Guid? lastRetrievedId,
            bool? truncate)
        {
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
            this.ProjectName = projectName;
            this.DatasetVersions = datasetVersions;
            this.Filters = filters;
            this.Limit = limit;
            this.LastRetrievedExperimentId = lastRetrievedExperimentId;
            this.LastRetrievedId = lastRetrievedId;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetExperimentItemStreamRequest" /> class.
        /// </summary>
        public DatasetExperimentItemStreamRequest()
        {
        }

    }
}