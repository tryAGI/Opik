#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadAttachmentEntityTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.UploadAttachmentEntityType>
    {
        /// <inheritdoc />
        public override global::Opik.UploadAttachmentEntityType Read(
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
                        return global::Opik.UploadAttachmentEntityTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.UploadAttachmentEntityType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.UploadAttachmentEntityType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.UploadAttachmentEntityType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.UploadAttachmentEntityTypeExtensions.ToValueString(value));
        }
    }
}
