#nullable enable

namespace Opik
{
    public partial interface IRedirectClient
    {
        /// <summary>
        /// Create optimization redirect url<br/>
        /// Create optimization redirect url
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="optimizationId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="path"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task OptimizationsRedirectAsync(
            global::System.Guid datasetId,
            global::System.Guid optimizationId,
            string path,
            string? workspaceName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}