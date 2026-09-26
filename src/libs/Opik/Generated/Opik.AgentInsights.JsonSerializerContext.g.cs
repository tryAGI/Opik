
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueStatus), TypeInfoPropertyName = "AgentInsightsIssueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueSeverity), TypeInfoPropertyName = "AgentInsightsIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssuePage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentInsightsIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueWithDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueWithDetailsStatus), TypeInfoPropertyName = "AgentInsightsIssueWithDetailsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueWithDetailsSeverity), TypeInfoPropertyName = "AgentInsightsIssueWithDetailsSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentInsightsIssueDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ReportedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportedIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportedIssueSeverity), TypeInfoPropertyName = "ReportedIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueUpdateStatus), TypeInfoPropertyName = "AgentInsightsIssueUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesStatus), TypeInfoPropertyName = "FindAgentInsightsIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesSeverity), TypeInfoPropertyName = "FindAgentInsightsIssuesSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueStatus?), TypeInfoPropertyName = "NullableAgentInsightsIssueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueSeverity?), TypeInfoPropertyName = "NullableAgentInsightsIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueWithDetailsStatus?), TypeInfoPropertyName = "NullableAgentInsightsIssueWithDetailsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueWithDetailsSeverity?), TypeInfoPropertyName = "NullableAgentInsightsIssueWithDetailsSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportedIssueSeverity?), TypeInfoPropertyName = "NullableReportedIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueUpdateStatus?), TypeInfoPropertyName = "NullableAgentInsightsIssueUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesStatus?), TypeInfoPropertyName = "NullableFindAgentInsightsIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesSeverity?), TypeInfoPropertyName = "NullableFindAgentInsightsIssuesSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentInsightsIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentInsightsIssueDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ReportedIssue>))]
    internal sealed partial class AgentInsightsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentInsightsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentInsightsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentInsightsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Opik.AgentInsightsIssueStatus)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueStatus?)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueSeverity)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueSeverity?)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsStatus)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsStatus?)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsSeverity)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsSeverity?)

                    || typeToConvert == typeof(global::Opik.ReportedIssueSeverity)

                    || typeToConvert == typeof(global::Opik.ReportedIssueSeverity?)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueUpdateStatus)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueUpdateStatus?)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesStatus)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesStatus?)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesSeverity)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesSeverity?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueStatus))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueStatus?))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueSeverity))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueSeverity?))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsStatus))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueWithDetailsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsStatus?))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueWithDetailsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsSeverity))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueWithDetailsSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueWithDetailsSeverity?))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueWithDetailsSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ReportedIssueSeverity))
                {
                    return new global::Opik.JsonConverters.ReportedIssueSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ReportedIssueSeverity?))
                {
                    return new global::Opik.JsonConverters.ReportedIssueSeverityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueUpdateStatus))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueUpdateStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsIssueUpdateStatus?))
                {
                    return new global::Opik.JsonConverters.AgentInsightsIssueUpdateStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesStatus))
                {
                    return new global::Opik.JsonConverters.FindAgentInsightsIssuesStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesStatus?))
                {
                    return new global::Opik.JsonConverters.FindAgentInsightsIssuesStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesSeverity))
                {
                    return new global::Opik.JsonConverters.FindAgentInsightsIssuesSeverityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesSeverity?))
                {
                    return new global::Opik.JsonConverters.FindAgentInsightsIssuesSeverityNullableJsonConverter();
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
                    0 => new AgentInsightsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}