#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Batch update traces<br/>
        /// Update multiple traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateTracesAsync(

            global::Opik.TraceBatchUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update traces<br/>
        /// Update multiple traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> BatchUpdateTracesAsResponseAsync(

            global::Opik.TraceBatchUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch update traces<br/>
        /// Update multiple traces
        /// </summary>
        /// <param name="ids">
        /// List of trace IDs to update (max 1000)
        /// </param>
        /// <param name="update"></param>
        /// <param name="mergeTags">
        /// If true, merge tags with existing tags instead of replacing them. Default: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task BatchUpdateTracesAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::Opik.TraceUpdate update,
            bool? mergeTags = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}