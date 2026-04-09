
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentExecutionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version_id")]
        public global::System.Guid? DatasetVersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.PromptVariant> Prompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_hash")]
        public string? VersionHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_versions")]
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>? PromptVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentExecutionRequest" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="prompts"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetVersionId"></param>
        /// <param name="projectName"></param>
        /// <param name="versionHash"></param>
        /// <param name="promptVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentExecutionRequest(
            string datasetName,
            global::System.Collections.Generic.IList<global::Opik.PromptVariant> prompts,
            global::System.Guid datasetId,
            global::System.Guid? datasetVersionId,
            string? projectName,
            string? versionHash,
            global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>? promptVersions)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.DatasetVersionId = datasetVersionId;
            this.Prompts = prompts ?? throw new global::System.ArgumentNullException(nameof(prompts));
            this.ProjectName = projectName;
            this.DatasetId = datasetId;
            this.VersionHash = versionHash;
            this.PromptVersions = promptVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentExecutionRequest" /> class.
        /// </summary>
        public ExperimentExecutionRequest()
        {
        }
    }
}