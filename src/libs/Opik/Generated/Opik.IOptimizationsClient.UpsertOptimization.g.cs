#nullable enable

namespace Opik
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Upsert optimization<br/>
        /// Upsert optimization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpsertOptimizationAsync(

            global::Opik.OptimizationWrite request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert optimization<br/>
        /// Upsert optimization
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="datasetName"></param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="objectiveName"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
        /// <param name="studioConfig"></param>
        /// <param name="lastUpdatedAt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpsertOptimizationAsync(
            string datasetName,
            string objectiveName,
            global::Opik.OptimizationWriteStatus status,
            global::System.Guid? id = default,
            string? name = default,
            string? projectName = default,
            global::System.Guid? projectId = default,
            global::Opik.JsonListStringWrite? metadata = default,
            global::Opik.OptimizationStudioConfigWrite? studioConfig = default,
            global::System.DateTime? lastUpdatedAt = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}