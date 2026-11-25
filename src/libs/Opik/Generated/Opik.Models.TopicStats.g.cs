
#nullable enable

namespace Opik
{
    /// <summary>
    /// The live topics in rank order; empty unless ready
    /// </summary>
    public sealed partial class TopicStats
    {
        /// <summary>
        /// The topic id, the value the traces filter uses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The topic's name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// What the topic's traces are about
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        public string? Definition { get; set; }

        /// <summary>
        /// The UTC date the topic was made: for a discovery run's topics, the day the run started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("born")]
        public global::System.DateTime? Born { get; set; }

        /// <summary>
        /// Born after the project's discovery run, in the last 7 days
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_new")]
        public bool? IsNew { get; set; }

        /// <summary>
        /// Traces of the topic in the window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public long? Count { get; set; }

        /// <summary>
        /// count / total_traces, from 0 to 1, not rounded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share")]
        public double? Share { get; set; }

        /// <summary>
        /// 1-based: topics by count, most first, then the earlier born, then the id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// One entry per day of the window, oldest first, today last
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.IList<global::Opik.DayCount>? Series { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicStats" /> class.
        /// </summary>
        /// <param name="id">
        /// The topic id, the value the traces filter uses
        /// </param>
        /// <param name="name">
        /// The topic's name
        /// </param>
        /// <param name="definition">
        /// What the topic's traces are about
        /// </param>
        /// <param name="born">
        /// The UTC date the topic was made: for a discovery run's topics, the day the run started
        /// </param>
        /// <param name="isNew">
        /// Born after the project's discovery run, in the last 7 days
        /// </param>
        /// <param name="count">
        /// Traces of the topic in the window
        /// </param>
        /// <param name="share">
        /// count / total_traces, from 0 to 1, not rounded
        /// </param>
        /// <param name="rank">
        /// 1-based: topics by count, most first, then the earlier born, then the id
        /// </param>
        /// <param name="series">
        /// One entry per day of the window, oldest first, today last
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicStats(
            global::System.Guid? id,
            string? name,
            string? definition,
            global::System.DateTime? born,
            bool? isNew,
            long? count,
            double? share,
            int? rank,
            global::System.Collections.Generic.IList<global::Opik.DayCount>? series)
        {
            this.Id = id;
            this.Name = name;
            this.Definition = definition;
            this.Born = born;
            this.IsNew = isNew;
            this.Count = count;
            this.Share = share;
            this.Rank = rank;
            this.Series = series;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicStats" /> class.
        /// </summary>
        public TopicStats()
        {
        }

    }
}