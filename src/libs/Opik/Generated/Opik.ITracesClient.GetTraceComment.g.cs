#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get trace comment<br/>
        /// Get trace comment
        /// </summary>
        /// <param name="commentId"></param>
        /// <param name="traceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.Comment> GetTraceCommentAsync(
            global::System.Guid commentId,
            global::System.Guid traceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}