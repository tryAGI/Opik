#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProviderAuthConfigSendAsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.ProviderAuthConfigSendAs>
    {
        /// <inheritdoc />
        public override global::Opik.ProviderAuthConfigSendAs Read(
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
                        return global::Opik.ProviderAuthConfigSendAsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.ProviderAuthConfigSendAs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.ProviderAuthConfigSendAs);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.ProviderAuthConfigSendAs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.ProviderAuthConfigSendAsExtensions.ToValueString(value));
        }
    }
}
