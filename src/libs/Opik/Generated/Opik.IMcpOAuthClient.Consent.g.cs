#nullable enable

namespace Opik
{
    public partial interface IMcpOAuthClient
    {
        /// <summary>
        /// Submit Authorization Consent<br/>
        /// Submit the user's consent, issue an authorization code, and return the client redirect target
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ConsentResponse> ConsentAsync(

            global::Opik.ConsentRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Authorization Consent<br/>
        /// Submit the user's consent, issue an authorization code, and return the client redirect target
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ConsentResponse>> ConsentAsResponseAsync(

            global::Opik.ConsentRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Authorization Consent<br/>
        /// Submit the user's consent, issue an authorization code, and return the client redirect target
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="resource"></param>
        /// <param name="state"></param>
        /// <param name="workspaceId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="csrf"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ConsentResponse> ConsentAsync(
            string clientId,
            string redirectUri,
            string codeChallenge,
            string codeChallengeMethod,
            string resource,
            string? state = default,
            string? workspaceId = default,
            string? workspaceName = default,
            string? csrf = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}