
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigRemoveValues
    {
        /// <summary>
        /// Project ID. Either project_id or project_name must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Project name. Either project_id or project_name must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigRemoveValues" /> class.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="projectId">
        /// Project ID. Either project_id or project_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Project name. Either project_id or project_name must be provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigRemoveValues(
            global::System.Collections.Generic.IList<string> keys,
            global::System.Guid? projectId,
            string? projectName)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Keys = keys ?? throw new global::System.ArgumentNullException(nameof(keys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigRemoveValues" /> class.
        /// </summary>
        public AgentConfigRemoveValues()
        {
        }
    }
}