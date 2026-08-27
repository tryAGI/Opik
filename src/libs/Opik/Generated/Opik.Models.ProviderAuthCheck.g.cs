
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProviderAuthCheck
    {
        /// <summary>
        /// Test the stored auth config of this provider; also the sentinel-resolution target when auth_config is sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public global::System.Guid? ProviderId { get; set; }

        /// <summary>
        /// Dynamic token auth recipe. Send the '__SECRET__' sentinel as a credential value to keep the stored secret; send an empty object to clear the auth config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        public global::Opik.ProviderAuthConfig? AuthConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAuthCheck" /> class.
        /// </summary>
        /// <param name="providerId">
        /// Test the stored auth config of this provider; also the sentinel-resolution target when auth_config is sent
        /// </param>
        /// <param name="authConfig">
        /// Dynamic token auth recipe. Send the '__SECRET__' sentinel as a credential value to keep the stored secret; send an empty object to clear the auth config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderAuthCheck(
            global::System.Guid? providerId,
            global::Opik.ProviderAuthConfig? authConfig)
        {
            this.ProviderId = providerId;
            this.AuthConfig = authConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderAuthCheck" /> class.
        /// </summary>
        public ProviderAuthCheck()
        {
        }

    }
}