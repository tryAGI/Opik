
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportCompleteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ReportCompleteRequestStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.ReportCompleteRequestStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommended_actions")]
        public global::Opik.JsonNode? RecommendedActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCompleteRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="content"></param>
        /// <param name="sessionId"></param>
        /// <param name="recommendedActions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportCompleteRequest(
            global::Opik.ReportCompleteRequestStatus status,
            string? content,
            string? sessionId,
            global::Opik.JsonNode? recommendedActions)
        {
            this.Content = content;
            this.Status = status;
            this.SessionId = sessionId;
            this.RecommendedActions = recommendedActions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCompleteRequest" /> class.
        /// </summary>
        public ReportCompleteRequest()
        {
        }

    }
}