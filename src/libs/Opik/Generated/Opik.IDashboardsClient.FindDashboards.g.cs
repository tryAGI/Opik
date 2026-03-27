#nullable enable

namespace Opik
{
    public partial interface IDashboardsClient
    {
        /// <summary>
        /// Find dashboards<br/>
        /// Find dashboards in a workspace
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter dashboards by name (partial match, case insensitive)
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DashboardPagePublic> FindDashboardsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            global::System.Guid? projectId = default,
            string? sorting = default,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}