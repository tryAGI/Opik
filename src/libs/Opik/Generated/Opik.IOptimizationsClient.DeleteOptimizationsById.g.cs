#nullable enable

namespace Opik
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Delete optimizations by id<br/>
        /// Delete optimizations by id
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOptimizationsByIdAsync(

            global::Opik.DeleteIdsHolder request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete optimizations by id<br/>
        /// Delete optimizations by id
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteOptimizationsByIdAsync(
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}