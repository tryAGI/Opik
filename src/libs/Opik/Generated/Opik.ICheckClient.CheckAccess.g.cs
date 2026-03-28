#nullable enable

namespace Opik
{
    public partial interface ICheckClient
    {
        /// <summary>
        /// Check user access to workspace<br/>
        /// Check user access to workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CheckAccessAsync(

            global::Opik.AuthDetailsHolder request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check user access to workspace<br/>
        /// Check user access to workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CheckAccessAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}