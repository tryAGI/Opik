#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// Register local runner agents<br/>
        /// Register or update the local runner's agent list
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task RegisterAgentsAsync(
            global::System.Guid runnerId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register local runner agents<br/>
        /// Register or update the local runner's agent list
        /// </summary>
        /// <param name="runnerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RegisterAgentsAsync(
            global::System.Guid runnerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}