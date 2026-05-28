#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt version by sequential number<br/>
        /// Get a prompt version by its sequential v&lt;N&gt; number for the given prompt.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.PromptVersionDetail> GetPromptVersionByNumberAsync(
            global::System.Guid promptId,
            string versionNumber,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get prompt version by sequential number<br/>
        /// Get a prompt version by its sequential v&lt;N&gt; number for the given prompt.
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.PromptVersionDetail>> GetPromptVersionByNumberAsResponseAsync(
            global::System.Guid promptId,
            string versionNumber,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}