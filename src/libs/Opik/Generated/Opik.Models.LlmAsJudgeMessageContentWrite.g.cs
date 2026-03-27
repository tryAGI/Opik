
#nullable enable

namespace Opik
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmAsJudgeMessageContentWrite
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
        public global::Opik.ImageUrlWrite? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public global::Opik.VideoUrlWrite? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public global::Opik.AudioUrlWrite? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageContentWrite" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="imageUrl"></param>
        /// <param name="videoUrl"></param>
        /// <param name="audioUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmAsJudgeMessageContentWrite(
            string type,
            string? text,
            global::Opik.ImageUrlWrite? imageUrl,
            global::Opik.VideoUrlWrite? videoUrl,
            global::Opik.AudioUrlWrite? audioUrl)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.VideoUrl = videoUrl;
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageContentWrite" /> class.
        /// </summary>
        public LlmAsJudgeMessageContentWrite()
        {
        }
    }
}