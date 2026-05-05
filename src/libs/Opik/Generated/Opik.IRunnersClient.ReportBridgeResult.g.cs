#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Report bridge command result<br/>
        /// Report bridge command completion or failure
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ReportBridgeResultAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,

            global::Opik.BridgeCommandResultRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Report bridge command result<br/>
        /// Report bridge command completion or failure
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> ReportBridgeResultAsResponseAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,

            global::Opik.BridgeCommandResultRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Report bridge command result<br/>
        /// Report bridge command completion or failure
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="commandId"></param>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="error"></param>
        /// <param name="durationMs"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReportBridgeResultAsync(
            global::System.Guid runnerId,
            global::System.Guid commandId,
            global::Opik.BridgeCommandResultRequestStatus status,
            global::Opik.JsonNode? result = default,
            global::Opik.JsonNode? error = default,
            long? durationMs = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}