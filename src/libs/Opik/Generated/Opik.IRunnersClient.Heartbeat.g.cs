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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.LocalRunnerHeartbeatResponse> HeartbeatAsync(
            global::System.Guid runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}