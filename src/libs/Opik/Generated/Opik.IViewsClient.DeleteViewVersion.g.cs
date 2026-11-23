#nullable enable

namespace Opik
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// Delete view version<br/>
        /// Delete one version of a view. Refused for the current version, and so for the only version; version numbers are never reused.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteViewVersionAsync(
            global::System.Guid id,
            int version,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete view version<br/>
        /// Delete one version of a view. Refused for the current version, and so for the only version; version numbers are never reused.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> DeleteViewVersionAsResponseAsync(
            global::System.Guid id,
            int version,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}