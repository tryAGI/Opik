#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Submit bridge command<br/>
        /// Submit a bridge command for execution by the local daemon
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.BridgeCommandSubmitResponse> CreateBridgeCommandAsync(
            global::System.Guid runnerId,

            global::Opik.BridgeCommandSubmitRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit bridge command<br/>
        /// Submit a bridge command for execution by the local daemon
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.BridgeCommandSubmitResponse>> CreateBridgeCommandAsResponseAsync(
            global::System.Guid runnerId,

            global::Opik.BridgeCommandSubmitRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit bridge command<br/>
        /// Submit a bridge command for execution by the local daemon
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="type"></param>
        /// <param name="args"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.BridgeCommandSubmitResponse> CreateBridgeCommandAsync(
            global::System.Guid runnerId,
            global::Opik.BridgeCommandSubmitRequestType type,
            global::Opik.JsonNode args,
            int? timeoutSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}