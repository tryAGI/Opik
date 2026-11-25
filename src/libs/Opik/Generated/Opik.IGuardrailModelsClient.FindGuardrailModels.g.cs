#nullable enable

namespace Opik
{
    public partial interface IGuardrailModelsClient
    {
        /// <summary>
        /// Find guardrail models<br/>
        /// Find the workspace's guardrail models, each with its serving run and its latest run
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter models by name (partial match, case insensitive)
        /// </param>
        /// <param name="usableOnly">
        /// Only the models with a serving run, the ones a rule can use<br/>
        /// Default Value: false
        /// </param>
        /// <param name="latestRunStatus">
        /// Filter models by their latest run's status
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.GuardrailModelPage> FindGuardrailModelsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            bool? usableOnly = default,
            global::Opik.FindGuardrailModelsLatestRunStatus? latestRunStatus = default,
            string? sorting = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find guardrail models<br/>
        /// Find the workspace's guardrail models, each with its serving run and its latest run
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter models by name (partial match, case insensitive)
        /// </param>
        /// <param name="usableOnly">
        /// Only the models with a serving run, the ones a rule can use<br/>
        /// Default Value: false
        /// </param>
        /// <param name="latestRunStatus">
        /// Filter models by their latest run's status
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.GuardrailModelPage>> FindGuardrailModelsAsResponseAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            bool? usableOnly = default,
            global::Opik.FindGuardrailModelsLatestRunStatus? latestRunStatus = default,
            string? sorting = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}