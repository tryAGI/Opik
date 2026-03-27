#nullable enable

namespace Opik
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Retrieve blueprint by name<br/>
        /// Retrieves a specific blueprint by its name within a project
        /// </summary>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="maskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AgentBlueprintPublic> GetBlueprintByNameAsync(
            string name,
            global::System.Guid projectId,
            global::System.Guid? maskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}