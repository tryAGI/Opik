#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlmAsJudgeModelParametersPublicApiJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.LlmAsJudgeModelParametersPublicApi>
    {
        /// <inheritdoc />
        public override global::Opik.LlmAsJudgeModelParametersPublicApi Read(
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
                        return global::Opik.LlmAsJudgeModelParametersPublicApiExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.LlmAsJudgeModelParametersPublicApi)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.LlmAsJudgeModelParametersPublicApi);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.LlmAsJudgeModelParametersPublicApi value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.LlmAsJudgeModelParametersPublicApiExtensions.ToValueString(value));
        }
    }
}
