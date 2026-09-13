
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAveragePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExecutionPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString), TypeInfoPropertyName = "JsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemTraceVisibilityMode), TypeInfoPropertyName = "ExperimentItemTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemStatus), TypeInfoPropertyName = "ExperimentItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreSource), TypeInfoPropertyName = "FeedbackScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntrySource), TypeInfoPropertyName = "ValueEntrySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionSummaryPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValuesPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode), TypeInfoPropertyName = "ExperimentItemPublicTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateType), TypeInfoPropertyName = "ExperimentUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateStatus), TypeInfoPropertyName = "ExperimentUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentScoreWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringWrite), TypeInfoPropertyName = "JsonListStringWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteType), TypeInfoPropertyName = "ExperimentWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteEvaluationMethod), TypeInfoPropertyName = "ExperimentWriteEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteStatus), TypeInfoPropertyName = "ExperimentWriteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentScoreWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionLinkWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemsBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemsDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteIdsHolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVariant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.JsonNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfoExperimentItemBulkWriteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringExperimentItemBulkWriteView), TypeInfoPropertyName = "JsonListStringExperimentItemBulkWriteView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceExperimentItemBulkWriteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanExperimentItemBulkWriteView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanExperimentItemBulkWriteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreExperimentItemBulkWriteView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreExperimentItemBulkWriteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemBulkUploadExperimentItemBulkWriteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource), TypeInfoPropertyName = "FeedbackScoreExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryExperimentItemBulkWriteView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryExperimentItemBulkWriteView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanExperimentItemBulkWriteViewType), TypeInfoPropertyName = "SpanExperimentItemBulkWriteViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanExperimentItemBulkWriteViewSource), TypeInfoPropertyName = "SpanExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceExperimentItemBulkWriteViewSource), TypeInfoPropertyName = "TraceExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryExperimentItemBulkWriteViewSource), TypeInfoPropertyName = "ValueEntryExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionScoreAveragePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CommentPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentScorePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringPublic), TypeInfoPropertyName = "JsonListStringPublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicType), TypeInfoPropertyName = "ExperimentPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicEvaluationMethod), TypeInfoPropertyName = "ExperimentPublicEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.CommentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicStatus), TypeInfoPropertyName = "ExperimentPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentScorePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionLinkPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AssertionScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreNamesPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ScoreNamePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreNamePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentGroupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GroupContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GroupDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GroupDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.GroupDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AggregationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentGroupAggregationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContentWithAggregations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GroupContentWithAggregations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentStreamRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>), TypeInfoPropertyName = "AnyOfExperimentItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>), TypeInfoPropertyName = "AnyOfExperimentPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString?), TypeInfoPropertyName = "NullableJsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemTraceVisibilityMode?), TypeInfoPropertyName = "NullableExperimentItemTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemStatus?), TypeInfoPropertyName = "NullableExperimentItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreSource?), TypeInfoPropertyName = "NullableFeedbackScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntrySource?), TypeInfoPropertyName = "NullableValueEntrySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode?), TypeInfoPropertyName = "NullableExperimentItemPublicTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateType?), TypeInfoPropertyName = "NullableExperimentUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateStatus?), TypeInfoPropertyName = "NullableExperimentUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringWrite?), TypeInfoPropertyName = "NullableJsonListStringWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteType?), TypeInfoPropertyName = "NullableExperimentWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteEvaluationMethod?), TypeInfoPropertyName = "NullableExperimentWriteEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteStatus?), TypeInfoPropertyName = "NullableExperimentWriteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringExperimentItemBulkWriteView?), TypeInfoPropertyName = "NullableJsonListStringExperimentItemBulkWriteView2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource?), TypeInfoPropertyName = "NullableFeedbackScoreExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanExperimentItemBulkWriteViewType?), TypeInfoPropertyName = "NullableSpanExperimentItemBulkWriteViewType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanExperimentItemBulkWriteViewSource?), TypeInfoPropertyName = "NullableSpanExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceExperimentItemBulkWriteViewSource?), TypeInfoPropertyName = "NullableTraceExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryExperimentItemBulkWriteViewSource?), TypeInfoPropertyName = "NullableValueEntryExperimentItemBulkWriteViewSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringPublic?), TypeInfoPropertyName = "NullableJsonListStringPublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicType?), TypeInfoPropertyName = "NullableExperimentPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicEvaluationMethod?), TypeInfoPropertyName = "NullableExperimentPublicEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicStatus?), TypeInfoPropertyName = "NullableExperimentPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>?), TypeInfoPropertyName = "NullableAnyOfExperimentItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>?), TypeInfoPropertyName = "NullableAnyOfExperimentPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentScoreWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionLinkWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanExperimentItemBulkWriteView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreExperimentItemBulkWriteView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.CommentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentScorePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionLinkPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ScoreNamePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.GroupDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>))]
    internal sealed partial class ExperimentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExperimentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ExperimentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ExperimentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringExperimentItemBulkWriteViewJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringPublicJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ExperimentItem, global::Opik.ErrorMessage>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>());
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
                    typeToConvert == typeof(global::Opik.ExperimentItemTraceVisibilityMode)

                    || typeToConvert == typeof(global::Opik.ExperimentItemTraceVisibilityMode?)

                    || typeToConvert == typeof(global::Opik.ExperimentItemStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentItemStatus?)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreSource?)

                    || typeToConvert == typeof(global::Opik.ValueEntrySource)

                    || typeToConvert == typeof(global::Opik.ValueEntrySource?)

                    || typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode)

                    || typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode?)

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateType)

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateType?)

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateStatus?)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteType)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteType?)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteEvaluationMethod)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteEvaluationMethod?)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteStatus?)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource?)

                    || typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewType)

                    || typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewType?)

                    || typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewSource)

                    || typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewSource?)

                    || typeToConvert == typeof(global::Opik.TraceExperimentItemBulkWriteViewSource)

                    || typeToConvert == typeof(global::Opik.TraceExperimentItemBulkWriteViewSource?)

                    || typeToConvert == typeof(global::Opik.ValueEntryExperimentItemBulkWriteViewSource)

                    || typeToConvert == typeof(global::Opik.ValueEntryExperimentItemBulkWriteViewSource?)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicType)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicType?)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicEvaluationMethod)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicEvaluationMethod?)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.ExperimentItemTraceVisibilityMode))
                {
                    return new global::Opik.JsonConverters.ExperimentItemTraceVisibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemTraceVisibilityMode?))
                {
                    return new global::Opik.JsonConverters.ExperimentItemTraceVisibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentItemStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode))
                {
                    return new global::Opik.JsonConverters.ExperimentItemPublicTraceVisibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode?))
                {
                    return new global::Opik.JsonConverters.ExperimentItemPublicTraceVisibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentUpdateType))
                {
                    return new global::Opik.JsonConverters.ExperimentUpdateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentUpdateType?))
                {
                    return new global::Opik.JsonConverters.ExperimentUpdateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentUpdateStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentUpdateStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentUpdateStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentUpdateStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentWriteType))
                {
                    return new global::Opik.JsonConverters.ExperimentWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentWriteType?))
                {
                    return new global::Opik.JsonConverters.ExperimentWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentWriteEvaluationMethod))
                {
                    return new global::Opik.JsonConverters.ExperimentWriteEvaluationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentWriteEvaluationMethod?))
                {
                    return new global::Opik.JsonConverters.ExperimentWriteEvaluationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentWriteStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentWriteStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentWriteStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentWriteStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreExperimentItemBulkWriteViewSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource?))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreExperimentItemBulkWriteViewSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewType))
                {
                    return new global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewType?))
                {
                    return new global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewSource))
                {
                    return new global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanExperimentItemBulkWriteViewSource?))
                {
                    return new global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceExperimentItemBulkWriteViewSource))
                {
                    return new global::Opik.JsonConverters.TraceExperimentItemBulkWriteViewSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceExperimentItemBulkWriteViewSource?))
                {
                    return new global::Opik.JsonConverters.TraceExperimentItemBulkWriteViewSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntryExperimentItemBulkWriteViewSource))
                {
                    return new global::Opik.JsonConverters.ValueEntryExperimentItemBulkWriteViewSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntryExperimentItemBulkWriteViewSource?))
                {
                    return new global::Opik.JsonConverters.ValueEntryExperimentItemBulkWriteViewSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentPublicType))
                {
                    return new global::Opik.JsonConverters.ExperimentPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentPublicType?))
                {
                    return new global::Opik.JsonConverters.ExperimentPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentPublicEvaluationMethod))
                {
                    return new global::Opik.JsonConverters.ExperimentPublicEvaluationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentPublicEvaluationMethod?))
                {
                    return new global::Opik.JsonConverters.ExperimentPublicEvaluationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentPublicStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentPublicStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentPublicStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentPublicStatusNullableJsonConverter();
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
                    0 => new ExperimentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}