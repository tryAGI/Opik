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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueBatchAsync(

            global::Opik.AnnotationQueueBatchWrite request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create annotation queue batch<br/>
        /// Create multiple annotation queues for human annotation workflows
        /// </summary>
        /// <param name="annotationQueues">
        /// List of annotation queues to create
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAnnotationQueueBatchAsync(
            global::System.Collections.Generic.IList<global::Opik.AnnotationQueueWrite> annotationQueues,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}