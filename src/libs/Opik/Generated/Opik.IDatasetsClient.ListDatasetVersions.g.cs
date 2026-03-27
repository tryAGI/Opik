#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List dataset versions<br/>
        /// Get paginated list of versions for a dataset, ordered by creation time (newest first)
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetVersionPagePublic> ListDatasetVersionsAsync(
            global::System.Guid id,
            int? page = default,
            int? size = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}