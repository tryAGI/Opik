
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BiInformationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bi_information")]
        public global::System.Collections.Generic.IList<global::Opik.BiInformation>? BiInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BiInformationResponse" /> class.
        /// </summary>
        /// <param name="biInformation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BiInformationResponse(
            global::System.Collections.Generic.IList<global::Opik.BiInformation>? biInformation)
        {
            this.BiInformation = biInformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BiInformationResponse" /> class.
        /// </summary>
        public BiInformationResponse()
        {
        }
    }
}