#nullable enable

namespace Opik
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Retrieve blueprint by ID<br/>
        /// Retrieves a specific blueprint by its ID
        /// </summary>
        /// <param name="blueprintId"></param>
        /// <param name="maskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentBlueprintPublic> GetBlueprintByIdAsync(
            global::System.Guid blueprintId,
            global::System.Guid? maskId = default,
            global::Opik.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}