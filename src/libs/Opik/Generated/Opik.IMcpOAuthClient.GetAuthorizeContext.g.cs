#nullable enable

namespace Opik
{
    public partial interface IMcpOAuthClient
    {
        /// <summary>
        /// Get Authorization Consent Context<br/>
        /// Get the client details, eligible workspaces, and a CSRF token used to render the consent screen
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AuthorizeContext> GetAuthorizeContextAsync(
            string clientId,
            string redirectUri,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Authorization Consent Context<br/>
        /// Get the client details, eligible workspaces, and a CSRF token used to render the consent screen
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AuthorizeContext>> GetAuthorizeContextAsResponseAsync(
            string clientId,
            string redirectUri,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}