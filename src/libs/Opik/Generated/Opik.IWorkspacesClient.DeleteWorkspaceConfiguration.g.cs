#nullable enable

namespace Opik
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete workspace configuration<br/>
        /// Delete workspace configuration
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteWorkspaceConfigurationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}