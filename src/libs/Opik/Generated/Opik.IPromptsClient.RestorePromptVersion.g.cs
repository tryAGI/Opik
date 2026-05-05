#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Restore prompt version<br/>
        /// Restore a prompt version by creating a new version with the content from the specified version
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.PromptVersionDetail> RestorePromptVersionAsync(
            global::System.Guid promptId,
            global::System.Guid versionId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore prompt version<br/>
        /// Restore a prompt version by creating a new version with the content from the specified version
        /// </summary>
        /// <param name="promptId"></param>
        /// <param name="versionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.PromptVersionDetail>> RestorePromptVersionAsResponseAsync(
            global::System.Guid promptId,
            global::System.Guid versionId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}