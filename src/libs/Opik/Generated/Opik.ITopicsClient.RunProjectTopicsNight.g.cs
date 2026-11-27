#nullable enable

namespace Opik
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Run a project's nightly update now<br/>
        /// Queues the project's nightly update for the night date (UTC; default today, at most tomorrow, at least the vectors backfill window ago) and returns its run id; any pod runs it. Its window ends at the night's start. The run's outcome is on the project's topic_projects row while it is the project's latest run, and in the run's logs. The workspace is opted in to topics at stage nightly or later, the project has a list whose window ends before the night, its window holds topics.run.minVectors vectors, and it has no run in flight. topics.runs.maxInFlight and the night's budget do not apply, and the project's night fields are not written.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="night"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task RunProjectTopicsNightAsync(
            global::System.Guid projectId,
            string workspaceId,
            string? night = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a project's nightly update now<br/>
        /// Queues the project's nightly update for the night date (UTC; default today, at most tomorrow, at least the vectors backfill window ago) and returns its run id; any pod runs it. Its window ends at the night's start. The run's outcome is on the project's topic_projects row while it is the project's latest run, and in the run's logs. The workspace is opted in to topics at stage nightly or later, the project has a list whose window ends before the night, its window holds topics.run.minVectors vectors, and it has no run in flight. topics.runs.maxInFlight and the night's budget do not apply, and the project's night fields are not written.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="night"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> RunProjectTopicsNightAsResponseAsync(
            global::System.Guid projectId,
            string workspaceId,
            string? night = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}