#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Find dataset items with experiment items<br/>
        /// Find dataset items with experiment items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size. At most 100 when experiment_ids is omitted, since each item then carries a result per experiment<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="experimentIds">
        /// JSON array of experiment IDs. Omit to include every regular experiment on the dataset (optimizer trial, mini-batch and mutation experiments are excluded); item filters are then evaluated against the newest version of each item that those experiments reference
        /// </param>
        /// <param name="datasetVersion">
        /// Dataset version hash or tag. Only experiments run against this version are included. Requires experiment_ids to be omitted. Returns 404 if the version does not exist
        /// </param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="search"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetItemPageCompare> FindDatasetItemsWithExperimentItemsAsync(
            global::System.Guid id,
            int? page = default,
            int? size = default,
            string? experimentIds = default,
            string? datasetVersion = default,
            string? filters = default,
            string? sorting = default,
            string? search = default,
            bool? truncate = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find dataset items with experiment items<br/>
        /// Find dataset items with experiment items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size. At most 100 when experiment_ids is omitted, since each item then carries a result per experiment<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="experimentIds">
        /// JSON array of experiment IDs. Omit to include every regular experiment on the dataset (optimizer trial, mini-batch and mutation experiments are excluded); item filters are then evaluated against the newest version of each item that those experiments reference
        /// </param>
        /// <param name="datasetVersion">
        /// Dataset version hash or tag. Only experiments run against this version are included. Requires experiment_ids to be omitted. Returns 404 if the version does not exist
        /// </param>
        /// <param name="filters"></param>
        /// <param name="sorting"></param>
        /// <param name="search"></param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.DatasetItemPageCompare>> FindDatasetItemsWithExperimentItemsAsResponseAsync(
            global::System.Guid id,
            int? page = default,
            int? size = default,
            string? experimentIds = default,
            string? datasetVersion = default,
            string? filters = default,
            string? sorting = default,
            string? search = default,
            bool? truncate = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}