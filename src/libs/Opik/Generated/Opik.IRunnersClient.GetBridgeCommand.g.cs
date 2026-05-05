#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Get bridge command<br/>
        /// Get bridge command status, optionally long-polling for completion
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="wait">
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.BridgeCommand> GetBridgeCommandAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,
            bool? wait = default,
            int? timeout = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get bridge command<br/>
        /// Get bridge command status, optionally long-polling for completion
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="wait">
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.BridgeCommand>> GetBridgeCommandAsResponseAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,
            bool? wait = default,
            int? timeout = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}