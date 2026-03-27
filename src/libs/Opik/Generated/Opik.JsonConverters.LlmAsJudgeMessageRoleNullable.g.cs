#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlmAsJudgeMessageRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.LlmAsJudgeMessageRole?>
    {
        /// <inheritdoc />
        public override global::Opik.LlmAsJudgeMessageRole? Read(
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
                        return global::Opik.LlmAsJudgeMessageRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.LlmAsJudgeMessageRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.LlmAsJudgeMessageRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.LlmAsJudgeMessageRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Opik.LlmAsJudgeMessageRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
