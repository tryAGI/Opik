#nullable enable

namespace Opik
{
    public partial interface IDashboardSavedQueriesClient
    {
        /// <summary>
        /// Save a chart query<br/>
        /// Saves the query of an Ollie chart so a dashboard widget can reference it by id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardSavedQuery> CreateDashboardSavedQueryAsync(

            global::Opik.DashboardSavedQuery request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save a chart query<br/>
        /// Saves the query of an Ollie chart so a dashboard widget can reference it by id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.DashboardSavedQuery>> CreateDashboardSavedQueryAsResponseAsync(

            global::Opik.DashboardSavedQuery request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save a chart query<br/>
        /// Saves the query of an Ollie chart so a dashboard widget can reference it by id.
        /// </summary>
        /// <param name="projectId">
        /// Project the query is bounded to. Omit for every project in the workspace.
        /// </param>
        /// <param name="sql"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardSavedQuery> CreateDashboardSavedQueryAsync(
            string sql,
            global::System.Guid? projectId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}