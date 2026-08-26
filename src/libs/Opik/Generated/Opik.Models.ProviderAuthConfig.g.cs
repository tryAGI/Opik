
#nullable enable

namespace Opik
{
    /// <summary>
    /// Dynamic token auth recipe. Send the '__SECRET__' sentinel as a credential value to keep the stored secret; send an empty object to clear the auth config.
    /// </summary>
    public sealed partial class ProviderAuthConfig
    {
        /// <summary>
        /// Auth service URL the credentials are sent to<br/>
        /// Example: https://developer.api.example.com/authentication/v1/token
        /// </summary>
        /// <example>https://developer.api.example.com/authentication/v1/token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        public string? TokenUrl { get; set; }

        /// <summary>
        /// How credentials are sent: form body (default), JSON body, or basic auth (id/secret in an HTTP Basic header, remaining fields in the form body)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_as")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ProviderAuthConfigSendAsJsonConverter))]
        public global::Opik.ProviderAuthConfigSendAs? SendAs { get; set; }

        /// <summary>
        /// Fields sent to the token URL. Values flagged as secret are write-only: they read back as the '__SECRET__' sentinel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::System.Collections.Generic.IList<global::Opik.Credential>? Credentials { get; set; }

        /// <summary>
        /// Field holding the token in the reply; dot-path for nested replies<br/>
        /// Example: access_token
        /// </summary>
        /// <example>access_token</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_field")]
        public string? TokenField { get; set; }

        /// <summary>
        /// Field holding the token lifetime in seconds in the reply; dot-path for nested replies<br/>
        /// Example: expires_in
        /// </summary>
        /// <example>expires_in</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_field")]
        public string? ExpiresField { get; set; }

        /// <summary>
        /// Lifetime in seconds assumed when the reply doesn't state one, capped at one year; 0 disables caching for such replies. A reply-stated lifetime always wins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_ttl_seconds")]
        public long? FallbackTtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAuthConfig" /> class.
        /// </summary>
        /// <param name="tokenUrl">
        /// Auth service URL the credentials are sent to<br/>
        /// Example: https://developer.api.example.com/authentication/v1/token
        /// </param>
        /// <param name="sendAs">
        /// How credentials are sent: form body (default), JSON body, or basic auth (id/secret in an HTTP Basic header, remaining fields in the form body)
        /// </param>
        /// <param name="credentials">
        /// Fields sent to the token URL. Values flagged as secret are write-only: they read back as the '__SECRET__' sentinel
        /// </param>
        /// <param name="tokenField">
        /// Field holding the token in the reply; dot-path for nested replies<br/>
        /// Example: access_token
        /// </param>
        /// <param name="expiresField">
        /// Field holding the token lifetime in seconds in the reply; dot-path for nested replies<br/>
        /// Example: expires_in
        /// </param>
        /// <param name="fallbackTtlSeconds">
        /// Lifetime in seconds assumed when the reply doesn't state one, capped at one year; 0 disables caching for such replies. A reply-stated lifetime always wins
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderAuthConfig(
            string? tokenUrl,
            global::Opik.ProviderAuthConfigSendAs? sendAs,
            global::System.Collections.Generic.IList<global::Opik.Credential>? credentials,
            string? tokenField,
            string? expiresField,
            long? fallbackTtlSeconds)
        {
            this.TokenUrl = tokenUrl;
            this.SendAs = sendAs;
            this.Credentials = credentials;
            this.TokenField = tokenField;
            this.ExpiresField = expiresField;
            this.FallbackTtlSeconds = fallbackTtlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAuthConfig" /> class.
        /// </summary>
        public ProviderAuthConfig()
        {
        }

    }
}