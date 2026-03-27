#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get thread comment<br/>
        /// Get thread comment
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Comment> GetThreadCommentAsync(
            global::System.Guid commentId,
            global::System.Guid threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}