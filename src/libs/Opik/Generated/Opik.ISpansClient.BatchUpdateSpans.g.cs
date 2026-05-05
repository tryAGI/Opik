#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Batch update spans<br/>
        /// Update multiple spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateSpansAsync(

            global::Opik.SpanBatchUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update spans<br/>
        /// Update multiple spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> BatchUpdateSpansAsResponseAsync(

            global::Opik.SpanBatchUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update spans<br/>
        /// Update multiple spans
        /// </summary>
        /// <param name="ids">
        /// List of span IDs to update (max 1000)
        /// </param>
        /// <param name="update"></param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateSpansAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::Opik.SpanUpdate update,
            bool? mergeTags = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}