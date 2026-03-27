#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class AlertTriggerConfigWriteTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.AlertTriggerConfigWriteType>
    {
        /// <inheritdoc />
        public override global::Opik.AlertTriggerConfigWriteType Read(
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
                        return global::Opik.AlertTriggerConfigWriteTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.AlertTriggerConfigWriteType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.AlertTriggerConfigWriteType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.AlertTriggerConfigWriteType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.AlertTriggerConfigWriteTypeExtensions.ToValueString(value));
        }
    }
}
