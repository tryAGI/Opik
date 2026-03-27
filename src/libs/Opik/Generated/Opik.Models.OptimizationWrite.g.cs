
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationWrite
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
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objective_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectiveName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.OptimizationWriteStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.OptimizationWriteStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.JsonListStringWriteJsonConverter))]
        public global::Opik.JsonListStringWrite? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_config")]
        public global::Opik.OptimizationStudioConfigWrite? StudioConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationWrite" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="datasetName"></param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="objectiveName"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="studioConfig"></param>
        /// <param name="lastUpdatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizationWrite(
            string datasetName,
            string objectiveName,
            global::Opik.OptimizationWriteStatus status,
            global::System.Guid? id,
            string? name,
            string? projectName,
            global::System.Guid? projectId,
            global::Opik.JsonListStringWrite? metadata,
            global::Opik.OptimizationStudioConfigWrite? studioConfig,
            global::System.DateTime? lastUpdatedAt)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ObjectiveName = objectiveName ?? throw new global::System.ArgumentNullException(nameof(objectiveName));
            this.Status = status;
            this.Id = id;
            this.Name = name;
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.Metadata = metadata;
            this.StudioConfig = studioConfig;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationWrite" /> class.
        /// </summary>
        public OptimizationWrite()
        {
        }
    }
}