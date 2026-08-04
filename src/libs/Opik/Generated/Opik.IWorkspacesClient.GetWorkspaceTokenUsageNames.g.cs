#nullable enable

namespace Opik
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get workspace token usage names<br/>
        /// Gets the distinct span token usage key names aggregated across the workspace. When project_ids is empty, all projects in the workspace are included; otherwise only the given projects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.TokenUsageNames> GetWorkspaceTokenUsageNamesAsync(

            global::Opik.WorkspaceTokenUsageNamesRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workspace token usage names<br/>
        /// Gets the distinct span token usage key names aggregated across the workspace. When project_ids is empty, all projects in the workspace are included; otherwise only the given projects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.TokenUsageNames>> GetWorkspaceTokenUsageNamesAsResponseAsync(

            global::Opik.WorkspaceTokenUsageNamesRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get workspace token usage names<br/>
        /// Gets the distinct span token usage key names aggregated across the workspace. When project_ids is empty, all projects in the workspace are included; otherwise only the given projects.
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.TokenUsageNames> GetWorkspaceTokenUsageNamesAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}