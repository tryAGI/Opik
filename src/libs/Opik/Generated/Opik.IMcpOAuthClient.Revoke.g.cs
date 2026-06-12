#nullable enable

namespace Opik
{
    public partial interface IMcpOAuthClient
    {
        /// <summary>
        /// OAuth Token Revocation Endpoint<br/>
        /// OAuth 2.0 token revocation endpoint (RFC 7009). Always returns 200, whether the token was revoked, never existed, or was invalid
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeAsync(

            global::Opik.RevokeRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth Token Revocation Endpoint<br/>
        /// OAuth 2.0 token revocation endpoint (RFC 7009). Always returns 200, whether the token was revoked, never existed, or was invalid
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> RevokeAsResponseAsync(

            global::Opik.RevokeRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth Token Revocation Endpoint<br/>
        /// OAuth 2.0 token revocation endpoint (RFC 7009). Always returns 200, whether the token was revoked, never existed, or was invalid
        /// </summary>
        /// <param name="token"></param>
        /// <param name="clientId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RevokeAsync(
            string? token = default,
            string? clientId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}