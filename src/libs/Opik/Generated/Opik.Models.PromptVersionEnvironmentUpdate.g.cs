
#nullable enable

namespace Opik
{
    /// <summary>
    /// Replace the full set of environments assigned to a prompt version.<br/>
    /// The provided set becomes the new complete set of environments for this version.<br/>
    /// - Non-empty set: assigns each environment to this version; if another version of the same prompt currently owns any of those environments, ownership is moved atomically.<br/>
    /// - Empty set: clears all environments from this version.<br/>
    /// All environments must already exist in the workspace registry; unknown names return 404.
    /// </summary>
    public sealed partial class PromptVersionEnvironmentUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionEnvironmentUpdate" /> class.
        /// </summary>
        /// <param name="environments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionEnvironmentUpdate(
            global::System.Collections.Generic.IList<string> environments)
        {
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionEnvironmentUpdate" /> class.
        /// </summary>
        public PromptVersionEnvironmentUpdate()
        {
        }

    }
}