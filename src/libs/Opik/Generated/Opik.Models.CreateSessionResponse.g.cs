
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        public global::System.Guid? RunnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="runnerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionResponse(
            global::System.Guid? sessionId,
            global::System.Guid? runnerId)
        {
            this.SessionId = sessionId;
            this.RunnerId = runnerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionResponse" /> class.
        /// </summary>
        public CreateSessionResponse()
        {
        }
    }
}