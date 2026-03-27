#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpanExperimentItemBulkWriteViewTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.SpanExperimentItemBulkWriteViewType?>
    {
        /// <inheritdoc />
        public override global::Opik.SpanExperimentItemBulkWriteViewType? Read(
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
                        return global::Opik.SpanExperimentItemBulkWriteViewTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.SpanExperimentItemBulkWriteViewType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.SpanExperimentItemBulkWriteViewType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.SpanExperimentItemBulkWriteViewType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Opik.SpanExperimentItemBulkWriteViewTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
