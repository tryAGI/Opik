#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceExperimentItemBulkWriteViewSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.TraceExperimentItemBulkWriteViewSource?>
    {
        /// <inheritdoc />
        public override global::Opik.TraceExperimentItemBulkWriteViewSource? Read(
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
                        return global::Opik.TraceExperimentItemBulkWriteViewSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.TraceExperimentItemBulkWriteViewSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.TraceExperimentItemBulkWriteViewSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.TraceExperimentItemBulkWriteViewSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Opik.TraceExperimentItemBulkWriteViewSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
