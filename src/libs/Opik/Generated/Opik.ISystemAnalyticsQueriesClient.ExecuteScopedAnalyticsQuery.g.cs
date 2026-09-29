#nullable enable

namespace Opik
{
    public partial interface ISystemAnalyticsQueriesClient
    {
        /// <summary>
        /// Execute free-form analytics SQL<br/>
        /// Runs read-only SQL bounded to the caller's workspace. Supply project_id to restrict traces, spans, feedback scores and trace threads to one project, or omit it to cover the whole workspace. Experiments, experiment items and dataset items always cover the whole workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AnalyticsQueryResponse> ExecuteScopedAnalyticsQueryAsync(

            global::Opik.ScopedAnalyticsQueryRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute free-form analytics SQL<br/>
        /// Runs read-only SQL bounded to the caller's workspace. Supply project_id to restrict traces, spans, feedback scores and trace threads to one project, or omit it to cover the whole workspace. Experiments, experiment items and dataset items always cover the whole workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AnalyticsQueryResponse>> ExecuteScopedAnalyticsQueryAsResponseAsync(

            global::Opik.ScopedAnalyticsQueryRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute free-form analytics SQL<br/>
        /// Runs read-only SQL bounded to the caller's workspace. Supply project_id to restrict traces, spans, feedback scores and trace threads to one project, or omit it to cover the whole workspace. Experiments, experiment items and dataset items always cover the whole workspace.
        /// </summary>
        /// <param name="query">
        /// Read-only ClickHouse SQL. Must return exactly one column named `result` produced via toJSONString(...)
        /// </param>
        /// <param name="projectId">
        /// Restrict query to this project. Omit to query the whole workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AnalyticsQueryResponse> ExecuteScopedAnalyticsQueryAsync(
            string query,
            global::System.Guid? projectId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}