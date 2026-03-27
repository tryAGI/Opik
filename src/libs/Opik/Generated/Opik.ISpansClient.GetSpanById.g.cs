#nullable enable

namespace Opik
{
    public partial interface ISpansClient
    {
        /// <summary>
        /// Get span by id<br/>
        /// Get span by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stripAttachments">
        /// If true, returns attachment references like [file.png]; if false, downloads and reinjects attachment content from S3 (default: false for backward compatibility)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.SpanPublic> GetSpanByIdAsync(
            global::System.Guid id,
            bool? stripAttachments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}