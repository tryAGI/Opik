#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project Metrics<br/>
        /// Gets specified metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectMetricResponsePublic> GetProjectMetricsAsync(
            global::System.Guid id,

            global::Opik.ProjectMetricRequestPublic request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Project Metrics<br/>
        /// Gets specified metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="metricType"></param>
        /// <param name="interval"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="spanFilters"></param>
        /// <param name="traceFilters"></param>
        /// <param name="threadFilters"></param>
        /// <param name="breakdown"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectMetricResponsePublic> GetProjectMetricsAsync(
            global::System.Guid id,
            global::Opik.ProjectMetricRequestPublicMetricType? metricType = default,
            global::Opik.ProjectMetricRequestPublicInterval? interval = default,
            global::System.DateTime? intervalStart = default,
            global::System.DateTime? intervalEnd = default,
            global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? spanFilters = default,
            global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? traceFilters = default,
            global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>? threadFilters = default,
            global::Opik.BreakdownConfigPublic? breakdown = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}