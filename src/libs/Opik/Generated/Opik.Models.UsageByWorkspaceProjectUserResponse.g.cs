
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageByWorkspaceProjectUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceProjectUserCount>? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageByWorkspaceProjectUserResponse" /> class.
        /// </summary>
        /// <param name="breakdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageByWorkspaceProjectUserResponse(
            global::System.Collections.Generic.IList<global::Opik.WorkspaceProjectUserCount>? breakdown)
        {
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageByWorkspaceProjectUserResponse" /> class.
        /// </summary>
        public UsageByWorkspaceProjectUserResponse()
        {
        }

    }
}