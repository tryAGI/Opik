#pragma warning disable CS0108 // member hides inherited member
#pragma warning disable CS8618 // non-nullable field uninitialized

#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CategoricalFeedbackDefinitionCreate : global::Opik.FeedbackCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Opik.CategoricalFeedbackDetailCreate? Details { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionCreate" /> class.
        /// </summary>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CategoricalFeedbackDefinitionCreate(
            global::Opik.CategoricalFeedbackDetailCreate? details)
        {
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoricalFeedbackDefinitionCreate" /> class.
        /// </summary>
        public CategoricalFeedbackDefinitionCreate()
        {
        }
    }
}
