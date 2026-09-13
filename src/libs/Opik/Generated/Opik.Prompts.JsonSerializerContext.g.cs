
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionLinkPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublicTemplateStructure), TypeInfoPropertyName = "PromptPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteType), TypeInfoPropertyName = "PromptWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteTemplateStructure), TypeInfoPropertyName = "PromptWriteTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailType), TypeInfoPropertyName = "PromptVersionDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailVersionType), TypeInfoPropertyName = "PromptVersionDetailVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailTemplateStructure), TypeInfoPropertyName = "PromptVersionDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessageDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreatePromptVersionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreatePromptVersionDetailTemplateStructure), TypeInfoPropertyName = "CreatePromptVersionDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptDetailTemplateStructure), TypeInfoPropertyName = "PromptDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicType), TypeInfoPropertyName = "PromptVersionPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicVersionType), TypeInfoPropertyName = "PromptVersionPublicVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicTemplateStructure), TypeInfoPropertyName = "PromptVersionPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionCommitsRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionRetrieveDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionIdsRequestDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionEnvironmentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptUpdatable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublicTemplateStructure?), TypeInfoPropertyName = "NullablePromptPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteType?), TypeInfoPropertyName = "NullablePromptWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteTemplateStructure?), TypeInfoPropertyName = "NullablePromptWriteTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailType?), TypeInfoPropertyName = "NullablePromptVersionDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailVersionType?), TypeInfoPropertyName = "NullablePromptVersionDetailVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailTemplateStructure?), TypeInfoPropertyName = "NullablePromptVersionDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreatePromptVersionDetailTemplateStructure?), TypeInfoPropertyName = "NullableCreatePromptVersionDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptDetailTemplateStructure?), TypeInfoPropertyName = "NullablePromptDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicType?), TypeInfoPropertyName = "NullablePromptVersionPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicVersionType?), TypeInfoPropertyName = "NullablePromptVersionPublicVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicTemplateStructure?), TypeInfoPropertyName = "NullablePromptVersionPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionLinkPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionDetail>))]
    internal sealed partial class PromptsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PromptsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private PromptsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptWriteType)

                    || typeToConvert == typeof(global::Opik.PromptWriteType?)

                    || typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailType)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure)

                    || typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicType)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptPublicTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptPublicTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteType))
                {
                    return new global::Opik.JsonConverters.PromptWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteType?))
                {
                    return new global::Opik.JsonConverters.PromptWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptWriteTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptWriteTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailType))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure))
                {
                    return new global::Opik.JsonConverters.CreatePromptVersionDetailTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.CreatePromptVersionDetailTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptDetailTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptDetailTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicType))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTemplateStructureNullableJsonConverter();
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
                    0 => new PromptsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}