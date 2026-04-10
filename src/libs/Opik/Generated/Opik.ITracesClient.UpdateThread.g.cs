#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Update thread<br/>
        /// Update thread
        /// </summary>
        /// <param name="threadModelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateThreadAsync(
            global::System.Guid threadModelId,

            global::Opik.TraceThreadUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update thread<br/>
        /// Update thread
        /// </summary>
        /// <param name="threadModelId"></param>
        /// <param name="tags"></param>
        /// <param name="tagsToAdd"></param>
        /// <param name="tagsToRemove"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateThreadAsync(
            global::System.Guid threadModelId,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? tagsToAdd = default,
            global::System.Collections.Generic.IList<string>? tagsToRemove = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}