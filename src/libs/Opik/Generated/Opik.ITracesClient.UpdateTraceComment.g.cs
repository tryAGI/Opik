#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Update trace comment by id<br/>
        /// Update trace comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateTraceCommentAsync(
            global::System.Guid commentId,

            global::Opik.Comment request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update trace comment by id<br/>
        /// Update trace comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateTraceCommentAsync(
            global::System.Guid commentId,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}