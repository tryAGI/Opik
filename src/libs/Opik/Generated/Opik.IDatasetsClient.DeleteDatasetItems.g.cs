#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Delete dataset items<br/>
        /// Delete dataset items using one of two modes:<br/>
        /// 1. **Delete by IDs**: Provide 'item_ids' to delete specific items by their IDs<br/>
        /// 2. **Delete by filters**: Provide 'dataset_id' with optional 'filters' to delete items matching criteria<br/>
        /// When using filters, an empty 'filters' array will delete all items in the specified dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetItemsAsync(

            global::Opik.DatasetItemsDelete request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete dataset items<br/>
        /// Delete dataset items using one of two modes:<br/>
        /// 1. **Delete by IDs**: Provide 'item_ids' to delete specific items by their IDs<br/>
        /// 2. **Delete by filters**: Provide 'dataset_id' with optional 'filters' to delete items matching criteria<br/>
        /// When using filters, an empty 'filters' array will delete all items in the specified dataset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> DeleteDatasetItemsAsResponseAsync(

            global::Opik.DatasetItemsDelete request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete dataset items<br/>
        /// Delete dataset items using one of two modes:<br/>
        /// 1. **Delete by IDs**: Provide 'item_ids' to delete specific items by their IDs<br/>
        /// 2. **Delete by filters**: Provide 'dataset_id' with optional 'filters' to delete items matching criteria<br/>
        /// When using filters, an empty 'filters' array will delete all items in the specified dataset.
        /// </summary>
        /// <param name="itemIds">
        /// List of dataset item IDs to delete (max 1000). Use this to delete specific items by their IDs. Mutually exclusive with 'dataset_id' and 'filters'.
        /// </param>
        /// <param name="datasetId">
        /// Dataset ID to scope the deletion. Required when using 'filters'. Mutually exclusive with 'item_ids'.
        /// </param>
        /// <param name="filters">
        /// Filters to select dataset items to delete within the specified dataset. Must be used with 'dataset_id'. Mutually exclusive with 'item_ids'. Empty array means 'delete all items in the dataset'.
        /// </param>
        /// <param name="batchGroupId">
        /// Optional batch group ID to group multiple delete operations into a single dataset version. If null, mutates the latest version instead of creating a new one.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteDatasetItemsAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? itemIds = default,
            global::System.Guid? datasetId = default,
            global::System.Collections.Generic.IList<global::Opik.DatasetItemFilter>? filters = default,
            global::System.Guid? batchGroupId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}