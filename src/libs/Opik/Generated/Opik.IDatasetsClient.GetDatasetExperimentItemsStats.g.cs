#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get experiment items stats for dataset<br/>
        /// Get experiment items stats for dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="experimentIds"></param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectStatsPublic> GetDatasetExperimentItemsStatsAsync(
            global::System.Guid id,
            string experimentIds,
            string? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}