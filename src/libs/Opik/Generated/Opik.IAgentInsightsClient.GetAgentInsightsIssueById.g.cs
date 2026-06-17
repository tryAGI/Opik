#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsClient
    {
        /// <summary>
        /// Get agent insights issue by id<br/>
        /// Returns the issue together with its per-day breakdown within the requested time window
        /// </summary>
        /// <param name="issueId"></param>
        /// <param name="projectId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentInsightsIssueWithDetails> GetAgentInsightsIssueByIdAsync(
            global::System.Guid issueId,
            global::System.Guid projectId,
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get agent insights issue by id<br/>
        /// Returns the issue together with its per-day breakdown within the requested time window
        /// </summary>
        /// <param name="issueId"></param>
        /// <param name="projectId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AgentInsightsIssueWithDetails>> GetAgentInsightsIssueByIdAsResponseAsync(
            global::System.Guid issueId,
            global::System.Guid projectId,
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}