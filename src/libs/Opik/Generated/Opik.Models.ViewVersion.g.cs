
#nullable enable

namespace Opik
{
    /// <summary>
    /// An immutable version of a view
    /// </summary>
    public sealed partial class ViewVersion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_id")]
        public global::System.Guid? ViewId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ViewVersionAuthorJsonConverter))]
        public global::Opik.ViewVersionAuthor? Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ViewVersionTypeJsonConverter))]
        public global::Opik.ViewVersionType? Type { get; set; }

        /// <summary>
        /// HTML contract version the view was written against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_version")]
        public int? EngineVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ViewInput>? Inputs { get; set; }

        /// <summary>
        /// Libraries the host loads before the view runs; omitted when it uses none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("libraries")]
        public global::System.Collections.Generic.IList<string>? Libraries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

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
        /// Initializes a new instance of the <see cref="ViewVersion" /> class.
        /// </summary>
        /// <param name="viewId"></param>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <param name="engineVersion">
        /// HTML contract version the view was written against
        /// </param>
        /// <param name="inputs"></param>
        /// <param name="libraries">
        /// Libraries the host loads before the view runs; omitted when it uses none
        /// </param>
        /// <param name="html"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewVersion(
            global::System.Guid? viewId,
            int? version,
            global::Opik.ViewVersionAuthor? author,
            string? summary,
            global::Opik.ViewVersionType? type,
            int? engineVersion,
            global::System.Collections.Generic.Dictionary<string, global::Opik.ViewInput>? inputs,
            global::System.Collections.Generic.IList<string>? libraries,
            string? html,
            global::System.DateTime? createdAt,
            string? createdBy)
        {
            this.ViewId = viewId;
            this.Version = version;
            this.Author = author;
            this.Summary = summary;
            this.Type = type;
            this.EngineVersion = engineVersion;
            this.Inputs = inputs;
            this.Libraries = libraries;
            this.Html = html;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVersion" /> class.
        /// </summary>
        public ViewVersion()
        {
        }

    }
}