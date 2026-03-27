#nullable enable

namespace Opik
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieve project<br/>
        /// Retrieve project
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectDetailed> RetrieveProjectAsync(

            global::Opik.ProjectRetrieveDetailed request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve project<br/>
        /// Retrieve project
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.ProjectDetailed> RetrieveProjectAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}