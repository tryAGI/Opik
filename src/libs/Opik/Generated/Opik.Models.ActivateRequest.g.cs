
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunnerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hmac")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hmac { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateRequest" /> class.
        /// </summary>
        /// <param name="runnerName"></param>
        /// <param name="hmac"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivateRequest(
            string runnerName,
            string hmac)
        {
            this.RunnerName = runnerName ?? throw new global::System.ArgumentNullException(nameof(runnerName));
            this.Hmac = hmac ?? throw new global::System.ArgumentNullException(nameof(hmac));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateRequest" /> class.
        /// </summary>
        public ActivateRequest()
        {
        }
    }
}