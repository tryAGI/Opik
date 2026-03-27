#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExperimentWriteEvaluationMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.ExperimentWriteEvaluationMethod?>
    {
        /// <inheritdoc />
        public override global::Opik.ExperimentWriteEvaluationMethod? Read(
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
                        return global::Opik.ExperimentWriteEvaluationMethodExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.ExperimentWriteEvaluationMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.ExperimentWriteEvaluationMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.ExperimentWriteEvaluationMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Opik.ExperimentWriteEvaluationMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
