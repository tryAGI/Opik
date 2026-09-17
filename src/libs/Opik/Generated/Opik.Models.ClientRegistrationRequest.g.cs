
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientRegistrationRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RedirectUris { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("software_id")]
        public string? SoftwareId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("software_version")]
        public string? SoftwareVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_uri")]
        public string? ClientUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationRequest" /> class.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="redirectUris"></param>
        /// <param name="logoUri"></param>
        /// <param name="softwareId"></param>
        /// <param name="softwareVersion"></param>
        /// <param name="clientUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientRegistrationRequest(
            string clientName,
            global::System.Collections.Generic.IList<string> redirectUris,
            string? logoUri,
            string? softwareId,
            string? softwareVersion,
            string? clientUri)
        {
            this.ClientName = clientName ?? throw new global::System.ArgumentNullException(nameof(clientName));
            this.RedirectUris = redirectUris ?? throw new global::System.ArgumentNullException(nameof(redirectUris));
            this.LogoUri = logoUri;
            this.SoftwareId = softwareId;
            this.SoftwareVersion = softwareVersion;
            this.ClientUri = clientUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationRequest" /> class.
        /// </summary>
        public ClientRegistrationRequest()
        {
        }

    }
}