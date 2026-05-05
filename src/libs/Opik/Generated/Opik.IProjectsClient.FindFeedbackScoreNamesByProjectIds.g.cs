#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Find Feedback Score names By Project Ids<br/>
        /// Find Feedback Score names By Project Ids
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.FeedbackScoreNames> FindFeedbackScoreNamesByProjectIdsAsync(
            string? projectIds = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Feedback Score names By Project Ids<br/>
        /// Find Feedback Score names By Project Ids
        /// </summary>
        /// <param name="projectIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.FeedbackScoreNames>> FindFeedbackScoreNamesByProjectIdsAsResponseAsync(
            string? projectIds = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}