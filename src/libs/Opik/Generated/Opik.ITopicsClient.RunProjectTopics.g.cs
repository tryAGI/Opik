#nullable enable

namespace Opik
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Run a project's topics now<br/>
        /// Queues the project's discovery run and returns its run id; any pod runs it. The run's outcome is on the project's topic_projects row while it is the project's latest run, and in the run's logs. The window ends at the start of the night date (UTC; default today, at most tomorrow, at least the vectors backfill window ago). The workspace is opted in to topics at stage build or later, the window holds topics.run.minVectors vectors of the project, and the project has no list and no run in flight. The project's vectors backfill must have drained: ignore_backfill=true builds it from the vectors it has so far. A failed discovery run's retry wait and topics.runs.maxInFlight do not apply.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="night"></param>
        /// <param name="ignoreBackfill">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task RunProjectTopicsAsync(
            global::System.Guid projectId,
            string workspaceId,
            string? night = default,
            bool? ignoreBackfill = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a project's topics now<br/>
        /// Queues the project's discovery run and returns its run id; any pod runs it. The run's outcome is on the project's topic_projects row while it is the project's latest run, and in the run's logs. The window ends at the start of the night date (UTC; default today, at most tomorrow, at least the vectors backfill window ago). The workspace is opted in to topics at stage build or later, the window holds topics.run.minVectors vectors of the project, and the project has no list and no run in flight. The project's vectors backfill must have drained: ignore_backfill=true builds it from the vectors it has so far. A failed discovery run's retry wait and topics.runs.maxInFlight do not apply.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="night"></param>
        /// <param name="ignoreBackfill">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> RunProjectTopicsAsResponseAsync(
            global::System.Guid projectId,
            string workspaceId,
            string? night = default,
            bool? ignoreBackfill = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}