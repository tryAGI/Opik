
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentBlueprintWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AgentBlueprintWriteTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Opik.AgentBlueprintWriteType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Opik.AgentConfigValueWrite> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBlueprintWrite" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBlueprintWrite(
            global::Opik.AgentBlueprintWriteType type,
            global::System.Collections.Generic.IList<global::Opik.AgentConfigValueWrite> values,
            global::System.Guid? id,
            string? description)
        {
            this.Type = type;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.Id = id;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBlueprintWrite" /> class.
        /// </summary>
        public AgentBlueprintWrite()
        {
        }
    }
}