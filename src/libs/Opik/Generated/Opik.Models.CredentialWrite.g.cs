
#nullable enable

namespace Opik
{
    /// <summary>
    /// Fields sent to the token URL. Values flagged as secret are write-only: they read back as the '__SECRET__' sentinel
    /// </summary>
    public sealed partial class CredentialWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Secret values are encrypted at rest and never read back; once true it cannot be unset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public bool? Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialWrite" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="secret">
        /// Secret values are encrypted at rest and never read back; once true it cannot be unset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialWrite(
            string key,
            string? value,
            bool? secret)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.Secret = secret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialWrite" /> class.
        /// </summary>
        public CredentialWrite()
        {
        }

    }
}