
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueItemIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueAutomation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Conditions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ConditionGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ScoreCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ConditionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionOperator), TypeInfoPropertyName = "ScoreConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueAutomationWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ConditionsWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueWriteScope), TypeInfoPropertyName = "AnnotationQueueWriteScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ConditionGroupWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ScoreConditionWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ConditionGroupWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionWriteOperator), TypeInfoPropertyName = "ScoreConditionWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueAutomationPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ConditionsPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueReviewerPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePublicScope), TypeInfoPropertyName = "AnnotationQueuePublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAveragePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ConditionGroupPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ScoreConditionPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ConditionGroupPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionPublicOperator), TypeInfoPropertyName = "ScoreConditionPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ItemLockInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ItemLockInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueItemPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueItemPublicSource), TypeInfoPropertyName = "AnnotationQueueItemPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueItemsPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueueItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueItemIdsPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionOperator?), TypeInfoPropertyName = "NullableScoreConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueWriteScope?), TypeInfoPropertyName = "NullableAnnotationQueueWriteScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionWriteOperator?), TypeInfoPropertyName = "NullableScoreConditionWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePublicScope?), TypeInfoPropertyName = "NullableAnnotationQueuePublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreConditionPublicOperator?), TypeInfoPropertyName = "NullableScoreConditionPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueItemPublicSource?), TypeInfoPropertyName = "NullableAnnotationQueueItemPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ScoreCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ConditionGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ScoreConditionWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ConditionGroupWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueueReviewerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ScoreConditionPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ConditionGroupPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueueItemPublic>))]
    internal sealed partial class AnnotationQueuesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationQueuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AnnotationQueuesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AnnotationQueuesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Opik.ScoreConditionOperator)

                    || typeToConvert == typeof(global::Opik.ScoreConditionOperator?)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope?)

                    || typeToConvert == typeof(global::Opik.ScoreConditionWriteOperator)

                    || typeToConvert == typeof(global::Opik.ScoreConditionWriteOperator?)

                    || typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope)

                    || typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope?)

                    || typeToConvert == typeof(global::Opik.ScoreConditionPublicOperator)

                    || typeToConvert == typeof(global::Opik.ScoreConditionPublicOperator?)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueItemPublicSource)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueItemPublicSource?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.ScoreConditionOperator))
                {
                    return new global::Opik.JsonConverters.ScoreConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ScoreConditionOperator?))
                {
                    return new global::Opik.JsonConverters.ScoreConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueWriteScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope?))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueWriteScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ScoreConditionWriteOperator))
                {
                    return new global::Opik.JsonConverters.ScoreConditionWriteOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ScoreConditionWriteOperator?))
                {
                    return new global::Opik.JsonConverters.ScoreConditionWriteOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope))
                {
                    return new global::Opik.JsonConverters.AnnotationQueuePublicScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope?))
                {
                    return new global::Opik.JsonConverters.AnnotationQueuePublicScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ScoreConditionPublicOperator))
                {
                    return new global::Opik.JsonConverters.ScoreConditionPublicOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ScoreConditionPublicOperator?))
                {
                    return new global::Opik.JsonConverters.ScoreConditionPublicOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueItemPublicSource))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueItemPublicSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueItemPublicSource?))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueItemPublicSourceNullableJsonConverter();
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
                    0 => new AnnotationQueuesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}