#nullable enable

namespace Opik
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Update environment by id<br/>
        /// Update environment by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateEnvironmentAsync(
            global::System.Guid id,

            global::Opik.EnvironmentUpdate request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update environment by id<br/>
        /// Update environment by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="color"></param>
        /// <param name="position"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateEnvironmentAsync(
            global::System.Guid id,
            string? name = default,
            string? description = default,
            string? color = default,
            int? position = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}