#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Local runner heartbeat<br/>
        /// Refresh local runner heartbeat
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.LocalRunnerHeartbeatResponse> HeartbeatAsync(
            global::System.Guid runnerId,

            global::Opik.LocalRunnerHeartbeatRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Local runner heartbeat<br/>
        /// Refresh local runner heartbeat
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.LocalRunnerHeartbeatResponse>> HeartbeatAsResponseAsync(
            global::System.Guid runnerId,

            global::Opik.LocalRunnerHeartbeatRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Local runner heartbeat<br/>
        /// Refresh local runner heartbeat
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="capabilities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.LocalRunnerHeartbeatResponse> HeartbeatAsync(
            global::System.Guid runnerId,
            global::System.Collections.Generic.IList<string>? capabilities = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}