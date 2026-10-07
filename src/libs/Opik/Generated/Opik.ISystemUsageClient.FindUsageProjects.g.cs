#nullable enable

namespace Opik
{
    public partial interface ISystemUsageClient
    {
        /// <summary>
        /// Find projects across workspaces by ids or name<br/>
        /// Find projects across the given workspaces, optionally narrowed by project ids or a case-insensitive name substring. Unknown or deleted projects are omitted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.UsageProjectsResponse> FindUsageProjectsAsync(

            global::Opik.UsageProjectsRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find projects across workspaces by ids or name<br/>
        /// Find projects across the given workspaces, optionally narrowed by project ids or a case-insensitive name substring. Unknown or deleted projects are omitted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.UsageProjectsResponse>> FindUsageProjectsAsResponseAsync(

            global::Opik.UsageProjectsRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find projects across workspaces by ids or name<br/>
        /// Find projects across the given workspaces, optionally narrowed by project ids or a case-insensitive name substring. Unknown or deleted projects are omitted.
        /// </summary>
        /// <param name="workspaceIds"></param>
        /// <param name="projectIds"></param>
        /// <param name="name"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.UsageProjectsResponse> FindUsageProjectsAsync(
            global::System.Collections.Generic.IList<string> workspaceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            string? name = default,
            int? limit = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}