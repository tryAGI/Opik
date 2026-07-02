#nullable enable

namespace Opik
{
    public partial interface IReportFailuresClient
    {
        /// <summary>
        /// List failures for a project<br/>
        /// Returns failures for the given project id and type, most recent first.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ReportFailurePage> FindReportFailuresAsync(
            global::Opik.FindReportFailuresType type,
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List failures for a project<br/>
        /// Returns failures for the given project id and type, most recent first.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ReportFailurePage>> FindReportFailuresAsResponseAsync(
            global::Opik.FindReportFailuresType type,
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}