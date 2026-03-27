#nullable enable

namespace Opik
{
    public partial interface IAlertsClient
    {
        /// <summary>
        /// Get Alert by id<br/>
        /// Get Alert by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AlertPublic> GetAlertByIdAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}