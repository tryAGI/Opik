#nullable enable

namespace Opik
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Run a saved widget query<br/>
        /// Runs the query saved on an Ollie chart widget of this dashboard over the given date range and returns its rows. The query is read from the saved widget; the request carries no SQL. Returns 501 when Ollie or Custom Charts is not enabled for the workspace.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="widgetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AnalyticsQueryResponse> RunDashboardWidgetQueryAsync(
            global::System.Guid dashboardId,
            string widgetId,

            global::Opik.DashboardWidgetQueryRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a saved widget query<br/>
        /// Runs the query saved on an Ollie chart widget of this dashboard over the given date range and returns its rows. The query is read from the saved widget; the request carries no SQL. Returns 501 when Ollie or Custom Charts is not enabled for the workspace.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="widgetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.AnalyticsQueryResponse>> RunDashboardWidgetQueryAsResponseAsync(
            global::System.Guid dashboardId,
            string widgetId,

            global::Opik.DashboardWidgetQueryRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a saved widget query<br/>
        /// Runs the query saved on an Ollie chart widget of this dashboard over the given date range and returns its rows. The query is read from the saved widget; the request carries no SQL. Returns 501 when Ollie or Custom Charts is not enabled for the workspace.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="widgetId"></param>
        /// <param name="intervalStart">
        /// Start of the date range, bound to {{window_start}} in the dashboard saved query. Omit for all time.
        /// </param>
        /// <param name="intervalEnd">
        /// End of the date range, bound to {{window_end}} in the dashboard saved query. Omit for now.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AnalyticsQueryResponse> RunDashboardWidgetQueryAsync(
            global::System.Guid dashboardId,
            string widgetId,
            global::System.DateTime? intervalStart = default,
            global::System.DateTime? intervalEnd = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}