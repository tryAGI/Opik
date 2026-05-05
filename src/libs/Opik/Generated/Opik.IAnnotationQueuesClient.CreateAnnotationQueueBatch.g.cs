#nullable enable

namespace Opik
{
    public partial interface IAnnotationQueuesClient
    {
        /// <summary>
        /// Create annotation queue batch<br/>
        /// Create multiple annotation queues for human annotation workflows
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueBatchAsync(

            global::Opik.AnnotationQueueBatchWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create annotation queue batch<br/>
        /// Create multiple annotation queues for human annotation workflows
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CreateAnnotationQueueBatchAsResponseAsync(

            global::Opik.AnnotationQueueBatchWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create annotation queue batch<br/>
        /// Create multiple annotation queues for human annotation workflows
        /// </summary>
        /// <param name="annotationQueues">
        /// List of annotation queues to create
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueBatchAsync(
            global::System.Collections.Generic.IList<global::Opik.AnnotationQueueWrite> annotationQueues,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}