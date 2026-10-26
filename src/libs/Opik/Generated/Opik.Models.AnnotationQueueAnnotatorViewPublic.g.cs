
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationQueueAnnotatorViewPublic
    {
        /// <summary>
        /// A custom HTML view rendered in a sandboxed iframe instead of the default trace blocks or conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Version of the view kit the html was written for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kit_version")]
        public int? KitVersion { get; set; }

        /// <summary>
        /// What annotators see in the view, in one or two sentences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAnnotatorViewPublic" /> class.
        /// </summary>
        /// <param name="html">
        /// A custom HTML view rendered in a sandboxed iframe instead of the default trace blocks or conversation
        /// </param>
        /// <param name="kitVersion">
        /// Version of the view kit the html was written for
        /// </param>
        /// <param name="summary">
        /// What annotators see in the view, in one or two sentences
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueAnnotatorViewPublic(
            string? html,
            int? kitVersion,
            string? summary)
        {
            this.Html = html;
            this.KitVersion = kitVersion;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAnnotatorViewPublic" /> class.
        /// </summary>
        public AnnotationQueueAnnotatorViewPublic()
        {
        }

    }
}