#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Update span comment by id<br/>
        /// Update span comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateSpanCommentAsync(
            global::System.Guid commentId,

            global::Opik.Comment request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update span comment by id<br/>
        /// Update span comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> UpdateSpanCommentAsResponseAsync(
            global::System.Guid commentId,

            global::Opik.Comment request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update span comment by id<br/>
        /// Update span comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="text"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateSpanCommentAsync(
            global::System.Guid commentId,
            string text,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}