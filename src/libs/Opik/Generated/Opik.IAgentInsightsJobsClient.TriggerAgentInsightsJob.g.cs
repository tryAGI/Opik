#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsJobsClient
    {
        /// <summary>
        /// Trigger Agent Insights job<br/>
        /// Triggers an immediate report run for an existing job (over the last 24h). Fire-and-forget; returns 202. 404 if none exists.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task TriggerAgentInsightsJobAsync(
            global::System.Guid projectId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Agent Insights job<br/>
        /// Triggers an immediate report run for an existing job (over the last 24h). Fire-and-forget; returns 202. 404 if none exists.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> TriggerAgentInsightsJobAsResponseAsync(
            global::System.Guid projectId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}