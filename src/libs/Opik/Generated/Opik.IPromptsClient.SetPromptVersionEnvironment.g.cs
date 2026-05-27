#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Set prompt version environment<br/>
        /// Set or clear the environment owned by a prompt version.<br/>
        /// Setting a non-null environment moves ownership atomically: any previous owner of that<br/>
        /// environment for the same prompt has its environment cleared in the same transaction.<br/>
        /// Setting null clears the environment from the version.<br/>
        /// The environment must already exist in the workspace registry; unknown names return 404.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task SetPromptVersionEnvironmentAsync(
            global::System.Guid versionId,

            global::Opik.PromptVersionEnvironmentUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set prompt version environment<br/>
        /// Set or clear the environment owned by a prompt version.<br/>
        /// Setting a non-null environment moves ownership atomically: any previous owner of that<br/>
        /// environment for the same prompt has its environment cleared in the same transaction.<br/>
        /// Setting null clears the environment from the version.<br/>
        /// The environment must already exist in the workspace registry; unknown names return 404.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> SetPromptVersionEnvironmentAsResponseAsync(
            global::System.Guid versionId,

            global::Opik.PromptVersionEnvironmentUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set prompt version environment<br/>
        /// Set or clear the environment owned by a prompt version.<br/>
        /// Setting a non-null environment moves ownership atomically: any previous owner of that<br/>
        /// environment for the same prompt has its environment cleared in the same transaction.<br/>
        /// Setting null clears the environment from the version.<br/>
        /// The environment must already exist in the workspace registry; unknown names return 404.
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="environments"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SetPromptVersionEnvironmentAsync(
            global::System.Guid versionId,
            global::System.Collections.Generic.IList<string> environments,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}