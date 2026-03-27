#nullable enable

namespace Opik
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Batch feedback scoring for threads<br/>
        /// Batch feedback scoring for threads
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfThreadsAsync(

            global::Opik.FeedbackScoreBatchThread request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch feedback scoring for threads<br/>
        /// Batch feedback scoring for threads
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfThreadsAsync(
            global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItemThread> scores,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}