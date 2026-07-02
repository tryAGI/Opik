#nullable enable

namespace Opik
{
    public partial interface IReportFailuresClient
    {
        /// <summary>
        /// Record a report/job failure<br/>
        /// Appends a failure row keyed by (project_id, type). Append-only — never overwrites earlier failures.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateReportFailureAsync(

            global::Opik.ReportFailure request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record a report/job failure<br/>
        /// Appends a failure row keyed by (project_id, type). Append-only — never overwrites earlier failures.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CreateReportFailureAsResponseAsync(

            global::Opik.ReportFailure request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Record a report/job failure<br/>
        /// Appends a failure row keyed by (project_id, type). Append-only — never overwrites earlier failures.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="projectId"></param>
        /// <param name="reason"></param>
        /// <param name="detail"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateReportFailureAsync(
            global::System.Guid projectId,
            string reason,
            global::Opik.ReportFailureType type = default,
            string? detail = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}