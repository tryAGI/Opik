#nullable enable

namespace Opik
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Add items to annotation queue<br/>
        /// Add traces or threads to annotation queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task AddItemsToAnnotationQueueAsync(
            global::System.Guid id,

            global::Opik.AnnotationQueueItemIds request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add items to annotation queue<br/>
        /// Add traces or threads to annotation queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AddItemsToAnnotationQueueAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}