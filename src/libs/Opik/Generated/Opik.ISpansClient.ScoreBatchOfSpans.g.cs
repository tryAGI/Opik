#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Batch feedback scoring for spans<br/>
        /// Batch feedback scoring for spans
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfSpansAsync(

            global::Opik.FeedbackScoreBatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch feedback scoring for spans<br/>
        /// Batch feedback scoring for spans
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfSpansAsync(
            global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItem> scores,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}