#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsJobsClient
    {
        /// <summary>
        /// Update Agent Insights job<br/>
        /// Partially updates the Agent Insights job for a project (e.g. status; never deletes). Returns the updated job, or 404 if none exists.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentInsightsJob> UpdateAgentInsightsJobAsync(
            global::System.Guid projectId,

            global::Opik.AgentInsightsJobUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Insights job<br/>
        /// Partially updates the Agent Insights job for a project (e.g. status; never deletes). Returns the updated job, or 404 if none exists.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AgentInsightsJob>> UpdateAgentInsightsJobAsResponseAsync(
            global::System.Guid projectId,

            global::Opik.AgentInsightsJobUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Insights job<br/>
        /// Partially updates the Agent Insights job for a project (e.g. status; never deletes). Returns the updated job, or 404 if none exists.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="status">
        /// New status for the job
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentInsightsJob> UpdateAgentInsightsJobAsync(
            global::System.Guid projectId,
            global::Opik.AgentInsightsJobUpdateStatus status,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}