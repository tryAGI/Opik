#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete thread comments<br/>
        /// Delete thread comments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteThreadCommentsAsync(

            global::Opik.BatchDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete thread comments<br/>
        /// Delete thread comments
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteThreadCommentsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}