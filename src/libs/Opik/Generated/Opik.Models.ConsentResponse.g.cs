
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_to")]
        public string? RedirectTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentResponse" /> class.
        /// </summary>
        /// <param name="redirectTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsentResponse(
            string? redirectTo)
        {
            this.RedirectTo = redirectTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentResponse" /> class.
        /// </summary>
        public ConsentResponse()
        {
        }

    }
}