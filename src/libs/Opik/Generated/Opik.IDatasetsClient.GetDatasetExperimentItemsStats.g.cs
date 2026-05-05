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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectStatsPublic> GetDatasetExperimentItemsStatsAsync(
            global::System.Guid id,
            string experimentIds,
            string? filters = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get experiment items stats for dataset<br/>
        /// Get experiment items stats for dataset
        /// </summary>
        /// <param name="id"></param>
        /// <param name="experimentIds"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.ProjectStatsPublic>> GetDatasetExperimentItemsStatsAsResponseAsync(
            global::System.Guid id,
            string experimentIds,
            string? filters = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}