#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Cancel local runner job<br/>
        /// Cancel a pending or running local runner job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelJobAsync(
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}