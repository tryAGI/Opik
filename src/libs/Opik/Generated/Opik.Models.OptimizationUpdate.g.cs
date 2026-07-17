
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.OptimizationUpdateStatusJsonConverter))]
        public global::Opik.OptimizationUpdateStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.JsonListStringJsonConverter))]
        public global::Opik.JsonListString? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OptimizationUpdate(
            string? name,
            global::Opik.OptimizationUpdateStatus? status,
            global::Opik.JsonListString? metadata)
        {
            this.Name = name;
            this.Status = status;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationUpdate" /> class.
        /// </summary>
        public OptimizationUpdate()
        {
        }

    }
}