#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Next local runner job<br/>
        /// Long-poll for the next pending local runner job
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.LocalRunnerJob> NextJobAsync(
            global::System.Guid runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}