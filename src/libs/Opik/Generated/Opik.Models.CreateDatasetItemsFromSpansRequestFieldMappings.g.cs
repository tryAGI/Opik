
#nullable enable

namespace Opik
{
    /// <summary>
    /// Optional mapping of dataset item field name to a path into the span, e.g. 'input.input_text'. Takes precedence over the fields produced by enrichment_options. Ignored for test suite datasets.
    /// </summary>
    public sealed partial class CreateDatasetItemsFromSpansRequestFieldMappings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}