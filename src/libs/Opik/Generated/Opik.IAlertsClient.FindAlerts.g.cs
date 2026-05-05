#nullable enable

namespace Opik
{
    public partial interface IAlertsClient
    {
        /// <summary>
        /// Find alerts<br/>
        /// Find alerts
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AlertPagePublic> FindAlertsAsync(
            int? page = default,
            int? size = default,
            string? sorting = default,
            string? filters = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find alerts<br/>
        /// Find alerts
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AlertPagePublic>> FindAlertsAsResponseAsync(
            int? page = default,
            int? size = default,
            string? sorting = default,
            string? filters = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}