
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CodeChallenge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CodeChallengeMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csrf")]
        public string? Csrf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequest" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="redirectUri"></param>
        /// <param name="codeChallenge"></param>
        /// <param name="codeChallengeMethod"></param>
        /// <param name="resource"></param>
        /// <param name="state"></param>
        /// <param name="workspaceId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="csrf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsentRequest(
            string clientId,
            string redirectUri,
            string codeChallenge,
            string codeChallengeMethod,
            string resource,
            string? state,
            string? workspaceId,
            string? workspaceName,
            string? csrf)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.RedirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
            this.CodeChallenge = codeChallenge ?? throw new global::System.ArgumentNullException(nameof(codeChallenge));
            this.CodeChallengeMethod = codeChallengeMethod ?? throw new global::System.ArgumentNullException(nameof(codeChallengeMethod));
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.State = state;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName;
            this.Csrf = csrf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequest" /> class.
        /// </summary>
        public ConsentRequest()
        {
        }

    }
}