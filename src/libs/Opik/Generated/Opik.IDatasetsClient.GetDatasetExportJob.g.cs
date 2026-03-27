#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset export job status<br/>
        /// Retrieves the current status of a dataset export job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetExportJobPublic> GetDatasetExportJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}