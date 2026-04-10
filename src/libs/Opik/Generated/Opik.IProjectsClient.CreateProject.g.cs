#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create project<br/>
        /// Create project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateProjectAsync(

            global::Opik.ProjectWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create project<br/>
        /// Create project
        /// </summary>
        /// <param name="name"></param>
        /// <param name="visibility"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateProjectAsync(
            string name,
            global::Opik.ProjectWriteVisibility? visibility = default,
            string? description = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}