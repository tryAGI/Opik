
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequestType), TypeInfoPropertyName = "BridgeCommandSubmitRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateLocalRunnerJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandType), TypeInfoPropertyName = "BridgeCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandStatus), TypeInfoPropertyName = "BridgeCommandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobStatus), TypeInfoPropertyName = "LocalRunnerJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Param>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Param))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerStatus), TypeInfoPropertyName = "LocalRunnerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerType), TypeInfoPropertyName = "LocalRunnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ParamPresence), TypeInfoPropertyName = "ParamPresence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerHeartbeatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerHeartbeatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LocalRunnerJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LocalRunner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.BridgeCommandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandItemType), TypeInfoPropertyName = "BridgeCommandItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandNextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandResultRequestStatus), TypeInfoPropertyName = "BridgeCommandResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobResultRequestStatus), TypeInfoPropertyName = "LocalRunnerJobResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LocalRunnerLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ListRunnersStatus), TypeInfoPropertyName = "ListRunnersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequestType?), TypeInfoPropertyName = "NullableBridgeCommandSubmitRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandType?), TypeInfoPropertyName = "NullableBridgeCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandStatus?), TypeInfoPropertyName = "NullableBridgeCommandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobStatus?), TypeInfoPropertyName = "NullableLocalRunnerJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerStatus?), TypeInfoPropertyName = "NullableLocalRunnerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerType?), TypeInfoPropertyName = "NullableLocalRunnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ParamPresence?), TypeInfoPropertyName = "NullableParamPresence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandItemType?), TypeInfoPropertyName = "NullableBridgeCommandItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandResultRequestStatus?), TypeInfoPropertyName = "NullableBridgeCommandResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobResultRequestStatus?), TypeInfoPropertyName = "NullableLocalRunnerJobResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ListRunnersStatus?), TypeInfoPropertyName = "NullableListRunnersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Param>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LocalRunnerJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LocalRunner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.BridgeCommandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LocalRunnerLogEntry>))]
    internal sealed partial class RunnersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunnersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RunnersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RunnersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType)

                    || typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandType)

                    || typeToConvert == typeof(global::Opik.BridgeCommandType?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandStatus)

                    || typeToConvert == typeof(global::Opik.BridgeCommandStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobStatus)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerStatus)

                    || typeToConvert == typeof(global::Opik.LocalRunnerStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerType)

                    || typeToConvert == typeof(global::Opik.LocalRunnerType?)

                    || typeToConvert == typeof(global::Opik.ParamPresence)

                    || typeToConvert == typeof(global::Opik.ParamPresence?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandItemType)

                    || typeToConvert == typeof(global::Opik.BridgeCommandItemType?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus)

                    || typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus?)

                    || typeToConvert == typeof(global::Opik.ListRunnersStatus)

                    || typeToConvert == typeof(global::Opik.ListRunnersStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType))
                {
                    return new global::Opik.JsonConverters.BridgeCommandSubmitRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandSubmitRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandType))
                {
                    return new global::Opik.JsonConverters.BridgeCommandTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandType?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandStatus))
                {
                    return new global::Opik.JsonConverters.BridgeCommandStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandStatus?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobStatus))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobStatus?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerStatus))
                {
                    return new global::Opik.JsonConverters.LocalRunnerStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerStatus?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerType))
                {
                    return new global::Opik.JsonConverters.LocalRunnerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerType?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ParamPresence))
                {
                    return new global::Opik.JsonConverters.ParamPresenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ParamPresence?))
                {
                    return new global::Opik.JsonConverters.ParamPresenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandItemType))
                {
                    return new global::Opik.JsonConverters.BridgeCommandItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandItemType?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus))
                {
                    return new global::Opik.JsonConverters.BridgeCommandResultRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandResultRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobResultRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobResultRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ListRunnersStatus))
                {
                    return new global::Opik.JsonConverters.ListRunnersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ListRunnersStatus?))
                {
                    return new global::Opik.JsonConverters.ListRunnersStatusNullableJsonConverter();
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
                    0 => new RunnersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}