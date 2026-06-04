#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset items from JSON file<br/>
        /// Create dataset items from an uploaded JSON or JSONL file. JSON files must contain a top-level array of objects.<br/>
        /// JSONL files contain one JSON object per non-blank line; multi-line JSON objects are not supported.<br/>
        /// Reserved keys (id, source, description, tags, evaluators, execution_policy) are extracted into the<br/>
        /// corresponding DatasetItem fields; all remaining keys form the item's data map and preserve their JSON types.<br/>
        /// To link dataset items to specific traces or spans use the dedicated /items/from-traces or /items/from-spans endpoints.<br/>
        /// Processing happens asynchronously in batches. With dataset versioning enabled, a supplied id acts as an upsert key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromJsonAsync(

            global::Opik.CreateDatasetItemsFromJsonRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset items from JSON file<br/>
        /// Create dataset items from an uploaded JSON or JSONL file. JSON files must contain a top-level array of objects.<br/>
        /// JSONL files contain one JSON object per non-blank line; multi-line JSON objects are not supported.<br/>
        /// Reserved keys (id, source, description, tags, evaluators, execution_policy) are extracted into the<br/>
        /// corresponding DatasetItem fields; all remaining keys form the item's data map and preserve their JSON types.<br/>
        /// To link dataset items to specific traces or spans use the dedicated /items/from-traces or /items/from-spans endpoints.<br/>
        /// Processing happens asynchronously in batches. With dataset versioning enabled, a supplied id acts as an upsert key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CreateDatasetItemsFromJsonAsResponseAsync(

            global::Opik.CreateDatasetItemsFromJsonRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset items from JSON file<br/>
        /// Create dataset items from an uploaded JSON or JSONL file. JSON files must contain a top-level array of objects.<br/>
        /// JSONL files contain one JSON object per non-blank line; multi-line JSON objects are not supported.<br/>
        /// Reserved keys (id, source, description, tags, evaluators, execution_policy) are extracted into the<br/>
        /// corresponding DatasetItem fields; all remaining keys form the item's data map and preserve their JSON types.<br/>
        /// To link dataset items to specific traces or spans use the dedicated /items/from-traces or /items/from-spans endpoints.<br/>
        /// Processing happens asynchronously in batches. With dataset versioning enabled, a supplied id acts as an upsert key.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="datasetId"></param>
        /// <param name="format"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromJsonAsync(
            object file,
            global::System.Guid datasetId,
            global::Opik.CreateDatasetItemsFromJsonRequestFormat format,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}