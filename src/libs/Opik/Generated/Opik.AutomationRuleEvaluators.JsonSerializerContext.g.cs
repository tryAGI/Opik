
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AudioUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanLlmAsJudgeCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUserDefinedMetricPythonCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceThreadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadLlmAsJudgeCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadUserDefinedMetricPythonCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UserDefinedMetricPythonCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeModelParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageRole), TypeInfoPropertyName = "LlmAsJudgeMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.VideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaType), TypeInfoPropertyName = "LlmAsJudgeOutputSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterOperator), TypeInfoPropertyName = "SpanFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterOperator), TypeInfoPropertyName = "TraceFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterOperator), TypeInfoPropertyName = "TraceThreadFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AudioUrlWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorLlmAsJudgeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorLlmAsJudgeWriteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceFilterWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeCodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWriteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanFilterWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanLlmAsJudgeCodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWriteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUserDefinedMetricPythonCodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWriteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadLlmAsJudgeCodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWriteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadUserDefinedMetricPythonCodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UserDefinedMetricPythonCodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteTriggerScope), TypeInfoPropertyName = "AutomationRuleEvaluatorWriteTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteType), TypeInfoPropertyName = "AutomationRuleEvaluatorWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteAction), TypeInfoPropertyName = "AutomationRuleEvaluatorWriteAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorWriteDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ImageUrlWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeModelParametersWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageContentWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.VideoUrlWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageWriteRole), TypeInfoPropertyName = "LlmAsJudgeMessageWriteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaWriteType), TypeInfoPropertyName = "LlmAsJudgeOutputSchemaWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterWriteOperator), TypeInfoPropertyName = "SpanFilterWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterWriteOperator), TypeInfoPropertyName = "TraceFilterWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterWriteOperator), TypeInfoPropertyName = "TraceThreadFilterWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AudioUrlPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorLlmAsJudgePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorLlmAsJudgePublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeCodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ProjectReferencePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectReferencePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope), TypeInfoPropertyName = "AutomationRuleEvaluatorObjectObjectPublicTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicType), TypeInfoPropertyName = "AutomationRuleEvaluatorObjectObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction), TypeInfoPropertyName = "AutomationRuleEvaluatorObjectObjectPublicAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AutomationRuleEvaluatorObjectObjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanLlmAsJudgeCodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUserDefinedMetricPythonCodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadLlmAsJudgeCodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadUserDefinedMetricPythonCodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublicVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UserDefinedMetricPythonCodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ImageUrlPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeModelParametersPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessagePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageContentPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.VideoUrlPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessagePublicRole), TypeInfoPropertyName = "LlmAsJudgeMessagePublicRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaPublicType), TypeInfoPropertyName = "LlmAsJudgeOutputSchemaPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublicOperator), TypeInfoPropertyName = "SpanFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterPublicOperator), TypeInfoPropertyName = "TraceFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterPublicOperator), TypeInfoPropertyName = "TraceThreadFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicTriggerScope), TypeInfoPropertyName = "AutomationRuleEvaluatorPublicTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicType), TypeInfoPropertyName = "AutomationRuleEvaluatorPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicAction), TypeInfoPropertyName = "AutomationRuleEvaluatorPublicAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogItemLevel), TypeInfoPropertyName = "LogItemLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LogItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateTriggerScope), TypeInfoPropertyName = "AutomationRuleEvaluatorUpdateTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateType), TypeInfoPropertyName = "AutomationRuleEvaluatorUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateAction), TypeInfoPropertyName = "AutomationRuleEvaluatorUpdateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorUpdateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPythonVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPythonVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageRole?), TypeInfoPropertyName = "NullableLlmAsJudgeMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaType?), TypeInfoPropertyName = "NullableLlmAsJudgeOutputSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterOperator?), TypeInfoPropertyName = "NullableSpanFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterOperator?), TypeInfoPropertyName = "NullableTraceFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterOperator?), TypeInfoPropertyName = "NullableTraceThreadFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteTriggerScope?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorWriteTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteAction?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorWriteAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorWriteDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessageWriteRole?), TypeInfoPropertyName = "NullableLlmAsJudgeMessageWriteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaWriteType?), TypeInfoPropertyName = "NullableLlmAsJudgeOutputSchemaWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterWriteOperator?), TypeInfoPropertyName = "NullableSpanFilterWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterWriteOperator?), TypeInfoPropertyName = "NullableTraceFilterWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterWriteOperator?), TypeInfoPropertyName = "NullableTraceThreadFilterWriteOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorObjectObjectPublicTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorObjectObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorObjectObjectPublicAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorObjectObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeMessagePublicRole?), TypeInfoPropertyName = "NullableLlmAsJudgeMessagePublicRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeOutputSchemaPublicType?), TypeInfoPropertyName = "NullableLlmAsJudgeOutputSchemaPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublicOperator?), TypeInfoPropertyName = "NullableSpanFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterPublicOperator?), TypeInfoPropertyName = "NullableTraceFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterPublicOperator?), TypeInfoPropertyName = "NullableTraceThreadFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicTriggerScope?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorPublicTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicAction?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorPublicAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogItemLevel?), TypeInfoPropertyName = "NullableLogItemLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateTriggerScope?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorUpdateTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateAction?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorUpdateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorUpdateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceThreadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeOutputSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceFilterWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanFilterWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceThreadFilterWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeOutputSchemaWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageContentWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ProjectReferencePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AutomationRuleEvaluatorObjectObjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceThreadFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessagePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeOutputSchemaPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageContentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LogItem>))]
    internal sealed partial class AutomationRuleEvaluatorsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutomationRuleEvaluatorsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AutomationRuleEvaluatorsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AutomationRuleEvaluatorsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Opik.LlmAsJudgeMessageRole)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeMessageRole?)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaType)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaType?)

                    || typeToConvert == typeof(global::Opik.SpanFilterOperator)

                    || typeToConvert == typeof(global::Opik.SpanFilterOperator?)

                    || typeToConvert == typeof(global::Opik.TraceFilterOperator)

                    || typeToConvert == typeof(global::Opik.TraceFilterOperator?)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterOperator)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterOperator?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteTriggerScope)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteTriggerScope?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteType?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteAction)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteAction?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeMessageWriteRole)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeMessageWriteRole?)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaWriteType)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaWriteType?)

                    || typeToConvert == typeof(global::Opik.SpanFilterWriteOperator)

                    || typeToConvert == typeof(global::Opik.SpanFilterWriteOperator?)

                    || typeToConvert == typeof(global::Opik.TraceFilterWriteOperator)

                    || typeToConvert == typeof(global::Opik.TraceFilterWriteOperator?)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterWriteOperator)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterWriteOperator?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicType?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeMessagePublicRole)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeMessagePublicRole?)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaPublicType)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaPublicType?)

                    || typeToConvert == typeof(global::Opik.SpanFilterPublicOperator)

                    || typeToConvert == typeof(global::Opik.SpanFilterPublicOperator?)

                    || typeToConvert == typeof(global::Opik.TraceFilterPublicOperator)

                    || typeToConvert == typeof(global::Opik.TraceFilterPublicOperator?)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterPublicOperator)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterPublicOperator?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicTriggerScope)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicTriggerScope?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicType?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicAction)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicAction?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.LogItemLevel)

                    || typeToConvert == typeof(global::Opik.LogItemLevel?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateTriggerScope)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateTriggerScope?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateType?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateAction)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateAction?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.LlmAsJudgeMessageRole))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeMessageRole?))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaType))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeOutputSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaType?))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeOutputSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanFilterOperator))
                {
                    return new global::Opik.JsonConverters.SpanFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanFilterOperator?))
                {
                    return new global::Opik.JsonConverters.SpanFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceFilterOperator))
                {
                    return new global::Opik.JsonConverters.TraceFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceFilterOperator?))
                {
                    return new global::Opik.JsonConverters.TraceFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadFilterOperator))
                {
                    return new global::Opik.JsonConverters.TraceThreadFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadFilterOperator?))
                {
                    return new global::Opik.JsonConverters.TraceThreadFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteTriggerScope))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteTriggerScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteTriggerScope?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteTriggerScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteAction))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteAction?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorWriteDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeMessageWriteRole))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeMessageWriteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeMessageWriteRole?))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeMessageWriteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaWriteType))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeOutputSchemaWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaWriteType?))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeOutputSchemaWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanFilterWriteOperator))
                {
                    return new global::Opik.JsonConverters.SpanFilterWriteOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanFilterWriteOperator?))
                {
                    return new global::Opik.JsonConverters.SpanFilterWriteOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceFilterWriteOperator))
                {
                    return new global::Opik.JsonConverters.TraceFilterWriteOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceFilterWriteOperator?))
                {
                    return new global::Opik.JsonConverters.TraceFilterWriteOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadFilterWriteOperator))
                {
                    return new global::Opik.JsonConverters.TraceThreadFilterWriteOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadFilterWriteOperator?))
                {
                    return new global::Opik.JsonConverters.TraceThreadFilterWriteOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTriggerScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTriggerScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeMessagePublicRole))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeMessagePublicRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeMessagePublicRole?))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeMessagePublicRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaPublicType))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeOutputSchemaPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LlmAsJudgeOutputSchemaPublicType?))
                {
                    return new global::Opik.JsonConverters.LlmAsJudgeOutputSchemaPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanFilterPublicOperator))
                {
                    return new global::Opik.JsonConverters.SpanFilterPublicOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanFilterPublicOperator?))
                {
                    return new global::Opik.JsonConverters.SpanFilterPublicOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceFilterPublicOperator))
                {
                    return new global::Opik.JsonConverters.TraceFilterPublicOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceFilterPublicOperator?))
                {
                    return new global::Opik.JsonConverters.TraceFilterPublicOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadFilterPublicOperator))
                {
                    return new global::Opik.JsonConverters.TraceThreadFilterPublicOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadFilterPublicOperator?))
                {
                    return new global::Opik.JsonConverters.TraceThreadFilterPublicOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicTriggerScope))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicTriggerScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicTriggerScope?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicTriggerScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicAction))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicAction?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorPublicDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LogItemLevel))
                {
                    return new global::Opik.JsonConverters.LogItemLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LogItemLevel?))
                {
                    return new global::Opik.JsonConverters.LogItemLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateTriggerScope))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateTriggerScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateTriggerScope?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateTriggerScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateAction))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateAction?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateDiscriminatorTypeNullableJsonConverter();
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
                    0 => new AutomationRuleEvaluatorsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}