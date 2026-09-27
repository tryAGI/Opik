#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsEnrollmentClient
    {
        /// <summary>
        /// Enrol projects in the auto-first-run rollout<br/>
        /// Enrols the given projects, creating their job row if needed, or clears their enrolment. Idempotent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Response> EnrolProjectsInAutoFirstRunAsync(

            global::Opik.Request request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enrol projects in the auto-first-run rollout<br/>
        /// Enrols the given projects, creating their job row if needed, or clears their enrolment. Idempotent.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.Response>> EnrolProjectsInAutoFirstRunAsResponseAsync(

            global::Opik.Request request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enrol projects in the auto-first-run rollout<br/>
        /// Enrols the given projects, creating their job row if needed, or clears their enrolment. Idempotent.
        /// </summary>
        /// <param name="enrolled">
        /// True enrols the given projects, false clears their enrolment
        /// </param>
        /// <param name="projectIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Response> EnrolProjectsInAutoFirstRunAsync(
            bool enrolled,
            global::System.Collections.Generic.IList<global::System.Guid> projectIds,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}