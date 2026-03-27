#nullable enable

namespace Opik
{
    public partial interface IFeedbackDefinitionsClient
    {
        /// <summary>
        /// Get feedback definition by id<br/>
        /// Get feedback definition by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.FeedbackPublic> GetFeedbackDefinitionByIdAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}