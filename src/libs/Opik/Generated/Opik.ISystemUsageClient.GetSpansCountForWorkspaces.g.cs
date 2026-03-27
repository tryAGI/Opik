#nullable enable

namespace Opik
{
    public partial interface ISystemUsageClient
    {
        /// <summary>
        /// Get spans count on previous day for all available workspaces<br/>
        /// Get spans count on previous day for all available workspaces
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.SpansCountResponse> GetSpansCountForWorkspacesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}