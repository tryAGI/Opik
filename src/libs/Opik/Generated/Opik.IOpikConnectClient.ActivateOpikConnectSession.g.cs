#nullable enable

namespace Opik
{
    public partial interface IOpikConnectClient
    {
        /// <summary>
        /// Activate an opik-connect pairing session<br/>
        /// Verify the activation HMAC and flip the runner row to CONNECTED
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ActivateOpikConnectSessionAsync(
            global::System.Guid sessionId,

            global::Opik.ActivateRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Activate an opik-connect pairing session<br/>
        /// Verify the activation HMAC and flip the runner row to CONNECTED
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="runnerName"></param>
        /// <param name="hmac"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActivateOpikConnectSessionAsync(
            global::System.Guid sessionId,
            string runnerName,
            string hmac,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}