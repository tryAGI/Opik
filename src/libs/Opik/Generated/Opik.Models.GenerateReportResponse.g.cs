
#nullable enable

namespace Opik
{
    /// <summary>
    /// Response for report generation trigger
    /// </summary>
    public sealed partial class GenerateReportResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reportId")]
        public global::System.Guid? ReportId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateReportResponse" /> class.
        /// </summary>
        /// <param name="reportId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateReportResponse(
            global::System.Guid? reportId)
        {
            this.ReportId = reportId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateReportResponse" /> class.
        /// </summary>
        public GenerateReportResponse()
        {
        }

    }
}