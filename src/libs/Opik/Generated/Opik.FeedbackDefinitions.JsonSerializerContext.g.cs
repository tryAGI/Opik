
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinitionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinitionCreateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDetailCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinitionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinitionCreateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDetailCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreateType), TypeInfoPropertyName = "FeedbackCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreateDiscriminatorType), TypeInfoPropertyName = "FeedbackCreateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinitionCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinitionCreateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDetailCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinitionPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinitionPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDetailPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinitionPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinitionPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDetailPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackDefinitionPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackObjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublicType), TypeInfoPropertyName = "FeedbackObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublicDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublicDiscriminatorType), TypeInfoPropertyName = "FeedbackObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinitionPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinitionPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDetailPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublicType), TypeInfoPropertyName = "FeedbackPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublicDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublicDiscriminatorType), TypeInfoPropertyName = "FeedbackPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinitionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinitionUpdateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDetailUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinitionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinitionUpdateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDetailUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdateType), TypeInfoPropertyName = "FeedbackUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdateDiscriminatorType), TypeInfoPropertyName = "FeedbackUpdateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinitionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinitionUpdateVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDetailUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackDefinitionsType), TypeInfoPropertyName = "FindFeedbackDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreateType?), TypeInfoPropertyName = "NullableFeedbackCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreateDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackCreateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublicType?), TypeInfoPropertyName = "NullableFeedbackObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublicDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublicType?), TypeInfoPropertyName = "NullableFeedbackPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublicDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdateType?), TypeInfoPropertyName = "NullableFeedbackUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdateDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackUpdateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackDefinitionsType?), TypeInfoPropertyName = "NullableFindFeedbackDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackObjectPublic>))]
    internal sealed partial class FeedbackDefinitionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FeedbackDefinitionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FeedbackDefinitionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FeedbackDefinitionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Opik.FeedbackCreateType)

                    || typeToConvert == typeof(global::Opik.FeedbackCreateType?)

                    || typeToConvert == typeof(global::Opik.FeedbackCreateDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.FeedbackCreateDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.FeedbackObjectPublicType)

                    || typeToConvert == typeof(global::Opik.FeedbackObjectPublicType?)

                    || typeToConvert == typeof(global::Opik.FeedbackObjectPublicDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.FeedbackObjectPublicDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.FeedbackPublicType)

                    || typeToConvert == typeof(global::Opik.FeedbackPublicType?)

                    || typeToConvert == typeof(global::Opik.FeedbackPublicDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.FeedbackPublicDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.FeedbackUpdateType)

                    || typeToConvert == typeof(global::Opik.FeedbackUpdateType?)

                    || typeToConvert == typeof(global::Opik.FeedbackUpdateDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.FeedbackUpdateDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType)

                    || typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.FeedbackCreateType))
                {
                    return new global::Opik.JsonConverters.FeedbackCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackCreateType?))
                {
                    return new global::Opik.JsonConverters.FeedbackCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackCreateDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.FeedbackCreateDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackCreateDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.FeedbackCreateDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackObjectPublicType))
                {
                    return new global::Opik.JsonConverters.FeedbackObjectPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackObjectPublicType?))
                {
                    return new global::Opik.JsonConverters.FeedbackObjectPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackObjectPublicDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.FeedbackObjectPublicDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackObjectPublicDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.FeedbackObjectPublicDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackPublicType))
                {
                    return new global::Opik.JsonConverters.FeedbackPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackPublicType?))
                {
                    return new global::Opik.JsonConverters.FeedbackPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackPublicDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.FeedbackPublicDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackPublicDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.FeedbackPublicDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackUpdateType))
                {
                    return new global::Opik.JsonConverters.FeedbackUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackUpdateType?))
                {
                    return new global::Opik.JsonConverters.FeedbackUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackUpdateDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.FeedbackUpdateDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackUpdateDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.FeedbackUpdateDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType))
                {
                    return new global::Opik.JsonConverters.FindFeedbackDefinitionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType?))
                {
                    return new global::Opik.JsonConverters.FindFeedbackDefinitionsTypeNullableJsonConverter();
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
                    0 => new FeedbackDefinitionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}