#nullable enable

namespace Opik.JsonConverters
{
    /// <inheritdoc />
    public sealed class FindGuardrailPoliciesExecutionScopeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Opik.FindGuardrailPoliciesExecutionScope>
    {
        /// <inheritdoc />
        public override global::Opik.FindGuardrailPoliciesExecutionScope Read(
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
                        return global::Opik.FindGuardrailPoliciesExecutionScopeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Opik.FindGuardrailPoliciesExecutionScope)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Opik.FindGuardrailPoliciesExecutionScope);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Opik.FindGuardrailPoliciesExecutionScope value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Opik.FindGuardrailPoliciesExecutionScopeExtensions.ToValueString(value));
        }
    }
}
