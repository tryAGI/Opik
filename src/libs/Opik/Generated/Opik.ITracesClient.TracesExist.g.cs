#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Check whether a project has traces<br/>
        /// Returns whether the project has at least one trace matching the given scope. Cheap existence probe (LIMIT 1) used to drive empty-state decisions without scanning or aggregating the whole project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="source">
        /// Restrict the probe to a single ingestion source (e.g. 'sdk' for the Logs empty state), matching the rendered list's logs-source scope. Omit to probe any source.
        /// </param>
        /// <param name="threadOnly">
        /// When true, only considers traces that belong to a thread (thread_id is set) — used by the Threads empty state.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ExistenceResponse> TracesExistAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? source = default,
            bool? threadOnly = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether a project has traces<br/>
        /// Returns whether the project has at least one trace matching the given scope. Cheap existence probe (LIMIT 1) used to drive empty-state decisions without scanning or aggregating the whole project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="source">
        /// Restrict the probe to a single ingestion source (e.g. 'sdk' for the Logs empty state), matching the rendered list's logs-source scope. Omit to probe any source.
        /// </param>
        /// <param name="threadOnly">
        /// When true, only considers traces that belong to a thread (thread_id is set) — used by the Threads empty state.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ExistenceResponse>> TracesExistAsResponseAsync(
            global::System.Guid? projectId = default,
            string? projectName = default,
            string? source = default,
            bool? threadOnly = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}