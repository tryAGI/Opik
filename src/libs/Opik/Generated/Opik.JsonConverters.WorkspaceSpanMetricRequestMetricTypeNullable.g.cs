#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class WorkspaceSpanMetricRequestMetricTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.WorkspaceSpanMetricRequestMetricType?>
    {
        /// <inheritdoc />
        public override global::Opik.WorkspaceSpanMetricRequestMetricType? Read(
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
                        return global::Opik.WorkspaceSpanMetricRequestMetricTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.WorkspaceSpanMetricRequestMetricType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.WorkspaceSpanMetricRequestMetricType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.WorkspaceSpanMetricRequestMetricType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Opik.WorkspaceSpanMetricRequestMetricTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
