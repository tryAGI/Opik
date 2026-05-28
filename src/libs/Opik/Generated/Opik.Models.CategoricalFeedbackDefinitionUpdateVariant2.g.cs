
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDefinitionUpdateVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Opik.CategoricalFeedbackDetailUpdate? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdateVariant2" /> class.
        /// </summary>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoricalFeedbackDefinitionUpdateVariant2(
            global::Opik.CategoricalFeedbackDetailUpdate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdateVariant2" /> class.
        /// </summary>
        public CategoricalFeedbackDefinitionUpdateVariant2()
        {
        }

    }
}