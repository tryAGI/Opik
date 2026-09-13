
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigWriteType), TypeInfoPropertyName = "AlertTriggerConfigWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerWriteEventType), TypeInfoPropertyName = "AlertTriggerWriteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertWriteAlertType), TypeInfoPropertyName = "AlertWriteAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigPublicType), TypeInfoPropertyName = "AlertTriggerConfigPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerPublicEventType), TypeInfoPropertyName = "AlertTriggerPublicEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPublicAlertType), TypeInfoPropertyName = "AlertPublicAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookExamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookTestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookTestResultStatus), TypeInfoPropertyName = "WebhookTestResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetWebhookExamplesAlertType), TypeInfoPropertyName = "GetWebhookExamplesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigWriteType?), TypeInfoPropertyName = "NullableAlertTriggerConfigWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerWriteEventType?), TypeInfoPropertyName = "NullableAlertTriggerWriteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertWriteAlertType?), TypeInfoPropertyName = "NullableAlertWriteAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigPublicType?), TypeInfoPropertyName = "NullableAlertTriggerConfigPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerPublicEventType?), TypeInfoPropertyName = "NullableAlertTriggerPublicEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPublicAlertType?), TypeInfoPropertyName = "NullableAlertPublicAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookTestResultStatus?), TypeInfoPropertyName = "NullableWebhookTestResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetWebhookExamplesAlertType?), TypeInfoPropertyName = "NullableGetWebhookExamplesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerConfigWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerConfigPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerPublic>))]
    internal sealed partial class AlertsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlertsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AlertsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AlertsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Opik.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType?)

                    || typeToConvert == typeof(global::Opik.AlertWriteAlertType)

                    || typeToConvert == typeof(global::Opik.AlertWriteAlertType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType?)

                    || typeToConvert == typeof(global::Opik.AlertPublicAlertType)

                    || typeToConvert == typeof(global::Opik.AlertPublicAlertType?)

                    || typeToConvert == typeof(global::Opik.WebhookTestResultStatus)

                    || typeToConvert == typeof(global::Opik.WebhookTestResultStatus?)

                    || typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType)

                    || typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerWriteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerWriteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertWriteAlertType))
                {
                    return new global::Opik.JsonConverters.AlertWriteAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertWriteAlertType?))
                {
                    return new global::Opik.JsonConverters.AlertWriteAlertTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerPublicEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerPublicEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertPublicAlertType))
                {
                    return new global::Opik.JsonConverters.AlertPublicAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertPublicAlertType?))
                {
                    return new global::Opik.JsonConverters.AlertPublicAlertTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.WebhookTestResultStatus))
                {
                    return new global::Opik.JsonConverters.WebhookTestResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.WebhookTestResultStatus?))
                {
                    return new global::Opik.JsonConverters.WebhookTestResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType))
                {
                    return new global::Opik.JsonConverters.GetWebhookExamplesAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType?))
                {
                    return new global::Opik.JsonConverters.GetWebhookExamplesAlertTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AlertsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}