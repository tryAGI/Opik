
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmAsJudgeMessageContentPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::Opik.ImageUrlPublic? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public global::Opik.VideoUrlPublic? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public global::Opik.AudioUrlPublic? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageContentPublic" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="imageUrl"></param>
        /// <param name="videoUrl"></param>
        /// <param name="audioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmAsJudgeMessageContentPublic(
            string type,
            string? text,
            global::Opik.ImageUrlPublic? imageUrl,
            global::Opik.VideoUrlPublic? videoUrl,
            global::Opik.AudioUrlPublic? audioUrl)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.VideoUrl = videoUrl;
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageContentPublic" /> class.
        /// </summary>
        public LlmAsJudgeMessageContentPublic()
        {
        }

    }
}