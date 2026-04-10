#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Get span comment<br/>
        /// Get span comment
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="spanId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Comment> GetSpanCommentAsync(
            global::System.Guid commentId,
            global::System.Guid spanId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}