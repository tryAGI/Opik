#nullable enable

namespace Opik
{
    public partial interface IAssistantSidebarsClient
    {
        /// <summary>
        /// Get Assistant Sidebar configuration<br/>
        /// Get CDN configuration for loading the assistant sidebar at runtime
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AssistantSidebarConfigResponse> GetAssistantSidebarConfigAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}