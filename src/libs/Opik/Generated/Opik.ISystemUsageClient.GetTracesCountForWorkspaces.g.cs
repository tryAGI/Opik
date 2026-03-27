#nullable enable

namespace Opik
{
    public partial interface ISystemUsageClient
    {
        /// <summary>
        /// Get traces count on previous day for all available workspaces<br/>
        /// Get traces count on previous day for all available workspaces
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.TraceCountResponse> GetTracesCountForWorkspacesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}