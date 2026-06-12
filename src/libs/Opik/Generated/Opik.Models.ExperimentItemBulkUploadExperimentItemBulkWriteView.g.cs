
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentItemBulkUploadExperimentItemBulkWriteView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        public global::System.Guid? ExperimentId { get; set; }

        /// <summary>
        /// Project for traces auto-created from items that provide evaluate_task_result (i.e. without an explicit trace). If null, the default project is used; relying on this fallback is deprecated, please provide project_name explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkUploadExperimentItemBulkWriteView" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="datasetName"></param>
        /// <param name="items"></param>
        /// <param name="experimentId">
        /// Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName
        /// </param>
        /// <param name="projectName">
        /// Project for traces auto-created from items that provide evaluate_task_result (i.e. without an explicit trace). If null, the default project is used; relying on this fallback is deprecated, please provide project_name explicitly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentItemBulkUploadExperimentItemBulkWriteView(
            string experimentName,
            string datasetName,
            global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView> items,
            global::System.Guid? experimentId,
            string? projectName)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ExperimentId = experimentId;
            this.ProjectName = projectName;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentItemBulkUploadExperimentItemBulkWriteView" /> class.
        /// </summary>
        public ExperimentItemBulkUploadExperimentItemBulkWriteView()
        {
        }

    }
}