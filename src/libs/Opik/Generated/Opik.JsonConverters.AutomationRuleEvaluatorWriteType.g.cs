#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutomationRuleEvaluatorWriteTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.AutomationRuleEvaluatorWriteType>
    {
        /// <inheritdoc />
        public override global::Opik.AutomationRuleEvaluatorWriteType Read(
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
                        return global::Opik.AutomationRuleEvaluatorWriteTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.AutomationRuleEvaluatorWriteType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.AutomationRuleEvaluatorWriteType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.AutomationRuleEvaluatorWriteType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.AutomationRuleEvaluatorWriteTypeExtensions.ToValueString(value));
        }
    }
}
