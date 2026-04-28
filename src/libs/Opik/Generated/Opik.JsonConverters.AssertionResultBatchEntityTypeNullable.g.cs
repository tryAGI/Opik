#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssertionResultBatchEntityTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.AssertionResultBatchEntityType?>
    {
        /// <inheritdoc />
        public override global::Opik.AssertionResultBatchEntityType? Read(
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
                        return global::Opik.AssertionResultBatchEntityTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.AssertionResultBatchEntityType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.AssertionResultBatchEntityType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.AssertionResultBatchEntityType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Opik.AssertionResultBatchEntityTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
