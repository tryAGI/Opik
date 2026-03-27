#nullable enable

namespace Opik
{
    public partial interface IRedirectClient
    {
        /// <summary>
        /// Create project redirect url<br/>
        /// Create project redirect url
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="path"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsRedirectAsync(
            global::System.Guid traceId,
            string path,
            string? workspaceName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}