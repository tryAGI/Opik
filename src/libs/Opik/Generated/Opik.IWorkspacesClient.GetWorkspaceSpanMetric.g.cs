#nullable enable

namespace Opik
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get workspace span metric<br/>
        /// Gets a span metric time series aggregated across the workspace. When project_ids is empty, all projects in the workspace are included; otherwise only the given projects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.WorkspaceMetricResponse> GetWorkspaceSpanMetricAsync(

            global::Opik.WorkspaceSpanMetricRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workspace span metric<br/>
        /// Gets a span metric time series aggregated across the workspace. When project_ids is empty, all projects in the workspace are included; otherwise only the given projects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.WorkspaceMetricResponse>> GetWorkspaceSpanMetricAsResponseAsync(

            global::Opik.WorkspaceSpanMetricRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workspace span metric<br/>
        /// Gets a span metric time series aggregated across the workspace. When project_ids is empty, all projects in the workspace are included; otherwise only the given projects.
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="breakdown"></param>
        /// <param name="filters"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="startBeforeEnd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.WorkspaceMetricResponse> GetWorkspaceSpanMetricAsync(
            global::System.DateTime intervalStart,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            global::Opik.WorkspaceSpanMetricRequestMetricType? metricType = default,
            global::Opik.WorkspaceSpanMetricRequestInterval? interval = default,
            global::Opik.BreakdownConfig? breakdown = default,
            global::System.Collections.Generic.IList<global::Opik.SpanFilter>? filters = default,
            global::System.DateTime? intervalEnd = default,
            bool? startBeforeEnd = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}