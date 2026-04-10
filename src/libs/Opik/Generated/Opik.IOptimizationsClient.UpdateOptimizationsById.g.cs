#nullable enable

namespace Opik
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Update optimization by id<br/>
        /// Update optimization by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateOptimizationsByIdAsync(
            global::System.Guid id,

            global::Opik.OptimizationUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update optimization by id<br/>
        /// Update optimization by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateOptimizationsByIdAsync(
            global::System.Guid id,
            string? name = default,
            global::Opik.OptimizationUpdateStatus? status = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}