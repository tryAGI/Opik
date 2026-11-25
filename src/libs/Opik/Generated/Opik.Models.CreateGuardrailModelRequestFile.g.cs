
#nullable enable

namespace Opik
{
    /// <summary>
    /// JSON Lines in UTF-8, one {"text": "...", "label": "yes" | "no"} object per line, yes meaning the text violates. The deployment sets the limits; by default 20 to 50,000 rows, at least 5 per label, up to 12,000 characters each, 50 MB
    /// </summary>
    public sealed partial class CreateGuardrailModelRequestFile
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}