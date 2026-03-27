#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get dataset item by id<br/>
        /// Get dataset item by id
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.DatasetItemPublic> GetDatasetItemByIdAsync(
            global::System.Guid itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}