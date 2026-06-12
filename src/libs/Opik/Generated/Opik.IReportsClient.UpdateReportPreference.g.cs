#nullable enable

namespace Opik
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Update report preferences<br/>
        /// Enable or disable daily report generation for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ReportPreference> UpdateReportPreferenceAsync(
            global::System.Guid projectId,

            global::Opik.ReportPreference request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update report preferences<br/>
        /// Enable or disable daily report generation for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ReportPreference>> UpdateReportPreferenceAsResponseAsync(
            global::System.Guid projectId,

            global::Opik.ReportPreference request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update report preferences<br/>
        /// Enable or disable daily report generation for a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestProjectId"></param>
        /// <param name="enabled"></param>
        /// <param name="scheduleTime"></param>
        /// <param name="customPrompt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ReportPreference> UpdateReportPreferenceAsync(
            global::System.Guid projectId,
            global::System.Guid? requestProjectId = default,
            bool? enabled = default,
            string? scheduleTime = default,
            string? customPrompt = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}