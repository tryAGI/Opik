
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionRetrieveDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public string? Commit { get; set; }

        /// <summary>
        /// If provided, resolves to the version mapped to this environment for the prompt; mutually exclusive with commit and version_number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// If provided, resolves to the version with this sequential number (e.g. v3); mutually exclusive with commit and environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        public string? VersionNumber { get; set; }

        /// <summary>
        /// If provided, scopes the search to the specified project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionRetrieveDetail" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit"></param>
        /// <param name="environment">
        /// If provided, resolves to the version mapped to this environment for the prompt; mutually exclusive with commit and version_number
        /// </param>
        /// <param name="versionNumber">
        /// If provided, resolves to the version with this sequential number (e.g. v3); mutually exclusive with commit and environment
        /// </param>
        /// <param name="projectName">
        /// If provided, scopes the search to the specified project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionRetrieveDetail(
            string name,
            string? commit,
            string? environment,
            string? versionNumber,
            string? projectName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Commit = commit;
            this.Environment = environment;
            this.VersionNumber = versionNumber;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionRetrieveDetail" /> class.
        /// </summary>
        public PromptVersionRetrieveDetail()
        {
        }

    }
}