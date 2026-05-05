#nullable enable

namespace Opik
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Update dashboard<br/>
        /// Update dashboard by id. Partial updates are supported - only provided fields will be updated.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> UpdateDashboardAsync(
            global::System.Guid dashboardId,

            global::Opik.DashboardUpdatePublic request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dashboard<br/>
        /// Update dashboard by id. Partial updates are supported - only provided fields will be updated.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.DashboardPublic>> UpdateDashboardAsResponseAsync(
            global::System.Guid dashboardId,

            global::Opik.DashboardUpdatePublic request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update dashboard<br/>
        /// Update dashboard by id. Partial updates are supported - only provided fields will be updated.
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> UpdateDashboardAsync(
            global::System.Guid dashboardId,
            string? name = default,
            global::Opik.DashboardUpdatePublicType? type = default,
            string? description = default,
            global::Opik.JsonNodePublic? config = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}