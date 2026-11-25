#nullable enable

namespace Opik
{
    public partial interface IGuardrailModelsClient
    {
        /// <summary>
        /// Retrain guardrail model<br/>
        /// Start a new training of the model from a labelled JSONL file; the serving run keeps serving until the new one completes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task RetrainGuardrailModelAsync(
            global::System.Guid id,

            global::Opik.RetrainGuardrailModelRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrain guardrail model<br/>
        /// Start a new training of the model from a labelled JSONL file; the serving run keeps serving until the new one completes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> RetrainGuardrailModelAsResponseAsync(
            global::System.Guid id,

            global::Opik.RetrainGuardrailModelRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrain guardrail model<br/>
        /// Start a new training of the model from a labelled JSONL file; the serving run keeps serving until the new one completes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="file">
        /// JSON Lines in UTF-8, one {"text": "...", "label": "yes" | "no"} object per line, yes meaning the text violates. The deployment sets the limits; by default 20 to 50,000 rows, at least 5 per label, up to 12,000 characters each, 50 MB
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RetrainGuardrailModelAsync(
            global::System.Guid id,
            object file,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}