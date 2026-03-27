
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDefinitionUpdate : FeedbackUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Opik.CategoricalFeedbackDetailUpdate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdate" /> class.
        /// </summary>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoricalFeedbackDefinitionUpdate(
            global::Opik.CategoricalFeedbackDetailUpdate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionUpdate" /> class.
        /// </summary>
        public CategoricalFeedbackDefinitionUpdate()
        {
        }
    }
}