#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlmAsJudgeOutputSchemaPublicTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.LlmAsJudgeOutputSchemaPublicType?>
    {
        /// <inheritdoc />
        public override global::Opik.LlmAsJudgeOutputSchemaPublicType? Read(
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
                        return global::Opik.LlmAsJudgeOutputSchemaPublicTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.LlmAsJudgeOutputSchemaPublicType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.LlmAsJudgeOutputSchemaPublicType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.LlmAsJudgeOutputSchemaPublicType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Opik.LlmAsJudgeOutputSchemaPublicTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
