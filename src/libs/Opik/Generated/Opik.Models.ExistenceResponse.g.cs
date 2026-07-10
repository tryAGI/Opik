
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExistenceResponse
    {
        /// <summary>
        /// Whether the project has at least one matching entity for the given scope
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exists")]
        public bool? Exists { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExistenceResponse" /> class.
        /// </summary>
        /// <param name="exists">
        /// Whether the project has at least one matching entity for the given scope
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExistenceResponse(
            bool? exists)
        {
            this.Exists = exists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExistenceResponse" /> class.
        /// </summary>
        public ExistenceResponse()
        {
        }

    }
}