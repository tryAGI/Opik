#nullable enable

namespace Opik
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset items from CSV file<br/>
        /// Create dataset items from uploaded CSV file. CSV should have headers in the first row. Processing happens asynchronously in batches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromCsvAsync(

            global::Opik.CreateDatasetItemsFromCsvRequest request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset items from CSV file<br/>
        /// Create dataset items from uploaded CSV file. CSV should have headers in the first row. Processing happens asynchronously in batches.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="datasetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateDatasetItemsFromCsvAsync(
            object file,
            global::System.Guid datasetId,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}