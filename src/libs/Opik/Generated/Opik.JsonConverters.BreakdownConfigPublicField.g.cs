#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class BreakdownConfigPublicFieldJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.BreakdownConfigPublicField>
    {
        /// <inheritdoc />
        public override global::Opik.BreakdownConfigPublicField Read(
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
                        return global::Opik.BreakdownConfigPublicFieldExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.BreakdownConfigPublicField)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.BreakdownConfigPublicField);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.BreakdownConfigPublicField value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.BreakdownConfigPublicFieldExtensions.ToValueString(value));
        }
    }
}
