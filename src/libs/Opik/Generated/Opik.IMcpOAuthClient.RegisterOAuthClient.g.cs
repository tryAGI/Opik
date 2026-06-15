#nullable enable

namespace Opik
{
    public partial interface IMcpOAuthClient
    {
        /// <summary>
        /// OAuth Dynamic Client Registration Endpoint<br/>
        /// OAuth 2.0 Dynamic Client Registration (RFC 7591). Registers a public client for the MCP OAuth flow; throttled per source IP
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ClientRegistrationResponse> RegisterOAuthClientAsync(

            global::Opik.ClientRegistrationRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth Dynamic Client Registration Endpoint<br/>
        /// OAuth 2.0 Dynamic Client Registration (RFC 7591). Registers a public client for the MCP OAuth flow; throttled per source IP
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ClientRegistrationResponse>> RegisterOAuthClientAsResponseAsync(

            global::Opik.ClientRegistrationRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// OAuth Dynamic Client Registration Endpoint<br/>
        /// OAuth 2.0 Dynamic Client Registration (RFC 7591). Registers a public client for the MCP OAuth flow; throttled per source IP
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="redirectUris"></param>
        /// <param name="logoUri"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ClientRegistrationResponse> RegisterOAuthClientAsync(
            string clientName,
            global::System.Collections.Generic.IList<string> redirectUris,
            string? logoUri = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}