#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Delete span by id<br/>
        /// Delete span by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSpanByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}