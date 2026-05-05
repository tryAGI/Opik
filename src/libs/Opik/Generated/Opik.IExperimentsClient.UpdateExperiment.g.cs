#nullable enable

namespace Opik
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Update experiment by id<br/>
        /// Update experiment by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateExperimentAsync(
            global::System.Guid id,

            global::Opik.ExperimentUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update experiment by id<br/>
        /// Update experiment by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse> UpdateExperimentAsResponseAsync(
            global::System.Guid id,

            global::Opik.ExperimentUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update experiment by id<br/>
        /// Update experiment by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="tags">
        /// Tags
        /// </param>
        /// <param name="tagsToAdd">
        /// Tags to add
        /// </param>
        /// <param name="tagsToRemove">
        /// Tags to remove
        /// </param>
        /// <param name="type"></param>
        /// <param name="status">
        /// The status of the experiment
        /// </param>
        /// <param name="experimentScores"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateExperimentAsync(
            global::System.Guid id,
            string? name = default,
            global::Opik.JsonNode? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? tagsToAdd = default,
            global::System.Collections.Generic.IList<string>? tagsToRemove = default,
            global::Opik.ExperimentUpdateType? type = default,
            global::Opik.ExperimentUpdateStatus? status = default,
            global::System.Collections.Generic.IList<global::Opik.ExperimentScore>? experimentScores = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}