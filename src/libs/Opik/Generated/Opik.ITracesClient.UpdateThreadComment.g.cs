#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Update thread comment by id<br/>
        /// Update thread comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateThreadCommentAsync(
            global::System.Guid commentId,

            global::Opik.Comment request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update thread comment by id<br/>
        /// Update thread comment by id
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateThreadCommentAsync(
            global::System.Guid commentId,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}