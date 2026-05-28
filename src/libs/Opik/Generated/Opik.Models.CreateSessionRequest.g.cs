
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSessionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activation_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActivationKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.CreateSessionRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.CreateSessionRequestType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="activationKey"></param>
        /// <param name="type"></param>
        /// <param name="ttlSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSessionRequest(
            global::System.Guid projectId,
            string activationKey,
            global::Opik.CreateSessionRequestType type,
            int? ttlSeconds)
        {
            this.ProjectId = projectId;
            this.ActivationKey = activationKey ?? throw new global::System.ArgumentNullException(nameof(activationKey));
            this.TtlSeconds = ttlSeconds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSessionRequest" /> class.
        /// </summary>
        public CreateSessionRequest()
        {
        }

    }
}