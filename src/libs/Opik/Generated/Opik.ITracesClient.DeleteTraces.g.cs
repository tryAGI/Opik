#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete traces<br/>
        /// Delete traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTracesAsync(

            global::Opik.BatchDeleteByProject request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete traces<br/>
        /// Delete traces
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> DeleteTracesAsResponseAsync(

            global::Opik.BatchDeleteByProject request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete traces<br/>
        /// Delete traces
        /// </summary>
        /// <param name="ids">
        /// Ids of the traces to delete
        /// </param>
        /// <param name="projectId">
        /// Optional. Scopes the deletion to this project. When omitted, each trace's owning project is resolved automatically and the trace is deleted under its full key, so a trace can be deleted without knowing its project.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteTracesAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Guid? projectId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}