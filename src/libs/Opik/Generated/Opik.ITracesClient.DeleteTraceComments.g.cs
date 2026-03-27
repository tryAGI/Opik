#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Delete trace comments<br/>
        /// Delete trace comments
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceCommentsAsync(

            global::Opik.BatchDelete request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete trace comments<br/>
        /// Delete trace comments
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteTraceCommentsAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}