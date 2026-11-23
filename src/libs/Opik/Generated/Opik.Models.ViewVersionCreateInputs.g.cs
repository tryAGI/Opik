
#nullable enable

namespace Opik
{
    /// <summary>
    /// Input name to data source, one or several; the view receives one data object with a key per input
    /// </summary>
    public sealed partial class ViewVersionCreateInputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}