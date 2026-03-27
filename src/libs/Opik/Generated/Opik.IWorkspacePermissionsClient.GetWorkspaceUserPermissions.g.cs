#nullable enable

namespace Opik
{
    public partial interface IWorkspacePermissionsClient
    {
        /// <summary>
        /// Get workspace permissions for the authenticated user<br/>
        /// Get workspace permissions for the authenticated user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.WorkspaceUserPermissions> GetWorkspaceUserPermissionsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}