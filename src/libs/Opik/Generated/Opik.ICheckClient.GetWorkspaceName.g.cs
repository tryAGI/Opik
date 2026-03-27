#nullable enable

namespace Opik
{
    public partial interface ICheckClient
    {
        /// <summary>
        /// User's default workspace name<br/>
        /// User's default workspace name
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.WorkspaceNameHolder> GetWorkspaceNameAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}