#nullable enable

namespace Opik
{
    public partial interface IOpikClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task VersionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}