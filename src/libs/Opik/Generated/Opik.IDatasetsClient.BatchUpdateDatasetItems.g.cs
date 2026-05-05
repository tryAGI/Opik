#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Batch update dataset items<br/>
        /// Update multiple dataset items
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateDatasetItemsAsync(

            global::Opik.DatasetItemBatchUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update dataset items<br/>
        /// Update multiple dataset items
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> BatchUpdateDatasetItemsAsResponseAsync(

            global::Opik.DatasetItemBatchUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update dataset items<br/>
        /// Update multiple dataset items
        /// </summary>
        /// <param name="ids">
        /// List of dataset item IDs to update (max 1000). Mutually exclusive with 'filters'.
        /// </param>
        /// <param name="filters"></param>
        /// <param name="datasetId">
        /// Dataset ID. Required when using 'filters', optional when using 'ids'.
        /// </param>
        /// <param name="update">
        /// Dataset item update request
        /// </param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false. When using 'filters', this is automatically set to true.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateDatasetItemsAsync(
            global::Opik.DatasetItemUpdate update,
            global::System.Collections.Generic.IList<global::System.Guid>? ids = default,
            global::System.Collections.Generic.IList<global::Opik.DatasetItemFilter>? filters = default,
            global::System.Guid? datasetId = default,
            bool? mergeTags = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}