
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceMetricResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Opik.Result>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceMetricResponse(
            global::System.Collections.Generic.IList<global::Opik.Result>? results)
        {
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceMetricResponse" /> class.
        /// </summary>
        public WorkspaceMetricResponse()
        {
        }

    }
}