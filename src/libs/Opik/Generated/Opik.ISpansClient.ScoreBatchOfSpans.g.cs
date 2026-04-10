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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfSpansAsync(

            global::Opik.FeedbackScoreBatch request,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Batch feedback scoring for spans<br/>
        /// Batch feedback scoring for spans
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ScoreBatchOfSpansAsync(
            global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItem> scores,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}