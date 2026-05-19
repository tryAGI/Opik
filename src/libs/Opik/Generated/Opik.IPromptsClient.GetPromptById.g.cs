#nullable enable

namespace Opik
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt by id<br/>
        /// Get prompt by id; when mask_id is provided, requestedVersion is populated with that mask overlay
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.PromptDetail> GetPromptByIdAsync(
            global::System.Guid id,
            global::System.Guid? maskId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get prompt by id<br/>
        /// Get prompt by id; when mask_id is provided, requestedVersion is populated with that mask overlay
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.PromptDetail>> GetPromptByIdAsResponseAsync(
            global::System.Guid id,
            global::System.Guid? maskId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}