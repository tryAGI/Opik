
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ViewUpdate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Omit to keep the description; an empty or blank string clears it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description">
        /// Omit to keep the description; an empty or blank string clears it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewUpdate(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewUpdate" /> class.
        /// </summary>
        public ViewUpdate()
        {
        }

    }
}