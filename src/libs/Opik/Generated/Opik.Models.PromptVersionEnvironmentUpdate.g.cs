
#nullable enable

namespace Opik
{
    /// <summary>
    /// Set or clear the environment owned by a prompt version.<br/>
    /// - non-null name: maps the environment to this version; if another version of the same prompt currently owns the environment, ownership is moved atomically.<br/>
    /// - null: clears the environment from this version.<br/>
    /// The environment must already exist in the workspace registry; unknown names return 404.
    /// </summary>
    public sealed partial class PromptVersionEnvironmentUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionEnvironmentUpdate" /> class.
        /// </summary>
        /// <param name="environment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionEnvironmentUpdate(
            string? environment)
        {
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionEnvironmentUpdate" /> class.
        /// </summary>
        public PromptVersionEnvironmentUpdate()
        {
        }

    }
}