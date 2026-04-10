#nullable enable

namespace Opik
{
    public partial interface IInsightsViewsClient
    {
        /// <summary>
        /// Update insights view<br/>
        /// Update insights view by id. Partial updates are supported - only provided fields will be updated.
        /// </summary>
        /// <param name="insightsViewId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> UpdateInsightsViewAsync(
            global::System.Guid insightsViewId,

            global::Opik.DashboardUpdatePublic request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update insights view<br/>
        /// Update insights view by id. Partial updates are supported - only provided fields will be updated.
        /// </summary>
        /// <param name="insightsViewId"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="config"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPublic> UpdateInsightsViewAsync(
            global::System.Guid insightsViewId,
            string? name = default,
            global::Opik.DashboardUpdatePublicType? type = default,
            string? description = default,
            global::Opik.JsonNodePublic? config = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}