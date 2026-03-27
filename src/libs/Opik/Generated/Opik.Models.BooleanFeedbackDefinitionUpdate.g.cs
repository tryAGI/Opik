
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BooleanFeedbackDefinitionUpdate : FeedbackUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Opik.BooleanFeedbackDetailUpdate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionUpdate" /> class.
        /// </summary>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BooleanFeedbackDefinitionUpdate(
            global::Opik.BooleanFeedbackDetailUpdate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanFeedbackDefinitionUpdate" /> class.
        /// </summary>
        public BooleanFeedbackDefinitionUpdate()
        {
        }
    }
}