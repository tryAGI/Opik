#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Stream a dataset's experiment items<br/>
        /// Stream the experiment items of every regular experiment on a dataset, one experiment item per line.<br/>
        /// Optimizer trial, mini-batch and mutation experiments are excluded.<br/>
        /// Rows are ordered by experiment, then dataset item. To read the next page, send the id of the last row<br/>
        /// received as last_retrieved_id; a page with fewer rows than the limit is the last one. Optionally also<br/>
        /// send its experiment_id as last_retrieved_experiment_id: it is only used if that row was deleted, to<br/>
        /// resume from the start of its experiment instead of from the start of the stream.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamDatasetExperimentItemsAsync(

            global::Opik.DatasetExperimentItemStreamRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a dataset's experiment items<br/>
        /// Stream the experiment items of every regular experiment on a dataset, one experiment item per line.<br/>
        /// Optimizer trial, mini-batch and mutation experiments are excluded.<br/>
        /// Rows are ordered by experiment, then dataset item. To read the next page, send the id of the last row<br/>
        /// received as last_retrieved_id; a page with fewer rows than the limit is the last one. Optionally also<br/>
        /// send its experiment_id as last_retrieved_experiment_id: it is only used if that row was deleted, to<br/>
        /// resume from the start of its experiment instead of from the start of the stream.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamDatasetExperimentItemsAsStreamAsync(

            global::Opik.DatasetExperimentItemStreamRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a dataset's experiment items<br/>
        /// Stream the experiment items of every regular experiment on a dataset, one experiment item per line.<br/>
        /// Optimizer trial, mini-batch and mutation experiments are excluded.<br/>
        /// Rows are ordered by experiment, then dataset item. To read the next page, send the id of the last row<br/>
        /// received as last_retrieved_id; a page with fewer rows than the limit is the last one. Optionally also<br/>
        /// send its experiment_id as last_retrieved_experiment_id: it is only used if that row was deleted, to<br/>
        /// resume from the start of its experiment instead of from the start of the stream.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::System.IO.Stream>> StreamDatasetExperimentItemsAsStreamAsResponseAsync(

            global::Opik.DatasetExperimentItemStreamRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a dataset's experiment items<br/>
        /// Stream the experiment items of every regular experiment on a dataset, one experiment item per line.<br/>
        /// Optimizer trial, mini-batch and mutation experiments are excluded.<br/>
        /// Rows are ordered by experiment, then dataset item. To read the next page, send the id of the last row<br/>
        /// received as last_retrieved_id; a page with fewer rows than the limit is the last one. Optionally also<br/>
        /// send its experiment_id as last_retrieved_experiment_id: it is only used if that row was deleted, to<br/>
        /// resume from the start of its experiment instead of from the start of the stream.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<byte[]>> StreamDatasetExperimentItemsAsResponseAsync(

            global::Opik.DatasetExperimentItemStreamRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream a dataset's experiment items<br/>
        /// Stream the experiment items of every regular experiment on a dataset, one experiment item per line.<br/>
        /// Optimizer trial, mini-batch and mutation experiments are excluded.<br/>
        /// Rows are ordered by experiment, then dataset item. To read the next page, send the id of the last row<br/>
        /// received as last_retrieved_id; a page with fewer rows than the limit is the last one. Optionally also<br/>
        /// send its experiment_id as last_retrieved_experiment_id: it is only used if that row was deleted, to<br/>
        /// resume from the start of its experiment instead of from the start of the stream.
        /// </summary>
        /// <param name="datasetId">
        /// Dataset ID. Set this or dataset_name
        /// </param>
        /// <param name="datasetName">
        /// Dataset name. Set this or dataset_id
        /// </param>
        /// <param name="projectName">
        /// Project of the dataset, used with dataset_name
        /// </param>
        /// <param name="datasetVersions">
        /// Dataset version hashes or tags, such as 'latest'. Only experiments run against one of these versions are included; omit for every version. Returns 404 if any version does not exist
        /// </param>
        /// <param name="filters">
        /// JSON array of dataset item filters, evaluated against the newest version of each item that the experiments reference
        /// </param>
        /// <param name="limit">
        /// Maximum number of experiment items to return<br/>
        /// Default Value: 2000
        /// </param>
        /// <param name="lastRetrievedExperimentId">
        /// Optional hint: experiment_id of the last experiment item received. Used only if that item was deleted, to resume from the start of its experiment instead of from the start of the stream. Requires last_retrieved_id
        /// </param>
        /// <param name="lastRetrievedId">
        /// id of the last experiment item received
        /// </param>
        /// <param name="truncate">
        /// Truncate image included in either input, output or metadata<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> StreamDatasetExperimentItemsAsync(
            global::System.Guid? datasetId = default,
            string? datasetName = default,
            string? projectName = default,
            global::System.Collections.Generic.IList<string>? datasetVersions = default,
            string? filters = default,
            int? limit = default,
            global::System.Guid? lastRetrievedExperimentId = default,
            global::System.Guid? lastRetrievedId = default,
            bool? truncate = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}