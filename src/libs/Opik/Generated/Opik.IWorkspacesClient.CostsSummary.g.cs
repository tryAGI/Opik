#nullable enable

namespace Opik
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get costs summary<br/>
        /// Get costs summary
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Result> CostsSummaryAsync(

            global::Opik.WorkspaceMetricsSummaryRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get costs summary<br/>
        /// Get costs summary
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="startBeforeEnd"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Result> CostsSummaryAsync(
            global::System.DateTime intervalStart,
            global::System.DateTime intervalEnd,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            bool? startBeforeEnd = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}