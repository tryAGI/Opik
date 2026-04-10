#nullable enable

namespace Opik
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Create and execute experiment<br/>
        /// Creates experiments for each prompt variant and asynchronously processes all dataset items
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ExperimentExecutionResponse> ExecuteExperimentAsync(

            global::Opik.ExperimentExecutionRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create and execute experiment<br/>
        /// Creates experiments for each prompt variant and asynchronously processes all dataset items
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="datasetVersionId"></param>
        /// <param name="prompts"></param>
        /// <param name="projectName"></param>
        /// <param name="datasetId"></param>
        /// <param name="versionHash"></param>
        /// <param name="promptVersions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ExperimentExecutionResponse> ExecuteExperimentAsync(
            string datasetName,
            global::System.Collections.Generic.IList<global::Opik.PromptVariant> prompts,
            global::System.Guid datasetId,
            global::System.Guid? datasetVersionId = default,
            string? projectName = default,
            string? versionHash = default,
            global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>? promptVersions = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}