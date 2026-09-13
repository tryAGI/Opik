
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.EvaluatorItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExecutionPolicyPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemPublicType), TypeInfoPropertyName = "EvaluatorItemPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemChangesPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetItemFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemFilterOperator), TypeInfoPropertyName = "DatasetItemFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.EvaluatorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExecutionPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemType), TypeInfoPropertyName = "EvaluatorItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetWriteType), TypeInfoPropertyName = "DatasetWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetWriteVisibility), TypeInfoPropertyName = "DatasetWriteVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemSource), TypeInfoPropertyName = "DatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString), TypeInfoPropertyName = "JsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemTraceVisibilityMode), TypeInfoPropertyName = "ExperimentItemTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemStatus), TypeInfoPropertyName = "ExperimentItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryStatus), TypeInfoPropertyName = "ExperimentRunSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreSource), TypeInfoPropertyName = "FeedbackScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntrySource), TypeInfoPropertyName = "ValueEntrySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetItemWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemWriteSource), TypeInfoPropertyName = "DatasetItemWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.EvaluatorItemWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExecutionPolicyWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemWriteType), TypeInfoPropertyName = "EvaluatorItemWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromSpansRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanEnrichmentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromTracesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceEnrichmentOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemsDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetExpansionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetExpansionWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ColumnCompareType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnCompareType), TypeInfoPropertyName = "ColumnCompareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CommentCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemPageCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetItemCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ColumnCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemCompareSource), TypeInfoPropertyName = "DatasetItemCompareSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.EvaluatorItemCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExecutionPolicyCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentItemCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemCompareType), TypeInfoPropertyName = "EvaluatorItemCompareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringCompare), TypeInfoPropertyName = "JsonListStringCompare2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.CommentCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemCompareTraceVisibilityMode), TypeInfoPropertyName = "ExperimentItemCompareTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AssertionResultCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemCompareStatus), TypeInfoPropertyName = "ExperimentItemCompareStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryCompareStatus), TypeInfoPropertyName = "ExperimentRunSummaryCompareStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreCompareSource), TypeInfoPropertyName = "FeedbackScoreCompareSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryCompare))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryCompareSource), TypeInfoPropertyName = "ValueEntryCompareSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionSummaryPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicType), TypeInfoPropertyName = "DatasetPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicVisibility), TypeInfoPropertyName = "DatasetPublicVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicStatus), TypeInfoPropertyName = "DatasetPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetIdentifierPublic))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetExportJobPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetExportJobPublicStatus), TypeInfoPropertyName = "DatasetExportJobPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemPublicSource), TypeInfoPropertyName = "DatasetItemPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode), TypeInfoPropertyName = "ExperimentItemPublicTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryPublicStatus), TypeInfoPropertyName = "ExperimentRunSummaryPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ColumnPublicType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnPublicType), TypeInfoPropertyName = "ColumnPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ColumnPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Column))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ColumnType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnType), TypeInfoPropertyName = "ColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PageColumns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetUpdateVisibility), TypeInfoPropertyName = "DatasetUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionDiff))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionDiffStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetVersionPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionRestorePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionRetrieveRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionUpdatePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromCsvRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromJsonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat), TypeInfoPropertyName = "CreateDatasetItemsFromJsonRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetExportJobPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>), TypeInfoPropertyName = "AnyOfDatasetItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemPublicType?), TypeInfoPropertyName = "NullableEvaluatorItemPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemFilterOperator?), TypeInfoPropertyName = "NullableDatasetItemFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemType?), TypeInfoPropertyName = "NullableEvaluatorItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetWriteType?), TypeInfoPropertyName = "NullableDatasetWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetWriteVisibility?), TypeInfoPropertyName = "NullableDatasetWriteVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemSource?), TypeInfoPropertyName = "NullableDatasetItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListString?), TypeInfoPropertyName = "NullableJsonListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemTraceVisibilityMode?), TypeInfoPropertyName = "NullableExperimentItemTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemStatus?), TypeInfoPropertyName = "NullableExperimentItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryStatus?), TypeInfoPropertyName = "NullableExperimentRunSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreSource?), TypeInfoPropertyName = "NullableFeedbackScoreSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntrySource?), TypeInfoPropertyName = "NullableValueEntrySource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemWriteSource?), TypeInfoPropertyName = "NullableDatasetItemWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemWriteType?), TypeInfoPropertyName = "NullableEvaluatorItemWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnCompareType?), TypeInfoPropertyName = "NullableColumnCompareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemCompareSource?), TypeInfoPropertyName = "NullableDatasetItemCompareSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemCompareType?), TypeInfoPropertyName = "NullableEvaluatorItemCompareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringCompare?), TypeInfoPropertyName = "NullableJsonListStringCompare2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemCompareTraceVisibilityMode?), TypeInfoPropertyName = "NullableExperimentItemCompareTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemCompareStatus?), TypeInfoPropertyName = "NullableExperimentItemCompareStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryCompareStatus?), TypeInfoPropertyName = "NullableExperimentRunSummaryCompareStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreCompareSource?), TypeInfoPropertyName = "NullableFeedbackScoreCompareSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValueEntryCompareSource?), TypeInfoPropertyName = "NullableValueEntryCompareSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicType?), TypeInfoPropertyName = "NullableDatasetPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicVisibility?), TypeInfoPropertyName = "NullableDatasetPublicVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicStatus?), TypeInfoPropertyName = "NullableDatasetPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublicType?), TypeInfoPropertyName = "NullableProjectStatItemObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType?), TypeInfoPropertyName = "NullableProjectStatItemObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetExportJobPublicStatus?), TypeInfoPropertyName = "NullableDatasetExportJobPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemPublicSource?), TypeInfoPropertyName = "NullableDatasetItemPublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode?), TypeInfoPropertyName = "NullableExperimentItemPublicTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentRunSummaryPublicStatus?), TypeInfoPropertyName = "NullableExperimentRunSummaryPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnPublicType?), TypeInfoPropertyName = "NullableColumnPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ColumnType?), TypeInfoPropertyName = "NullableColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetUpdateVisibility?), TypeInfoPropertyName = "NullableDatasetUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat?), TypeInfoPropertyName = "NullableCreateDatasetItemsFromJsonRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>?), TypeInfoPropertyName = "NullableAnyOfDatasetItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.EvaluatorItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetItemFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.EvaluatorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetItemWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.EvaluatorItemWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ColumnCompareType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetItemCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ColumnCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.EvaluatorItemCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentItemCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.CommentCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionResultCompare>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ProjectStatItemObjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ColumnPublicType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ColumnPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ColumnType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Column>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetVersionPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetExportJobPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>))]
    internal sealed partial class DatasetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringCompareJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.DatasetItem, global::Opik.ErrorMessage>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ExperimentItem, global::Opik.ErrorMessage>());
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
                    typeToConvert == typeof(global::Opik.EvaluatorItemPublicType)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemPublicType?)

                    || typeToConvert == typeof(global::Opik.DatasetItemFilterOperator)

                    || typeToConvert == typeof(global::Opik.DatasetItemFilterOperator?)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemType)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemType?)

                    || typeToConvert == typeof(global::Opik.DatasetWriteType)

                    || typeToConvert == typeof(global::Opik.DatasetWriteType?)

                    || typeToConvert == typeof(global::Opik.DatasetWriteVisibility)

                    || typeToConvert == typeof(global::Opik.DatasetWriteVisibility?)

                    || typeToConvert == typeof(global::Opik.DatasetItemSource)

                    || typeToConvert == typeof(global::Opik.DatasetItemSource?)

                    || typeToConvert == typeof(global::Opik.ExperimentItemTraceVisibilityMode)

                    || typeToConvert == typeof(global::Opik.ExperimentItemTraceVisibilityMode?)

                    || typeToConvert == typeof(global::Opik.ExperimentItemStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentItemStatus?)

                    || typeToConvert == typeof(global::Opik.ExperimentRunSummaryStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentRunSummaryStatus?)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreSource?)

                    || typeToConvert == typeof(global::Opik.ValueEntrySource)

                    || typeToConvert == typeof(global::Opik.ValueEntrySource?)

                    || typeToConvert == typeof(global::Opik.DatasetItemWriteSource)

                    || typeToConvert == typeof(global::Opik.DatasetItemWriteSource?)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemWriteType)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemWriteType?)

                    || typeToConvert == typeof(global::Opik.ColumnCompareType)

                    || typeToConvert == typeof(global::Opik.ColumnCompareType?)

                    || typeToConvert == typeof(global::Opik.DatasetItemCompareSource)

                    || typeToConvert == typeof(global::Opik.DatasetItemCompareSource?)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemCompareType)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemCompareType?)

                    || typeToConvert == typeof(global::Opik.ExperimentItemCompareTraceVisibilityMode)

                    || typeToConvert == typeof(global::Opik.ExperimentItemCompareTraceVisibilityMode?)

                    || typeToConvert == typeof(global::Opik.ExperimentItemCompareStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentItemCompareStatus?)

                    || typeToConvert == typeof(global::Opik.ExperimentRunSummaryCompareStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentRunSummaryCompareStatus?)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreCompareSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreCompareSource?)

                    || typeToConvert == typeof(global::Opik.ValueEntryCompareSource)

                    || typeToConvert == typeof(global::Opik.ValueEntryCompareSource?)

                    || typeToConvert == typeof(global::Opik.DatasetPublicType)

                    || typeToConvert == typeof(global::Opik.DatasetPublicType?)

                    || typeToConvert == typeof(global::Opik.DatasetPublicVisibility)

                    || typeToConvert == typeof(global::Opik.DatasetPublicVisibility?)

                    || typeToConvert == typeof(global::Opik.DatasetPublicStatus)

                    || typeToConvert == typeof(global::Opik.DatasetPublicStatus?)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicType)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicType?)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.ProjectStatItemObjectPublicDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.DatasetExportJobPublicStatus)

                    || typeToConvert == typeof(global::Opik.DatasetExportJobPublicStatus?)

                    || typeToConvert == typeof(global::Opik.DatasetItemPublicSource)

                    || typeToConvert == typeof(global::Opik.DatasetItemPublicSource?)

                    || typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode)

                    || typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode?)

                    || typeToConvert == typeof(global::Opik.ExperimentRunSummaryPublicStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentRunSummaryPublicStatus?)

                    || typeToConvert == typeof(global::Opik.ColumnPublicType)

                    || typeToConvert == typeof(global::Opik.ColumnPublicType?)

                    || typeToConvert == typeof(global::Opik.ColumnType)

                    || typeToConvert == typeof(global::Opik.ColumnType?)

                    || typeToConvert == typeof(global::Opik.DatasetUpdateVisibility)

                    || typeToConvert == typeof(global::Opik.DatasetUpdateVisibility?)

                    || typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat)

                    || typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.EvaluatorItemPublicType))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.EvaluatorItemPublicType?))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemFilterOperator))
                {
                    return new global::Opik.JsonConverters.DatasetItemFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemFilterOperator?))
                {
                    return new global::Opik.JsonConverters.DatasetItemFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.EvaluatorItemType))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.EvaluatorItemType?))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetWriteType))
                {
                    return new global::Opik.JsonConverters.DatasetWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetWriteType?))
                {
                    return new global::Opik.JsonConverters.DatasetWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetWriteVisibility))
                {
                    return new global::Opik.JsonConverters.DatasetWriteVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetWriteVisibility?))
                {
                    return new global::Opik.JsonConverters.DatasetWriteVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemSource))
                {
                    return new global::Opik.JsonConverters.DatasetItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemSource?))
                {
                    return new global::Opik.JsonConverters.DatasetItemSourceNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Opik.ExperimentRunSummaryStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentRunSummaryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentRunSummaryStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentRunSummaryStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.DatasetItemWriteSource))
                {
                    return new global::Opik.JsonConverters.DatasetItemWriteSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemWriteSource?))
                {
                    return new global::Opik.JsonConverters.DatasetItemWriteSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.EvaluatorItemWriteType))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.EvaluatorItemWriteType?))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ColumnCompareType))
                {
                    return new global::Opik.JsonConverters.ColumnCompareTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ColumnCompareType?))
                {
                    return new global::Opik.JsonConverters.ColumnCompareTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemCompareSource))
                {
                    return new global::Opik.JsonConverters.DatasetItemCompareSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemCompareSource?))
                {
                    return new global::Opik.JsonConverters.DatasetItemCompareSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.EvaluatorItemCompareType))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemCompareTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.EvaluatorItemCompareType?))
                {
                    return new global::Opik.JsonConverters.EvaluatorItemCompareTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemCompareTraceVisibilityMode))
                {
                    return new global::Opik.JsonConverters.ExperimentItemCompareTraceVisibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemCompareTraceVisibilityMode?))
                {
                    return new global::Opik.JsonConverters.ExperimentItemCompareTraceVisibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemCompareStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentItemCompareStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemCompareStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentItemCompareStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentRunSummaryCompareStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentRunSummaryCompareStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentRunSummaryCompareStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentRunSummaryCompareStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreCompareSource))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreCompareSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreCompareSource?))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreCompareSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntryCompareSource))
                {
                    return new global::Opik.JsonConverters.ValueEntryCompareSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ValueEntryCompareSource?))
                {
                    return new global::Opik.JsonConverters.ValueEntryCompareSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetPublicType))
                {
                    return new global::Opik.JsonConverters.DatasetPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetPublicType?))
                {
                    return new global::Opik.JsonConverters.DatasetPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetPublicVisibility))
                {
                    return new global::Opik.JsonConverters.DatasetPublicVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetPublicVisibility?))
                {
                    return new global::Opik.JsonConverters.DatasetPublicVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetPublicStatus))
                {
                    return new global::Opik.JsonConverters.DatasetPublicStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetPublicStatus?))
                {
                    return new global::Opik.JsonConverters.DatasetPublicStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.DatasetExportJobPublicStatus))
                {
                    return new global::Opik.JsonConverters.DatasetExportJobPublicStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetExportJobPublicStatus?))
                {
                    return new global::Opik.JsonConverters.DatasetExportJobPublicStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemPublicSource))
                {
                    return new global::Opik.JsonConverters.DatasetItemPublicSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetItemPublicSource?))
                {
                    return new global::Opik.JsonConverters.DatasetItemPublicSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode))
                {
                    return new global::Opik.JsonConverters.ExperimentItemPublicTraceVisibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentItemPublicTraceVisibilityMode?))
                {
                    return new global::Opik.JsonConverters.ExperimentItemPublicTraceVisibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentRunSummaryPublicStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentRunSummaryPublicStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentRunSummaryPublicStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentRunSummaryPublicStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ColumnPublicType))
                {
                    return new global::Opik.JsonConverters.ColumnPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ColumnPublicType?))
                {
                    return new global::Opik.JsonConverters.ColumnPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ColumnType))
                {
                    return new global::Opik.JsonConverters.ColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ColumnType?))
                {
                    return new global::Opik.JsonConverters.ColumnTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetUpdateVisibility))
                {
                    return new global::Opik.JsonConverters.DatasetUpdateVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetUpdateVisibility?))
                {
                    return new global::Opik.JsonConverters.DatasetUpdateVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat))
                {
                    return new global::Opik.JsonConverters.CreateDatasetItemsFromJsonRequestFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat?))
                {
                    return new global::Opik.JsonConverters.CreateDatasetItemsFromJsonRequestFormatNullableJsonConverter();
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
                    0 => new DatasetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}