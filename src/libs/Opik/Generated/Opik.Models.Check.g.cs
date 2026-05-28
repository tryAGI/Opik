
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Check
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.CheckNameJsonConverter))]
        public global::Opik.CheckName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.CheckResultJsonConverter))]
        public global::Opik.CheckResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Check" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Check(
            global::Opik.CheckName? name,
            global::Opik.CheckResult? result)
        {
            this.Name = name;
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Check" /> class.
        /// </summary>
        public Check()
        {
        }

    }
}