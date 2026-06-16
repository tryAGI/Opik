#nullable enable

namespace Opik
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Complete report generation<br/>
        /// Callback from Ollie to update report status and content after generation.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="reportId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CompleteReportAsync(
            global::System.Guid projectId,
            global::System.Guid reportId,

            global::Opik.ReportCompleteRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete report generation<br/>
        /// Callback from Ollie to update report status and content after generation.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="reportId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> CompleteReportAsResponseAsync(
            global::System.Guid projectId,
            global::System.Guid reportId,

            global::Opik.ReportCompleteRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete report generation<br/>
        /// Callback from Ollie to update report status and content after generation.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="reportId"></param>
        /// <param name="content"></param>
        /// <param name="status"></param>
        /// <param name="sessionId"></param>
        /// <param name="recommendedActions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CompleteReportAsync(
            global::System.Guid projectId,
            global::System.Guid reportId,
            global::Opik.ReportCompleteRequestStatus status,
            string? content = default,
            string? sessionId = default,
            global::Opik.JsonNode? recommendedActions = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}