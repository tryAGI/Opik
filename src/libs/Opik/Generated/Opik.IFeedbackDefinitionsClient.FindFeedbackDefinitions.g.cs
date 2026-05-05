#nullable enable

namespace Opik
{
    public partial interface IFeedbackDefinitionsClient
    {
        /// <summary>
        /// Find Feedback definitions<br/>
        /// Find Feedback definitions
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter feedback definitions by name (partial match, case insensitive)
        /// </param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.FeedbackDefinitionPagePublic> FindFeedbackDefinitionsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            global::Opik.FindFeedbackDefinitionsType? type = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Find Feedback definitions<br/>
        /// Find Feedback definitions
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter feedback definitions by name (partial match, case insensitive)
        /// </param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutoSDKHttpResponse<global::Opik.FeedbackDefinitionPagePublic>> FindFeedbackDefinitionsAsResponseAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            global::Opik.FindFeedbackDefinitionsType? type = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}