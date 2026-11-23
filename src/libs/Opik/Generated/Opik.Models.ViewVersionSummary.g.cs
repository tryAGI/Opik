
#nullable enable

namespace Opik
{
    /// <summary>
    /// A version of a view without its HTML
    /// </summary>
    public sealed partial class ViewVersionSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ViewVersionSummaryAuthorJsonConverter))]
        public global::Opik.ViewVersionSummaryAuthor? Author { get; set; }

        /// <summary>
        /// Change summary; omitted when the author gave none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVersionSummary" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <param name="summary">
        /// Change summary; omitted when the author gave none
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewVersionSummary(
            int? version,
            global::Opik.ViewVersionSummaryAuthor? author,
            string? summary,
            global::System.DateTime? createdAt,
            string? createdBy)
        {
            this.Version = version;
            this.Author = author;
            this.Summary = summary;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVersionSummary" /> class.
        /// </summary>
        public ViewVersionSummary()
        {
        }

    }
}