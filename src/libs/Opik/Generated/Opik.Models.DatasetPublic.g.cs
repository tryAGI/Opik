
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.DatasetPublicTypeJsonConverter))]
        public global::Opik.DatasetPublicType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.DatasetPublicVisibilityJsonConverter))]
        public global::Opik.DatasetPublicVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_count")]
        public long? ExperimentCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_items_count")]
        public long? DatasetItemsCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimization_count")]
        public long? OptimizationCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_experiment_at")]
        public global::System.DateTime? MostRecentExperimentAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_created_experiment_at")]
        public global::System.DateTime? LastCreatedExperimentAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_optimization_at")]
        public global::System.DateTime? MostRecentOptimizationAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_created_optimization_at")]
        public global::System.DateTime? LastCreatedOptimizationAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.DatasetPublicStatusJsonConverter))]
        public global::Opik.DatasetPublicStatus? Status { get; set; }

        /// <summary>
        /// Summary of the latest dataset version<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        public global::Opik.DatasetVersionSummaryPublic? LatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPublic" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="type"></param>
        /// <param name="visibility"></param>
        /// <param name="tags"></param>
        /// <param name="description"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="experimentCount">
        /// Included only in responses
        /// </param>
        /// <param name="datasetItemsCount">
        /// Included only in responses
        /// </param>
        /// <param name="optimizationCount">
        /// Included only in responses
        /// </param>
        /// <param name="mostRecentExperimentAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastCreatedExperimentAt">
        /// Included only in responses
        /// </param>
        /// <param name="mostRecentOptimizationAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastCreatedOptimizationAt">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="latestVersion">
        /// Summary of the latest dataset version<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetPublic(
            string name,
            global::System.Guid? id,
            global::System.Guid? projectId,
            global::Opik.DatasetPublicType? type,
            global::Opik.DatasetPublicVisibility? visibility,
            global::System.Collections.Generic.IList<string>? tags,
            string? description,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            long? experimentCount,
            long? datasetItemsCount,
            long? optimizationCount,
            global::System.DateTime? mostRecentExperimentAt,
            global::System.DateTime? lastCreatedExperimentAt,
            global::System.DateTime? mostRecentOptimizationAt,
            global::System.DateTime? lastCreatedOptimizationAt,
            global::Opik.DatasetPublicStatus? status,
            global::Opik.DatasetVersionSummaryPublic? latestVersion)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id;
            this.ProjectId = projectId;
            this.Type = type;
            this.Visibility = visibility;
            this.Tags = tags;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.ExperimentCount = experimentCount;
            this.DatasetItemsCount = datasetItemsCount;
            this.OptimizationCount = optimizationCount;
            this.MostRecentExperimentAt = mostRecentExperimentAt;
            this.LastCreatedExperimentAt = lastCreatedExperimentAt;
            this.MostRecentOptimizationAt = mostRecentOptimizationAt;
            this.LastCreatedOptimizationAt = lastCreatedOptimizationAt;
            this.Status = status;
            this.LatestVersion = latestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPublic" /> class.
        /// </summary>
        public DatasetPublic()
        {
        }
    }
}