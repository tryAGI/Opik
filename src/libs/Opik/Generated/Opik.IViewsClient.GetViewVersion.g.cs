#nullable enable

namespace Opik
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Get view version<br/>
        /// Get one version of a view
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ViewVersion> GetViewVersionAsync(
            global::System.Guid id,
            int version,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get view version<br/>
        /// Get one version of a view
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ViewVersion>> GetViewVersionAsResponseAsync(
            global::System.Guid id,
            int version,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}