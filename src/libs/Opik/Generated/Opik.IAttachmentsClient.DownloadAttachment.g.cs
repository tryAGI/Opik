#nullable enable

namespace Opik
{
    public partial interface IAttachmentsClient
    {
        /// <summary>
        /// Download attachment from MinIO<br/>
        /// Download attachment from MinIO
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="containerId"></param>
        /// <param name="entityType"></param>
        /// <param name="entityId"></param>
        /// <param name="fileName"></param>
        /// <param name="mimeType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadAttachmentAsync(
            global::System.Guid containerId,
            global::Opik.DownloadAttachmentEntityType entityType,
            global::System.Guid entityId,
            string fileName,
            string mimeType,
            string? workspaceName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}