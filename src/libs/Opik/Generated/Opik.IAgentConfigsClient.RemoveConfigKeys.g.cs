#nullable enable

namespace Opik
{
    public partial interface IAgentConfigsClient
    {
        /// <summary>
        /// Remove configuration parameters<br/>
        /// Removes configuration parameters by creating a new blueprint that closes the specified keys. Returns 204 if no changes were needed (idempotent).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveConfigKeysAsync(

            global::Opik.AgentConfigRemoveValues request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove configuration parameters<br/>
        /// Removes configuration parameters by creating a new blueprint that closes the specified keys. Returns 204 if no changes were needed (idempotent).
        /// </summary>
        /// <param name="projectId">
        /// Project ID. Either project_id or project_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Project name. Either project_id or project_name must be provided
        /// </param>
        /// <param name="keys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RemoveConfigKeysAsync(
            global::System.Collections.Generic.IList<string> keys,
            global::System.Guid? projectId = default,
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}