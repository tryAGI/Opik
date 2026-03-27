#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class DatasetExportJobPublicStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.DatasetExportJobPublicStatus>
    {
        /// <inheritdoc />
        public override global::Opik.DatasetExportJobPublicStatus Read(
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
                        return global::Opik.DatasetExportJobPublicStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.DatasetExportJobPublicStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.DatasetExportJobPublicStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.DatasetExportJobPublicStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.DatasetExportJobPublicStatusExtensions.ToValueString(value));
        }
    }
}
