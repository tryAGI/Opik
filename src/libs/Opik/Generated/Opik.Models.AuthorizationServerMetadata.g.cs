
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorizationServerMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        public string? TokenEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revocation_endpoint")]
        public string? RevocationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_endpoint")]
        public string? RegistrationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_types_supported")]
        public global::System.Collections.Generic.IList<string>? ResponseTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types_supported")]
        public global::System.Collections.Generic.IList<string>? GrantTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_methods_supported")]
        public global::System.Collections.Generic.IList<string>? CodeChallengeMethodsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_methods_supported")]
        public global::System.Collections.Generic.IList<string>? TokenEndpointAuthMethodsSupported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationServerMetadata" /> class.
        /// </summary>
        /// <param name="issuer"></param>
        /// <param name="authorizationEndpoint"></param>
        /// <param name="tokenEndpoint"></param>
        /// <param name="revocationEndpoint"></param>
        /// <param name="registrationEndpoint"></param>
        /// <param name="responseTypesSupported"></param>
        /// <param name="grantTypesSupported"></param>
        /// <param name="codeChallengeMethodsSupported"></param>
        /// <param name="tokenEndpointAuthMethodsSupported"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorizationServerMetadata(
            string? issuer,
            string? authorizationEndpoint,
            string? tokenEndpoint,
            string? revocationEndpoint,
            string? registrationEndpoint,
            global::System.Collections.Generic.IList<string>? responseTypesSupported,
            global::System.Collections.Generic.IList<string>? grantTypesSupported,
            global::System.Collections.Generic.IList<string>? codeChallengeMethodsSupported,
            global::System.Collections.Generic.IList<string>? tokenEndpointAuthMethodsSupported)
        {
            this.Issuer = issuer;
            this.AuthorizationEndpoint = authorizationEndpoint;
            this.TokenEndpoint = tokenEndpoint;
            this.RevocationEndpoint = revocationEndpoint;
            this.RegistrationEndpoint = registrationEndpoint;
            this.ResponseTypesSupported = responseTypesSupported;
            this.GrantTypesSupported = grantTypesSupported;
            this.CodeChallengeMethodsSupported = codeChallengeMethodsSupported;
            this.TokenEndpointAuthMethodsSupported = tokenEndpointAuthMethodsSupported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationServerMetadata" /> class.
        /// </summary>
        public AuthorizationServerMetadata()
        {
        }

    }
}