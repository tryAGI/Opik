#nullable enable

namespace Opik
{
    public partial interface ILlmModelsClient
    {
        /// <summary>
        /// Get LLM models<br/>
        /// Get the list of supported LLM models grouped by provider
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetLlmModelsAsync(
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}