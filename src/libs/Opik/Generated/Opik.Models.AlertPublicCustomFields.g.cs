
#nullable enable

namespace Opik
{
    /// <summary>
    /// Optional user-defined key/value pairs, added as top-level keys of the alert's EventBridge event detail. Keys must not collide with the event's own keys.
    /// </summary>
    public sealed partial class AlertPublicCustomFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}