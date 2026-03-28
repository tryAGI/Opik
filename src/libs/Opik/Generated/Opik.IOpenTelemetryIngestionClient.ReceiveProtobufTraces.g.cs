#nullable enable

namespace Opik
{
    public partial interface IOpenTelemetryIngestionClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task ReceiveProtobufTracesAsync(

            global::Opik.JsonNode request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReceiveProtobufTracesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}