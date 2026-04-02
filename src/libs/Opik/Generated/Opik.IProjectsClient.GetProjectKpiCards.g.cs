#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project KPI Cards<br/>
        /// Gets KPI card metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.KpiCardResponse> GetProjectKpiCardsAsync(
            global::System.Guid id,

            global::Opik.KpiCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Project KPI Cards<br/>
        /// Gets KPI card metrics for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entityType"></param>
        /// <param name="filters"></param>
        /// <param name="intervalStart"></param>
        /// <param name="intervalEnd"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.KpiCardResponse> GetProjectKpiCardsAsync(
            global::System.Guid id,
            global::Opik.KpiCardRequestEntityType entityType,
            global::System.DateTime intervalStart,
            string? filters = default,
            global::System.DateTime? intervalEnd = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}