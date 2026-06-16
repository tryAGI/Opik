#nullable enable

namespace Opik
{
    public partial interface IMcpOAuthClient
    {
        /// <summary>
        /// OAuth Authorization Endpoint<br/>
        /// OAuth 2.1 authorization endpoint (RFC 6749 §3.1). Validates the client and PKCE parameters, then redirects to the login or consent page
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="responseType"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="resource"></param>
        /// <param name="state"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task AuthorizeAsync(
            string clientId,
            string redirectUri,
            string? responseType = default,
            string? codeChallenge = default,
            string? codeChallengeMethod = default,
            string? resource = default,
            string? state = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth Authorization Endpoint<br/>
        /// OAuth 2.1 authorization endpoint (RFC 6749 §3.1). Validates the client and PKCE parameters, then redirects to the login or consent page
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="responseType"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="resource"></param>
        /// <param name="state"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> AuthorizeAsResponseAsync(
            string clientId,
            string redirectUri,
            string? responseType = default,
            string? codeChallenge = default,
            string? codeChallengeMethod = default,
            string? resource = default,
            string? state = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}