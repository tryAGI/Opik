#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Poll next bridge commands<br/>
        /// Long-poll for pending bridge commands (batch)
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.BridgeCommandBatchResponse> NextBridgeCommandsAsync(
            global::System.Guid runnerId,

            global::Opik.BridgeCommandNextRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll next bridge commands<br/>
        /// Long-poll for pending bridge commands (batch)
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="maxCommands"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.BridgeCommandBatchResponse> NextBridgeCommandsAsync(
            global::System.Guid runnerId,
            int? maxCommands = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}