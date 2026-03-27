#nullable enable

namespace Opik
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get workspace configuration<br/>
        /// Get workspace configuration
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.WorkspaceConfiguration> GetWorkspaceConfigurationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}