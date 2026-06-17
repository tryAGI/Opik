#nullable enable

namespace Opik
{
    public partial interface ISystemAnalyticsQueriesClient
    {
        /// <summary>
        /// Execute Agent Insights free-form SQL<br/>
        /// Runs Ollie-generated read-only SQL bounded to the caller's workspace and the requested project. Returns 501 when the Agent Insights toggle is off.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AnalyticsQueryResponse> ExecuteAnalyticsQueryAsync(
            global::System.Guid projectId,

            global::Opik.AnalyticsQueryRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Agent Insights free-form SQL<br/>
        /// Runs Ollie-generated read-only SQL bounded to the caller's workspace and the requested project. Returns 501 when the Agent Insights toggle is off.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AnalyticsQueryResponse>> ExecuteAnalyticsQueryAsResponseAsync(
            global::System.Guid projectId,

            global::Opik.AnalyticsQueryRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Agent Insights free-form SQL<br/>
        /// Runs Ollie-generated read-only SQL bounded to the caller's workspace and the requested project. Returns 501 when the Agent Insights toggle is off.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="query">
        /// Read-only ClickHouse SQL. Must return exactly one column named `result` produced via toJSONString(...)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AnalyticsQueryResponse> ExecuteAnalyticsQueryAsync(
            global::System.Guid projectId,
            string query,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}