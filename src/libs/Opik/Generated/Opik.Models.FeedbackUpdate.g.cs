
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "type",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(Opik.BooleanFeedbackDefinitionUpdate), typeDiscriminator: "boolean")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(Opik.CategoricalFeedbackDefinitionUpdate), typeDiscriminator: "categorical")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(Opik.NumericalFeedbackDefinitionUpdate), typeDiscriminator: "numerical")]
    public partial class FeedbackUpdate
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description for the feedback definition<br/>
        /// Example: This feedback definition is used to rate response quality
        /// </summary>
        /// <example>This feedback definition is used to rate response quality</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackUpdate" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="description">
        /// Optional description for the feedback definition<br/>
        /// Example: This feedback definition is used to rate response quality
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackUpdate(
            string name,
            global::System.Guid? id,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackUpdate" /> class.
        /// </summary>
        public FeedbackUpdate()
        {
        }
    }
}