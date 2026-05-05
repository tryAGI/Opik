#nullable enable

namespace Opik
{
    public partial interface IInsightsViewsClient
    {
        /// <summary>
        /// Get insights view by id<br/>
        /// Get insights view by id
        /// </summary>
        /// <param name="insightsViewId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> GetInsightsViewByIdAsync(
            global::System.Guid insightsViewId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get insights view by id<br/>
        /// Get insights view by id
        /// </summary>
        /// <param name="insightsViewId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.DashboardPublic>> GetInsightsViewByIdAsResponseAsync(
            global::System.Guid insightsViewId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}