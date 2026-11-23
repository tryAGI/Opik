
#nullable enable

namespace Opik
{
    /// <summary>
    /// The version to make current
    /// </summary>
    public sealed partial class ViewCurrentVersion
    {
        /// <summary>
        /// An existing version number of the view, starting at 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewCurrentVersion" /> class.
        /// </summary>
        /// <param name="version">
        /// An existing version number of the view, starting at 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewCurrentVersion(
            int version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewCurrentVersion" /> class.
        /// </summary>
        public ViewCurrentVersion()
        {
        }

    }
}