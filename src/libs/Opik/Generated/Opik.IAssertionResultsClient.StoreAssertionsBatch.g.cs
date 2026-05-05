#nullable enable

namespace Opik
{
    public partial interface IAssertionResultsClient
    {
        /// <summary>
        /// Batch ingestion of assertion results<br/>
        /// Batch ingestion of assertion results for traces or spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task StoreAssertionsBatchAsync(

            global::Opik.AssertionResultBatch request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch ingestion of assertion results<br/>
        /// Batch ingestion of assertion results for traces or spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> StoreAssertionsBatchAsResponseAsync(

            global::Opik.AssertionResultBatch request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch ingestion of assertion results<br/>
        /// Batch ingestion of assertion results for traces or spans
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="assertionResults"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task StoreAssertionsBatchAsync(
            global::Opik.AssertionResultBatchEntityType entityType,
            global::System.Collections.Generic.IList<global::Opik.AssertionResultBatchItem> assertionResults,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}