#nullable enable

namespace Opik
{
    public partial interface ITopicsClient
    {
        /// <summary>
        /// Get a project's topics<br/>
        /// The project's topics over the window, the last topics.run.windowDays UTC days (default 30), today included: per topic its count, share, rank and a daily series, plus Other's daily series. Counts can be up to 5 minutes old. status is disabled when the workspace is not opted in to topics, collecting while the project has no topics yet, too_large when a ClickHouse read hit a rows, bytes or memory guard (a retry answers the same, so do not retry), and ready otherwise. Fields of other states are omitted.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectTopics> GetProjectTopicsAsync(
            global::System.Guid projectId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a project's topics<br/>
        /// The project's topics over the window, the last topics.run.windowDays UTC days (default 30), today included: per topic its count, share, rank and a daily series, plus Other's daily series. Counts can be up to 5 minutes old. status is disabled when the workspace is not opted in to topics, collecting while the project has no topics yet, too_large when a ClickHouse read hit a rows, bytes or memory guard (a retry answers the same, so do not retry), and ready otherwise. Fields of other states are omitted.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ProjectTopics>> GetProjectTopicsAsResponseAsync(
            global::System.Guid projectId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}