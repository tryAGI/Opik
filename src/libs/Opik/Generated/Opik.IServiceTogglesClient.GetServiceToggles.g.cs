#nullable enable

namespace Opik
{
    public partial interface IServiceTogglesClient
    {
        /// <summary>
        /// Get Service Toggles<br/>
        /// Get Service Toggles
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ServiceTogglesConfig> GetServiceTogglesAsync(
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}