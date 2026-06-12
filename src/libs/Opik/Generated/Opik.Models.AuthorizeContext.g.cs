
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorizeContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_logo_uri")]
        public string? ClientLogoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceInfo>? Workspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csrf_token")]
        public string? CsrfToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeContext" /> class.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="clientLogoUri"></param>
        /// <param name="workspaces"></param>
        /// <param name="csrfToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorizeContext(
            string? clientName,
            string? clientLogoUri,
            global::System.Collections.Generic.IList<global::Opik.WorkspaceInfo>? workspaces,
            string? csrfToken)
        {
            this.ClientName = clientName;
            this.ClientLogoUri = clientLogoUri;
            this.Workspaces = workspaces;
            this.CsrfToken = csrfToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeContext" /> class.
        /// </summary>
        public AuthorizeContext()
        {
        }

    }
}