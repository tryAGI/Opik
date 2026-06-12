#nullable enable

namespace Opik
{
    public partial interface IMcpOAuthClient
    {
        /// <summary>
        /// OAuth Token Endpoint<br/>
        /// OAuth 2.1 token endpoint (RFC 6749 §4.1.3, §6). Exchanges an authorization code with PKCE or a refresh token for an access/refresh token pair
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.TokenResponse> TokenAsync(

            global::Opik.TokenRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth Token Endpoint<br/>
        /// OAuth 2.1 token endpoint (RFC 6749 §4.1.3, §6). Exchanges an authorization code with PKCE or a refresh token for an access/refresh token pair
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.TokenResponse>> TokenAsResponseAsync(

            global::Opik.TokenRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth Token Endpoint<br/>
        /// OAuth 2.1 token endpoint (RFC 6749 §4.1.3, §6). Exchanges an authorization code with PKCE or a refresh token for an access/refresh token pair
        /// </summary>
        /// <param name="grantType"></param>
        /// <param name="code"></param>
        /// <param name="redirectUri"></param>
        /// <param name="clientId"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="refreshToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.TokenResponse> TokenAsync(
            string? grantType = default,
            string? code = default,
            string? redirectUri = default,
            string? clientId = default,
            string? codeVerifier = default,
            string? refreshToken = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}