
#nullable enable

namespace Opik
{
    /// <summary>
    /// A data source of a view; the host resolves it and passes the result under the input name
    /// </summary>
    public sealed partial class ViewInput
    {
        /// <summary>
        /// Source type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Opik.JsonConverters.ViewInputKindJsonConverter))]
        public global::Opik.ViewInputKind Kind { get; set; }

        /// <summary>
        /// The saved query to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueryId { get; set; }

        /// <summary>
        /// The columns the author saw when it ran the query, name to type. Informational
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.Dictionary<string, string>? Columns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewInput" /> class.
        /// </summary>
        /// <param name="queryId">
        /// The saved query to run
        /// </param>
        /// <param name="kind">
        /// Source type
        /// </param>
        /// <param name="columns">
        /// The columns the author saw when it ran the query, name to type. Informational
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ViewInput(
            string queryId,
            global::Opik.ViewInputKind kind,
            global::System.Collections.Generic.Dictionary<string, string>? columns)
        {
            this.Kind = kind;
            this.QueryId = queryId ?? throw new global::System.ArgumentNullException(nameof(queryId));
            this.Columns = columns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewInput" /> class.
        /// </summary>
        public ViewInput()
        {
        }

    }
}