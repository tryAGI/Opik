
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageProjectsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> WorkspaceIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ProjectIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageProjectsRequest" /> class.
        /// </summary>
        /// <param name="workspaceIds"></param>
        /// <param name="projectIds"></param>
        /// <param name="name"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageProjectsRequest(
            global::System.Collections.Generic.IList<string> workspaceIds,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds,
            string? name,
            int? limit)
        {
            this.WorkspaceIds = workspaceIds ?? throw new global::System.ArgumentNullException(nameof(workspaceIds));
            this.ProjectIds = projectIds;
            this.Name = name;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageProjectsRequest" /> class.
        /// </summary>
        public UsageProjectsRequest()
        {
        }

    }
}