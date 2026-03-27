#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedbackScoreBatchItemThreadSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.FeedbackScoreBatchItemThreadSource>
    {
        /// <inheritdoc />
        public override global::Opik.FeedbackScoreBatchItemThreadSource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Opik.FeedbackScoreBatchItemThreadSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.FeedbackScoreBatchItemThreadSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.FeedbackScoreBatchItemThreadSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.FeedbackScoreBatchItemThreadSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.FeedbackScoreBatchItemThreadSourceExtensions.ToValueString(value));
        }
    }
}
