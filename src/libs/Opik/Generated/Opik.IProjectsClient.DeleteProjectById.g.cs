#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project by id<br/>
        /// Delete project by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteProjectByIdAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}