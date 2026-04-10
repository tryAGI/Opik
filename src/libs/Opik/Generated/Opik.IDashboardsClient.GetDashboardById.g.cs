#nullable enable

namespace Opik
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Get dashboard by id<br/>
        /// Get dashboard by id
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> GetDashboardByIdAsync(
            global::System.Guid dashboardId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}