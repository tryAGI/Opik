#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsJobsClient
    {
        /// <summary>
        /// Update Agent Insights project guidance<br/>
        /// Saves the project guidance sent to every Agent Insights run, creating the job (disabled) if the project has none. Empty or whitespace-only clears it. The guidance version is bumped only when the text changes. 404 while guidance is not enabled.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentInsightsJob> UpdateAgentInsightsGuidanceAsync(
            global::System.Guid projectId,

            global::Opik.AgentInsightsGuidanceUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Insights project guidance<br/>
        /// Saves the project guidance sent to every Agent Insights run, creating the job (disabled) if the project has none. Empty or whitespace-only clears it. The guidance version is bumped only when the text changes. 404 while guidance is not enabled.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AgentInsightsJob>> UpdateAgentInsightsGuidanceAsResponseAsync(
            global::System.Guid projectId,

            global::Opik.AgentInsightsGuidanceUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Insights project guidance<br/>
        /// Saves the project guidance sent to every Agent Insights run, creating the job (disabled) if the project has none. Empty or whitespace-only clears it. The guidance version is bumped only when the text changes. 404 while guidance is not enabled.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="guidance">
        /// Project guidance for Agent Insights runs. Empty or whitespace-only clears it
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentInsightsJob> UpdateAgentInsightsGuidanceAsync(
            global::System.Guid projectId,
            string guidance,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}