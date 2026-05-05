#nullable enable

namespace Opik
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Create automation rule evaluator<br/>
        /// Create automation rule evaluator
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAutomationRuleEvaluatorAsync(

            global::Opik.AutomationRuleEvaluatorWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create automation rule evaluator<br/>
        /// Create automation rule evaluator
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CreateAutomationRuleEvaluatorAsResponseAsync(

            global::Opik.AutomationRuleEvaluatorWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create automation rule evaluator<br/>
        /// Create automation rule evaluator
        /// </summary>
        /// <param name="projectId">
        /// Primary project ID (legacy field for backwards compatibility)
        /// </param>
        /// <param name="projectIds">
        /// Project IDs for write operations (used when creating/updating rules)
        /// </param>
        /// <param name="name"></param>
        /// <param name="samplingRate"></param>
        /// <param name="enabled"></param>
        /// <param name="action"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAutomationRuleEvaluatorAsync(
            string name,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            float? samplingRate = default,
            bool? enabled = default,
            global::Opik.AutomationRuleEvaluatorWriteAction action = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}