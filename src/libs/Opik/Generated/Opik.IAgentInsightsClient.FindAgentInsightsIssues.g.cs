#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsClient
    {
        /// <summary>
        /// Find agent insights issues<br/>
        /// Returns a paginated list of issues that have at least one detail row within the requested time window, with metrics aggregated over the window
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="status"></param>
        /// <param name="sorting"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentInsightsIssuePage> FindAgentInsightsIssuesAsync(
            global::System.Guid projectId,
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            global::Opik.FindAgentInsightsIssuesStatus? status = default,
            string? sorting = default,
            int? page = default,
            int? size = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find agent insights issues<br/>
        /// Returns a paginated list of issues that have at least one detail row within the requested time window, with metrics aggregated over the window
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="status"></param>
        /// <param name="sorting"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AgentInsightsIssuePage>> FindAgentInsightsIssuesAsResponseAsync(
            global::System.Guid projectId,
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            global::Opik.FindAgentInsightsIssuesStatus? status = default,
            string? sorting = default,
            int? page = default,
            int? size = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}