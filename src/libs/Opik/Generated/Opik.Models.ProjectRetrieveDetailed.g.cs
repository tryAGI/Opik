
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectRetrieveDetailed
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
        [global::System.Text.Json.Serialization.JsonPropertyName("includeStats")]
        public bool? IncludeStats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRetrieveDetailed" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="includeStats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRetrieveDetailed(
            string name,
            bool? includeStats)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IncludeStats = includeStats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRetrieveDetailed" /> class.
        /// </summary>
        public ProjectRetrieveDetailed()
        {
        }

    }
}