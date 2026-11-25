#nullable enable

namespace Opik
{
    public partial interface IGuardrailModelsClient
    {
        /// <summary>
        /// Cancel guardrail model training run<br/>
        /// Cancel a training run that is queued or running. Cancelling a cancelled run again changes nothing and answers 204 too
        /// </summary>
        /// <param name="id"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelGuardrailTrainingRunAsync(
            global::System.Guid id,
            global::System.Guid runId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel guardrail model training run<br/>
        /// Cancel a training run that is queued or running. Cancelling a cancelled run again changes nothing and answers 204 too
        /// </summary>
        /// <param name="id"></param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CancelGuardrailTrainingRunAsResponseAsync(
            global::System.Guid id,
            global::System.Guid runId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}