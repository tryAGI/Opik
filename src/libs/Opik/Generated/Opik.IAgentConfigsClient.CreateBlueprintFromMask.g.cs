#nullable enable

namespace Opik
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Create blueprint from mask<br/>
        /// Creates a new blueprint by applying a mask's changes on top of the latest blueprint for the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="maskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateBlueprintFromMaskAsync(
            global::System.Guid projectId,
            global::System.Guid maskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}