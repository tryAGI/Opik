
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientRegistrationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id_issued_at")]
        public long? ClientIdIssuedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_method")]
        public string? TokenEndpointAuthMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types")]
        public global::System.Collections.Generic.IList<string>? GrantTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_types")]
        public global::System.Collections.Generic.IList<string>? ResponseTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationResponse" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientIdIssuedAt"></param>
        /// <param name="clientName"></param>
        /// <param name="logoUri"></param>
        /// <param name="redirectUris"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="grantTypes"></param>
        /// <param name="responseTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientRegistrationResponse(
            string? clientId,
            long? clientIdIssuedAt,
            string? clientName,
            string? logoUri,
            global::System.Collections.Generic.IList<string>? redirectUris,
            string? tokenEndpointAuthMethod,
            global::System.Collections.Generic.IList<string>? grantTypes,
            global::System.Collections.Generic.IList<string>? responseTypes)
        {
            this.ClientId = clientId;
            this.ClientIdIssuedAt = clientIdIssuedAt;
            this.ClientName = clientName;
            this.LogoUri = logoUri;
            this.RedirectUris = redirectUris;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
            this.GrantTypes = grantTypes;
            this.ResponseTypes = responseTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationResponse" /> class.
        /// </summary>
        public ClientRegistrationResponse()
        {
        }

    }
}