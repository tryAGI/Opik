
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublicOperator), TypeInfoPropertyName = "SpanFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString), TypeInfoPropertyName = "JsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreSource), TypeInfoPropertyName = "FeedbackScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntrySource), TypeInfoPropertyName = "ValueEntrySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AvgValueStatPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AvgValueStatPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CountValueStatPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CountValueStatPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValueStatPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValueStatPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValuesPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublicType), TypeInfoPropertyName = "ProjectStatItemObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublicDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType), TypeInfoPropertyName = "ProjectStatItemObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatsPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ProjectStatItemObjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringWrite), TypeInfoPropertyName = "JsonListStringWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CommentPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringPublic), TypeInfoPropertyName = "JsonListStringPublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.CommentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreNamesPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ScoreNamePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreNamePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfoWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfoPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdateType), TypeInfoPropertyName = "SpanUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdateSource), TypeInfoPropertyName = "SpanUpdateSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteType), TypeInfoPropertyName = "SpanWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteSource), TypeInfoPropertyName = "SpanWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteFeedbackScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScorePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScorePublicSource), TypeInfoPropertyName = "FeedbackScorePublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanPublicType), TypeInfoPropertyName = "SpanPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScorePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanPublicSource), TypeInfoPropertyName = "SpanPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryPublicSource), TypeInfoPropertyName = "ValueEntryPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatchItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatchItemSource), TypeInfoPropertyName = "FeedbackScoreBatchItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanSearchStreamRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanSearchStreamRequestPublicType), TypeInfoPropertyName = "SpanSearchStreamRequestPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanSearchStreamRequestPublicExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanSearchStreamRequestPublicExcludeItem), TypeInfoPropertyName = "SpanSearchStreamRequestPublicExcludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExistenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpansByProjectType), TypeInfoPropertyName = "GetSpansByProjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackScoreNames1Type), TypeInfoPropertyName = "FindFeedbackScoreNames1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpanStatsType), TypeInfoPropertyName = "GetSpanStatsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>), TypeInfoPropertyName = "AnyOfSpanPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublicOperator?), TypeInfoPropertyName = "NullableSpanFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString?), TypeInfoPropertyName = "NullableJsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreSource?), TypeInfoPropertyName = "NullableFeedbackScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntrySource?), TypeInfoPropertyName = "NullableValueEntrySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublicType?), TypeInfoPropertyName = "NullableProjectStatItemObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType?), TypeInfoPropertyName = "NullableProjectStatItemObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringWrite?), TypeInfoPropertyName = "NullableJsonListStringWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringPublic?), TypeInfoPropertyName = "NullableJsonListStringPublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdateType?), TypeInfoPropertyName = "NullableSpanUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdateSource?), TypeInfoPropertyName = "NullableSpanUpdateSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteType?), TypeInfoPropertyName = "NullableSpanWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteSource?), TypeInfoPropertyName = "NullableSpanWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScorePublicSource?), TypeInfoPropertyName = "NullableFeedbackScorePublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanPublicType?), TypeInfoPropertyName = "NullableSpanPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanPublicSource?), TypeInfoPropertyName = "NullableSpanPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryPublicSource?), TypeInfoPropertyName = "NullableValueEntryPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatchItemSource?), TypeInfoPropertyName = "NullableFeedbackScoreBatchItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanSearchStreamRequestPublicType?), TypeInfoPropertyName = "NullableSpanSearchStreamRequestPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanSearchStreamRequestPublicExcludeItem?), TypeInfoPropertyName = "NullableSpanSearchStreamRequestPublicExcludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpansByProjectType?), TypeInfoPropertyName = "NullableGetSpansByProjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackScoreNames1Type?), TypeInfoPropertyName = "NullableFindFeedbackScoreNames1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpanStatsType?), TypeInfoPropertyName = "NullableGetSpanStatsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>?), TypeInfoPropertyName = "NullableAnyOfSpanPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ProjectStatItemObjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.CommentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ScoreNamePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScorePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreBatchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanSearchStreamRequestPublicExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>))]
    internal sealed partial class SpansSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpansSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SpansSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SpansSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>());
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
                    typeToConvert == typeof(global::Opik.SpanFilterPublicOperator)

                    || typeToConvert == typeof(global::Opik.SpanFilterPublicOperator?)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreSource?)

                    || typeToConvert == typeof(global::Opik.ValueEntrySource)

                    || typeToConvert == typeof(global::Opik.ValueEntrySource?)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicType)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicType?)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.SpanUpdateType)

                    || typeToConvert == typeof(global::Opik.SpanUpdateType?)

                    || typeToConvert == typeof(global::Opik.SpanUpdateSource)

                    || typeToConvert == typeof(global::Opik.SpanUpdateSource?)

                    || typeToConvert == typeof(global::Opik.SpanWriteType)

                    || typeToConvert == typeof(global::Opik.SpanWriteType?)

                    || typeToConvert == typeof(global::Opik.SpanWriteSource)

                    || typeToConvert == typeof(global::Opik.SpanWriteSource?)

                    || typeToConvert == typeof(global::Opik.FeedbackScorePublicSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScorePublicSource?)

                    || typeToConvert == typeof(global::Opik.SpanPublicType)

                    || typeToConvert == typeof(global::Opik.SpanPublicType?)

                    || typeToConvert == typeof(global::Opik.SpanPublicSource)

                    || typeToConvert == typeof(global::Opik.SpanPublicSource?)

                    || typeToConvert == typeof(global::Opik.ValueEntryPublicSource)

                    || typeToConvert == typeof(global::Opik.ValueEntryPublicSource?)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemSource?)

                    || typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicType)

                    || typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicType?)

                    || typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicExcludeItem)

                    || typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicExcludeItem?)

                    || typeToConvert == typeof(global::Opik.GetSpansByProjectType)

                    || typeToConvert == typeof(global::Opik.GetSpansByProjectType?)

                    || typeToConvert == typeof(global::Opik.FindFeedbackScoreNames1Type)

                    || typeToConvert == typeof(global::Opik.FindFeedbackScoreNames1Type?)

                    || typeToConvert == typeof(global::Opik.GetSpanStatsType)

                    || typeToConvert == typeof(global::Opik.GetSpanStatsType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.SpanFilterPublicOperator))
                {
                    return new global::Opik.JsonConverters.SpanFilterPublicOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanFilterPublicOperator?))
                {
                    return new global::Opik.JsonConverters.SpanFilterPublicOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreSource))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreSource?))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntrySource))
                {
                    return new global::Opik.JsonConverters.ValueEntrySourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntrySource?))
                {
                    return new global::Opik.JsonConverters.ValueEntrySourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicType))
                {
                    return new global::Opik.JsonConverters.ProjectStatItemObjectPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicType?))
                {
                    return new global::Opik.JsonConverters.ProjectStatItemObjectPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.ProjectStatItemObjectPublicDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.ProjectStatItemObjectPublicDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanUpdateType))
                {
                    return new global::Opik.JsonConverters.SpanUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanUpdateType?))
                {
                    return new global::Opik.JsonConverters.SpanUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanUpdateSource))
                {
                    return new global::Opik.JsonConverters.SpanUpdateSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanUpdateSource?))
                {
                    return new global::Opik.JsonConverters.SpanUpdateSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanWriteType))
                {
                    return new global::Opik.JsonConverters.SpanWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanWriteType?))
                {
                    return new global::Opik.JsonConverters.SpanWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanWriteSource))
                {
                    return new global::Opik.JsonConverters.SpanWriteSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanWriteSource?))
                {
                    return new global::Opik.JsonConverters.SpanWriteSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScorePublicSource))
                {
                    return new global::Opik.JsonConverters.FeedbackScorePublicSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScorePublicSource?))
                {
                    return new global::Opik.JsonConverters.FeedbackScorePublicSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanPublicType))
                {
                    return new global::Opik.JsonConverters.SpanPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanPublicType?))
                {
                    return new global::Opik.JsonConverters.SpanPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanPublicSource))
                {
                    return new global::Opik.JsonConverters.SpanPublicSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanPublicSource?))
                {
                    return new global::Opik.JsonConverters.SpanPublicSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntryPublicSource))
                {
                    return new global::Opik.JsonConverters.ValueEntryPublicSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntryPublicSource?))
                {
                    return new global::Opik.JsonConverters.ValueEntryPublicSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemSource))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreBatchItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemSource?))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreBatchItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicType))
                {
                    return new global::Opik.JsonConverters.SpanSearchStreamRequestPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicType?))
                {
                    return new global::Opik.JsonConverters.SpanSearchStreamRequestPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicExcludeItem))
                {
                    return new global::Opik.JsonConverters.SpanSearchStreamRequestPublicExcludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanSearchStreamRequestPublicExcludeItem?))
                {
                    return new global::Opik.JsonConverters.SpanSearchStreamRequestPublicExcludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GetSpansByProjectType))
                {
                    return new global::Opik.JsonConverters.GetSpansByProjectTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GetSpansByProjectType?))
                {
                    return new global::Opik.JsonConverters.GetSpansByProjectTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindFeedbackScoreNames1Type))
                {
                    return new global::Opik.JsonConverters.FindFeedbackScoreNames1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindFeedbackScoreNames1Type?))
                {
                    return new global::Opik.JsonConverters.FindFeedbackScoreNames1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GetSpanStatsType))
                {
                    return new global::Opik.JsonConverters.GetSpanStatsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GetSpanStatsType?))
                {
                    return new global::Opik.JsonConverters.GetSpanStatsTypeNullableJsonConverter();
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
                    0 => new SpansSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}