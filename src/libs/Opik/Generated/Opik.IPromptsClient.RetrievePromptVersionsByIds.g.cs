#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Retrieve prompt versions by ids<br/>
        /// Retrieve a batch of prompt versions by their ids. Typically used by the UI to resolve mask overlays.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>> RetrievePromptVersionsByIdsAsync(

            global::Opik.PromptVersionIdsRequestDetail request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve prompt versions by ids<br/>
        /// Retrieve a batch of prompt versions by their ids. Typically used by the UI to resolve mask overlays.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>>> RetrievePromptVersionsByIdsAsResponseAsync(

            global::Opik.PromptVersionIdsRequestDetail request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve prompt versions by ids<br/>
        /// Retrieve a batch of prompt versions by their ids. Typically used by the UI to resolve mask overlays.
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>> RetrievePromptVersionsByIdsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}