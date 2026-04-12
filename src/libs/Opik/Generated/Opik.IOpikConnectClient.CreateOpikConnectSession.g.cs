#nullable enable

namespace Opik
{
    public partial interface IOpikConnectClient
    {
        /// <summary>
        /// Create an opik-connect pairing session<br/>
        /// Register a short-lived pairing session that a local daemon will later activate via HMAC
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.CreateSessionResponse> CreateOpikConnectSessionAsync(

            global::Opik.CreateSessionRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an opik-connect pairing session<br/>
        /// Register a short-lived pairing session that a local daemon will later activate via HMAC
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="activationKey"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.CreateSessionResponse> CreateOpikConnectSessionAsync(
            global::System.Guid projectId,
            string activationKey,
            int? ttlSeconds = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}