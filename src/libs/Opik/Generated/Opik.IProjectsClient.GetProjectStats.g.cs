#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project Stats<br/>
        /// Get Project Stats
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter projects by name (partial match, case insensitive)
        /// </param>
        /// <param name="filters"></param>
        /// <param name="fromTime">
        /// When set, scope the project metrics from this time (ISO-8601 format); omitted keeps the all-time aggregates
        /// </param>
        /// <param name="toTime">
        /// Scope the project metrics up to this time (ISO-8601 format). Must be after 'from_time'.
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectStatsSummary> GetProjectStatsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? filters = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            string? sorting = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Project Stats<br/>
        /// Get Project Stats
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter projects by name (partial match, case insensitive)
        /// </param>
        /// <param name="filters"></param>
        /// <param name="fromTime">
        /// When set, scope the project metrics from this time (ISO-8601 format); omitted keeps the all-time aggregates
        /// </param>
        /// <param name="toTime">
        /// Scope the project metrics up to this time (ISO-8601 format). Must be after 'from_time'.
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ProjectStatsSummary>> GetProjectStatsAsResponseAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? filters = default,
            global::System.DateTime? fromTime = default,
            global::System.DateTime? toTime = default,
            string? sorting = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}