
#nullable enable

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetrainGuardrailModelRequest
    {
        /// <summary>
        /// JSON Lines in UTF-8, one {"text": "...", "label": "yes" | "no"} object per line, yes meaning the text violates. The deployment sets the limits; by default 20 to 50,000 rows, at least 5 per label, up to 12,000 characters each, 50 MB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrainGuardrailModelRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// JSON Lines in UTF-8, one {"text": "...", "label": "yes" | "no"} object per line, yes meaning the text violates. The deployment sets the limits; by default 20 to 50,000 rows, at least 5 per label, up to 12,000 characters each, 50 MB
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetrainGuardrailModelRequest(
            object file)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetrainGuardrailModelRequest" /> class.
        /// </summary>
        public RetrainGuardrailModelRequest()
        {
        }

    }
}