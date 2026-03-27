#nullable enable

namespace Opik
{
    public partial interface IRunnersClient
    {
        /// <summary>
        /// List local runners<br/>
        /// List local runners owned by the current user in the workspace
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 25
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.LocalRunnerPage> ListRunnersAsync(
            global::System.Guid projectId,
            int? page = default,
            int? size = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}