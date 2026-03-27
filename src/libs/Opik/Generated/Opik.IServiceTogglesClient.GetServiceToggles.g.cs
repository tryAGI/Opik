#nullable enable

namespace Opik
{
    public partial interface IServiceTogglesClient
    {
        /// <summary>
        /// Get Service Toggles<br/>
        /// Get Service Toggles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ServiceTogglesConfig> GetServiceTogglesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}