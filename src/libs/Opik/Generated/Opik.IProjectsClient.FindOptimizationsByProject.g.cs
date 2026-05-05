#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find optimizations by project<br/>
        /// Find optimizations scoped to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="name">
        /// Filter optimizations by name (partial match, case insensitive)
        /// </param>
        /// <param name="datasetDeleted"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.OptimizationPagePublic> FindOptimizationsByProjectAsync(
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::System.Guid? datasetId = default,
            string? datasetName = default,
            string? name = default,
            bool? datasetDeleted = default,
            string? filters = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find optimizations by project<br/>
        /// Find optimizations scoped to a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="name">
        /// Filter optimizations by name (partial match, case insensitive)
        /// </param>
        /// <param name="datasetDeleted"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.OptimizationPagePublic>> FindOptimizationsByProjectAsResponseAsync(
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::System.Guid? datasetId = default,
            string? datasetName = default,
            string? name = default,
            bool? datasetDeleted = default,
            string? filters = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}