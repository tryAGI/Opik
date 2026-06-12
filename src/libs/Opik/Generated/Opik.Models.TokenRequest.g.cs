
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string? GrantType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        /// <param name="grantType"></param>
        /// <param name="code"></param>
        /// <param name="redirectUri"></param>
        /// <param name="clientId"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="refreshToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenRequest(
            string? grantType,
            string? code,
            string? redirectUri,
            string? clientId,
            string? codeVerifier,
            string? refreshToken)
        {
            this.GrantType = grantType;
            this.Code = code;
            this.RedirectUri = redirectUri;
            this.ClientId = clientId;
            this.CodeVerifier = codeVerifier;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenRequest" /> class.
        /// </summary>
        public TokenRequest()
        {
        }

    }
}