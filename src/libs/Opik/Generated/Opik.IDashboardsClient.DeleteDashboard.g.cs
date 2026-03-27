#nullable enable

namespace Opik
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Delete dashboard<br/>
        /// Delete dashboard by id
        /// </summary>
        /// <param name="dashboardId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDashboardAsync(
            global::System.Guid dashboardId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}