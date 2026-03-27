#nullable enable

namespace Opik
{
    public partial interface IOllieStateClient
    {
        /// <summary>
        /// Download ollie state<br/>
        /// Download stored ollie state file
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadOllieStateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}