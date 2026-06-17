#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsClient
    {
        /// <summary>
        /// Store agent insights report results<br/>
        /// Upserts the detected issues and their per-day metrics for the given report day in a single transaction. Issue status is never modified by this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ReportAgentInsightsIssuesAsync(

            global::Opik.AgentInsightsReport request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store agent insights report results<br/>
        /// Upserts the detected issues and their per-day metrics for the given report day in a single transaction. Issue status is never modified by this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> ReportAgentInsightsIssuesAsResponseAsync(

            global::Opik.AgentInsightsReport request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store agent insights report results<br/>
        /// Upserts the detected issues and their per-day metrics for the given report day in a single transaction. Issue status is never modified by this endpoint.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="reportDay"></param>
        /// <param name="issues"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReportAgentInsightsIssuesAsync(
            global::System.Guid projectId,
            global::System.DateTime reportDay,
            global::System.Collections.Generic.IList<global::Opik.ReportedIssue> issues,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}