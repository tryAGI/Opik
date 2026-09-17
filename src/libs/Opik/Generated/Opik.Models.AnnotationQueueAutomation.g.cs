
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationQueueAutomation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::Opik.Conditions? Conditions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_items_in_queue")]
        public int? MaxItemsInQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAutomation" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="conditions"></param>
        /// <param name="maxItemsInQueue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueAutomation(
            bool? enabled,
            global::Opik.Conditions? conditions,
            int? maxItemsInQueue)
        {
            this.Enabled = enabled;
            this.Conditions = conditions;
            this.MaxItemsInQueue = maxItemsInQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueAutomation" /> class.
        /// </summary>
        public AnnotationQueueAutomation()
        {
        }

    }
}