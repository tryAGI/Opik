
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ViewVersionCreate
    {
        /// <summary>
        /// What changed, one line
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Who produced the version: user (default), ollie or agent. Informational only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ViewVersionCreateAuthorJsonConverter))]
        public global::Opik.ViewVersionCreateAuthor? Author { get; set; }

        /// <summary>
        /// View type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ViewVersionCreateTypeJsonConverter))]
        public global::Opik.ViewVersionCreateType Type { get; set; }

        /// <summary>
        /// HTML contract version the view was written against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EngineVersion { get; set; }

        /// <summary>
        /// Libraries the host loads before the view runs; none when omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("libraries")]
        public global::System.Collections.Generic.IList<string>? Libraries { get; set; }

        /// <summary>
        /// Input name to data source, one or several; the view receives one data object with a key per input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Opik.ViewInput> Inputs { get; set; }

        /// <summary>
        /// The view: HTML, CSS and script rendered in a sandboxed iframe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVersionCreate" /> class.
        /// </summary>
        /// <param name="engineVersion">
        /// HTML contract version the view was written against
        /// </param>
        /// <param name="inputs">
        /// Input name to data source, one or several; the view receives one data object with a key per input
        /// </param>
        /// <param name="html">
        /// The view: HTML, CSS and script rendered in a sandboxed iframe
        /// </param>
        /// <param name="summary">
        /// What changed, one line
        /// </param>
        /// <param name="author">
        /// Who produced the version: user (default), ollie or agent. Informational only
        /// </param>
        /// <param name="type">
        /// View type
        /// </param>
        /// <param name="libraries">
        /// Libraries the host loads before the view runs; none when omitted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewVersionCreate(
            int engineVersion,
            global::System.Collections.Generic.Dictionary<string, global::Opik.ViewInput> inputs,
            string html,
            string? summary,
            global::Opik.ViewVersionCreateAuthor? author,
            global::Opik.ViewVersionCreateType type,
            global::System.Collections.Generic.IList<string>? libraries)
        {
            this.Summary = summary;
            this.Author = author;
            this.Type = type;
            this.EngineVersion = engineVersion;
            this.Libraries = libraries;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewVersionCreate" /> class.
        /// </summary>
        public ViewVersionCreate()
        {
        }

    }
}