#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Get local runner<br/>
        /// Get a single local runner with its registered agents
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.LocalRunner> GetRunnerAsync(
            global::System.Guid runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}