#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsClient
    {
        /// <summary>
        /// Update agent insights issue status<br/>
        /// Moves an issue through its lifecycle: open, resolved or closed
        /// </summary>
        /// <param name="issueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateAgentInsightsIssueAsync(
            global::System.Guid issueId,

            global::Opik.AgentInsightsIssueUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent insights issue status<br/>
        /// Moves an issue through its lifecycle: open, resolved or closed
        /// </summary>
        /// <param name="issueId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> UpdateAgentInsightsIssueAsResponseAsync(
            global::System.Guid issueId,

            global::Opik.AgentInsightsIssueUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update agent insights issue status<br/>
        /// Moves an issue through its lifecycle: open, resolved or closed
        /// </summary>
        /// <param name="issueId"></param>
        /// <param name="projectId"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateAgentInsightsIssueAsync(
            global::System.Guid issueId,
            global::System.Guid projectId,
            global::Opik.AgentInsightsIssueUpdateStatus status,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}