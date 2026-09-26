
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessageWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWriteType), TypeInfoPropertyName = "AgentBlueprintWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigValueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigCreateWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWriteType), TypeInfoPropertyName = "AgentConfigValueWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigEnv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigEnvUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigEnv>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintPublicType), TypeInfoPropertyName = "AgentBlueprintPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigValuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValuePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValuePublicType), TypeInfoPropertyName = "AgentConfigValuePublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintHistoryType), TypeInfoPropertyName = "AgentBlueprintHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigValueHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueHistoryType), TypeInfoPropertyName = "AgentConfigValueHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BlueprintPageHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentBlueprintHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessageHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigRemoveValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigEnvSetByName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWriteType?), TypeInfoPropertyName = "NullableAgentBlueprintWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWriteType?), TypeInfoPropertyName = "NullableAgentConfigValueWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintPublicType?), TypeInfoPropertyName = "NullableAgentBlueprintPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValuePublicType?), TypeInfoPropertyName = "NullableAgentConfigValuePublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintHistoryType?), TypeInfoPropertyName = "NullableAgentBlueprintHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueHistoryType?), TypeInfoPropertyName = "NullableAgentConfigValueHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigEnv>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValueHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentBlueprintHistory>))]
    internal sealed partial class AgentConfigsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentConfigsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentConfigsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentConfigsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Opik.AgentBlueprintWriteType)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintWriteType?)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueWriteType)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueWriteType?)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintPublicType)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintPublicType?)

                    || typeToConvert == typeof(global::Opik.AgentConfigValuePublicType)

                    || typeToConvert == typeof(global::Opik.AgentConfigValuePublicType?)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType?)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.AgentBlueprintWriteType))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintWriteType?))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueWriteType))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueWriteType?))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintPublicType))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintPublicType?))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValuePublicType))
                {
                    return new global::Opik.JsonConverters.AgentConfigValuePublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValuePublicType?))
                {
                    return new global::Opik.JsonConverters.AgentConfigValuePublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintHistoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType?))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintHistoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueHistoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType?))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueHistoryTypeNullableJsonConverter();
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
                    0 => new AgentConfigsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}