#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create/update dataset items<br/>
        /// Create/update dataset items based on dataset item id.<br/>
        /// Each item's 'id' field is the stable identifier and upsert key.<br/>
        /// Provide it to update an existing item, or omit it to create a new one.<br/>
        /// Set 'copy_from_dataset_id' and 'copy_from_version_id' together to read carry-forward rows<br/>
        /// from the supplied (dataset, version) pair instead of the destination's prior version. When<br/>
        /// the fields are null, carry-forward rows are read from the destination's prior version.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateOrUpdateDatasetItemsAsync(

            global::Opik.DatasetItemBatchWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create/update dataset items<br/>
        /// Create/update dataset items based on dataset item id.<br/>
        /// Each item's 'id' field is the stable identifier and upsert key.<br/>
        /// Provide it to update an existing item, or omit it to create a new one.<br/>
        /// Set 'copy_from_dataset_id' and 'copy_from_version_id' together to read carry-forward rows<br/>
        /// from the supplied (dataset, version) pair instead of the destination's prior version. When<br/>
        /// the fields are null, carry-forward rows are read from the destination's prior version.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CreateOrUpdateDatasetItemsAsResponseAsync(

            global::Opik.DatasetItemBatchWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create/update dataset items<br/>
        /// Create/update dataset items based on dataset item id.<br/>
        /// Each item's 'id' field is the stable identifier and upsert key.<br/>
        /// Provide it to update an existing item, or omit it to create a new one.<br/>
        /// Set 'copy_from_dataset_id' and 'copy_from_version_id' together to read carry-forward rows<br/>
        /// from the supplied (dataset, version) pair instead of the destination's prior version. When<br/>
        /// the fields are null, carry-forward rows are read from the destination's prior version.
        /// </summary>
        /// <param name="datasetName">
        /// If null, dataset_id must be provided
        /// </param>
        /// <param name="datasetId">
        /// If null, dataset_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Optional. Associates the batch with a project by name. Ignored if project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Optional. Associates the batch with a project by ID. Takes precedence over project_name.
        /// </param>
        /// <param name="items"></param>
        /// <param name="batchGroupId">
        /// Optional batch group ID to group multiple batches into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </param>
        /// <param name="copyFromDatasetId">
        /// Optional. Dataset to read carry-forward rows from when materializing the new version. Required together with copy_from_version_id. When null, carry-forward rows are read from the destination dataset's prior version.
        /// </param>
        /// <param name="copyFromVersionId">
        /// Optional. Version within copy_from_dataset_id to read carry-forward rows from. Required together with copy_from_dataset_id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateOrUpdateDatasetItemsAsync(
            global::System.Collections.Generic.IList<global::Opik.DatasetItemWrite> items,
            string? datasetName = default,
            global::System.Guid? datasetId = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::System.Guid? batchGroupId = default,
            global::System.Guid? copyFromDatasetId = default,
            global::System.Guid? copyFromVersionId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}