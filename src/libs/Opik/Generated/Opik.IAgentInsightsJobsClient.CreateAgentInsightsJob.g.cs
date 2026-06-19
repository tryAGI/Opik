#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsJobsClient
    {
        /// <summary>
        /// Create Agent Insights job<br/>
        /// Creates the Agent Insights job for a project. 409 if one already exists.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentInsightsJob> CreateAgentInsightsJobAsync(
            global::System.Guid projectId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Insights job<br/>
        /// Creates the Agent Insights job for a project. 409 if one already exists.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AgentInsightsJob>> CreateAgentInsightsJobAsResponseAsync(
            global::System.Guid projectId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}