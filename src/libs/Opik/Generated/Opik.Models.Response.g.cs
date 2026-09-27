
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Response
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrolled")]
        public int? Enrolled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleared")]
        public int? Cleared { get; set; }

        /// <summary>
        /// Ids that match no project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown_project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? UnknownProjectIds { get; set; }

        /// <summary>
        /// Ids whose automatic run already happened, so enrolling has no effect
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("already_run_project_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? AlreadyRunProjectIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        /// <param name="enrolled"></param>
        /// <param name="cleared"></param>
        /// <param name="unknownProjectIds">
        /// Ids that match no project
        /// </param>
        /// <param name="alreadyRunProjectIds">
        /// Ids whose automatic run already happened, so enrolling has no effect
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response(
            int? enrolled,
            int? cleared,
            global::System.Collections.Generic.IList<global::System.Guid>? unknownProjectIds,
            global::System.Collections.Generic.IList<global::System.Guid>? alreadyRunProjectIds)
        {
            this.Enrolled = enrolled;
            this.Cleared = cleared;
            this.UnknownProjectIds = unknownProjectIds;
            this.AlreadyRunProjectIds = alreadyRunProjectIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        public Response()
        {
        }

    }
}