
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationQueueItemPublic
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AnnotationQueueItemPublicSourceJsonConverter))]
        public global::Opik.AnnotationQueueItemPublicSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemPublic" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueItemPublic(
            global::System.Guid? id,
            global::Opik.AnnotationQueueItemPublicSource? source)
        {
            this.Id = id;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueItemPublic" /> class.
        /// </summary>
        public AnnotationQueueItemPublic()
        {
        }

    }
}