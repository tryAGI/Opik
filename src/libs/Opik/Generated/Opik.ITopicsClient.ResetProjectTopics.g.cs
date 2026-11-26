#nullable enable

namespace Opik
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Forget a project's topic list<br/>
        /// Deletes the project's topics and clears the list on its topic_projects row, in one transaction, so its next discovery run, planned or by hand, builds a new list. The row's run and vectors backfill state stay. The workspace is opted in to topics at stage build or later, and the project has a topic_projects row and no run in flight.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ResetProjectTopicsAsync(
            global::System.Guid projectId,
            string workspaceId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Forget a project's topic list<br/>
        /// Deletes the project's topics and clears the list on its topic_projects row, in one transaction, so its next discovery run, planned or by hand, builds a new list. The row's run and vectors backfill state stay. The workspace is opted in to topics at stage build or later, and the project has a topic_projects row and no run in flight.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> ResetProjectTopicsAsResponseAsync(
            global::System.Guid projectId,
            string workspaceId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}