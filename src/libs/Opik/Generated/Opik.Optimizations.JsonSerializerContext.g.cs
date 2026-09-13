
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAveragePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString), TypeInfoPropertyName = "JsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringWrite), TypeInfoPropertyName = "JsonListStringWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteIdsHolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringPublic), TypeInfoPropertyName = "JsonListStringPublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfoWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationStudioConfigWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioPromptWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioLlmModelWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioEvaluationWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioOptimizerWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationWriteStatus), TypeInfoPropertyName = "OptimizationWriteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.StudioMetricWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioMetricWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioMessageWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.StudioMessageWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfoPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.OptimizationPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationStudioConfigPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioPromptPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioLlmModelPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioEvaluationPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioOptimizerPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationPublicStatus), TypeInfoPropertyName = "OptimizationPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.StudioMetricPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioMetricPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioMessagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.StudioMessagePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationStudioLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationUpdateStatus), TypeInfoPropertyName = "OptimizationUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString?), TypeInfoPropertyName = "NullableJsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringWrite?), TypeInfoPropertyName = "NullableJsonListStringWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringPublic?), TypeInfoPropertyName = "NullableJsonListStringPublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationWriteStatus?), TypeInfoPropertyName = "NullableOptimizationWriteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationPublicStatus?), TypeInfoPropertyName = "NullableOptimizationPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationUpdateStatus?), TypeInfoPropertyName = "NullableOptimizationUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMetricWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMessageWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.OptimizationPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMetricPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMessagePublic>))]
    internal sealed partial class OptimizationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OptimizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OptimizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OptimizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringWriteJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringPublicJsonConverter());
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
                    typeToConvert == typeof(global::Opik.OptimizationWriteStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationWriteStatus?)

                    || typeToConvert == typeof(global::Opik.OptimizationPublicStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationPublicStatus?)

                    || typeToConvert == typeof(global::Opik.OptimizationUpdateStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationUpdateStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.OptimizationWriteStatus))
                {
                    return new global::Opik.JsonConverters.OptimizationWriteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationWriteStatus?))
                {
                    return new global::Opik.JsonConverters.OptimizationWriteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationPublicStatus))
                {
                    return new global::Opik.JsonConverters.OptimizationPublicStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationPublicStatus?))
                {
                    return new global::Opik.JsonConverters.OptimizationPublicStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationUpdateStatus))
                {
                    return new global::Opik.JsonConverters.OptimizationUpdateStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationUpdateStatus?))
                {
                    return new global::Opik.JsonConverters.OptimizationUpdateStatusNullableJsonConverter();
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
                    0 => new OptimizationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}