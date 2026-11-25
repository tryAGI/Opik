
#nullable enable

namespace Opik
{
    /// <summary>
    /// collecting only: the project's newest run when it is running or failed; omitted when it saved or there is none. The runbook's 'Reading topics' section tells the collecting cases apart
    /// </summary>
    public sealed partial class Attempt
    {
        /// <summary>
        /// running: the run started and has not ended. failed: it ended without saving
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.AttemptStatusJsonConverter))]
        public global::Opik.AttemptStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Attempt" /> class.
        /// </summary>
        /// <param name="status">
        /// running: the run started and has not ended. failed: it ended without saving
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Attempt(
            global::Opik.AttemptStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attempt" /> class.
        /// </summary>
        public Attempt()
        {
        }

    }
}