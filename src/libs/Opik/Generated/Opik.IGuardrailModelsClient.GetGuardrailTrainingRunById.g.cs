#nullable enable

namespace Opik
{
    public partial interface IGuardrailModelsClient
    {
        /// <summary>
        /// Get guardrail model training run by id<br/>
        /// Get one training run of a guardrail model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.GuardrailTrainingRun> GetGuardrailTrainingRunByIdAsync(
            global::System.Guid id,
            global::System.Guid runId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get guardrail model training run by id<br/>
        /// Get one training run of a guardrail model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.GuardrailTrainingRun>> GetGuardrailTrainingRunByIdAsResponseAsync(
            global::System.Guid id,
            global::System.Guid runId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}