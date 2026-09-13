
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigPublicType), TypeInfoPropertyName = "AlertTriggerConfigPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerPublicEventType), TypeInfoPropertyName = "AlertTriggerPublicEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPublicAlertType), TypeInfoPropertyName = "AlertPublicAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAveragePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublicOperator), TypeInfoPropertyName = "SpanFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterPublicOperator), TypeInfoPropertyName = "TraceFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterPublicOperator), TypeInfoPropertyName = "TraceThreadFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicType), TypeInfoPropertyName = "DashboardPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicScope), TypeInfoPropertyName = "DashboardPublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DashboardPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionSummaryPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicType), TypeInfoPropertyName = "DatasetPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicVisibility), TypeInfoPropertyName = "DatasetPublicVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicStatus), TypeInfoPropertyName = "DatasetPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValuesPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublicTemplateStructure), TypeInfoPropertyName = "PromptPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorCountWithDeviation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectWriteVisibility), TypeInfoPropertyName = "ProjectWriteVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ProjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectPublicVisibility), TypeInfoPropertyName = "ProjectPublicVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreNames))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ScoreName>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ScoreName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TokenUsageNames))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.KpiCardResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.KpiMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.KpiMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.KpiMetricType), TypeInfoPropertyName = "KpiMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.KpiCardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.KpiCardRequestEntityType), TypeInfoPropertyName = "KpiCardRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DataPointNumberPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricResponsePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricResponsePublicMetricType), TypeInfoPropertyName = "ProjectMetricResponsePublicMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricResponsePublicInterval), TypeInfoPropertyName = "ProjectMetricResponsePublicInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ResultsNumberPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ResultsNumberPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DataPointNumberPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BreakdownConfigPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BreakdownConfigPublicField), TypeInfoPropertyName = "BreakdownConfigPublicField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricRequestPublicMetricType), TypeInfoPropertyName = "ProjectMetricRequestPublicMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricRequestPublicInterval), TypeInfoPropertyName = "ProjectMetricRequestPublicInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatsSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ProjectStatsSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectStatsSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorCountWithDeviationDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAverageDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValuesDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectDetailedVisibility), TypeInfoPropertyName = "ProjectDetailedVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverageDetailed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessageDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectRetrieveDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectUpdateVisibility), TypeInfoPropertyName = "ProjectUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityItemPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityItemPublicType), TypeInfoPropertyName = "RecentActivityItemPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.RecentActivityItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigPublicType?), TypeInfoPropertyName = "NullableAlertTriggerConfigPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerPublicEventType?), TypeInfoPropertyName = "NullableAlertTriggerPublicEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPublicAlertType?), TypeInfoPropertyName = "NullableAlertPublicAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilterPublicOperator?), TypeInfoPropertyName = "NullableSpanFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilterPublicOperator?), TypeInfoPropertyName = "NullableTraceFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilterPublicOperator?), TypeInfoPropertyName = "NullableTraceThreadFilterPublicOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicType?), TypeInfoPropertyName = "NullableDashboardPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicScope?), TypeInfoPropertyName = "NullableDashboardPublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicType?), TypeInfoPropertyName = "NullableDatasetPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicVisibility?), TypeInfoPropertyName = "NullableDatasetPublicVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetPublicStatus?), TypeInfoPropertyName = "NullableDatasetPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringPublic?), TypeInfoPropertyName = "NullableJsonListStringPublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicType?), TypeInfoPropertyName = "NullableExperimentPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicEvaluationMethod?), TypeInfoPropertyName = "NullableExperimentPublicEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentPublicStatus?), TypeInfoPropertyName = "NullableExperimentPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationPublicStatus?), TypeInfoPropertyName = "NullableOptimizationPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublicTemplateStructure?), TypeInfoPropertyName = "NullablePromptPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectWriteVisibility?), TypeInfoPropertyName = "NullableProjectWriteVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectPublicVisibility?), TypeInfoPropertyName = "NullableProjectPublicVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.KpiMetricType?), TypeInfoPropertyName = "NullableKpiMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.KpiCardRequestEntityType?), TypeInfoPropertyName = "NullableKpiCardRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricResponsePublicMetricType?), TypeInfoPropertyName = "NullableProjectMetricResponsePublicMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricResponsePublicInterval?), TypeInfoPropertyName = "NullableProjectMetricResponsePublicInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BreakdownConfigPublicField?), TypeInfoPropertyName = "NullableBreakdownConfigPublicField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricRequestPublicMetricType?), TypeInfoPropertyName = "NullableProjectMetricRequestPublicMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectMetricRequestPublicInterval?), TypeInfoPropertyName = "NullableProjectMetricRequestPublicInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectDetailedVisibility?), TypeInfoPropertyName = "NullableProjectDetailedVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectUpdateVisibility?), TypeInfoPropertyName = "NullableProjectUpdateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityItemPublicType?), TypeInfoPropertyName = "NullableRecentActivityItemPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerConfigPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceThreadFilterPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DashboardPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.CommentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentScorePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionLinkPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.OptimizationPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMetricPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMessagePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ProjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ScoreName>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.KpiMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ResultsNumberPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DataPointNumberPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ProjectStatsSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAverageDetailed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.RecentActivityItemPublic>))]
    internal sealed partial class ProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringPublicJsonConverter());
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
                    typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType?)

                    || typeToConvert == typeof(global::Opik.AlertPublicAlertType)

                    || typeToConvert == typeof(global::Opik.AlertPublicAlertType?)

                    || typeToConvert == typeof(global::Opik.SpanFilterPublicOperator)

                    || typeToConvert == typeof(global::Opik.SpanFilterPublicOperator?)

                    || typeToConvert == typeof(global::Opik.TraceFilterPublicOperator)

                    || typeToConvert == typeof(global::Opik.TraceFilterPublicOperator?)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterPublicOperator)

                    || typeToConvert == typeof(global::Opik.TraceThreadFilterPublicOperator?)

                    || typeToConvert == typeof(global::Opik.DashboardPublicType)

                    || typeToConvert == typeof(global::Opik.DashboardPublicType?)

                    || typeToConvert == typeof(global::Opik.DashboardPublicScope)

                    || typeToConvert == typeof(global::Opik.DashboardPublicScope?)

                    || typeToConvert == typeof(global::Opik.DatasetPublicType)

                    || typeToConvert == typeof(global::Opik.DatasetPublicType?)

                    || typeToConvert == typeof(global::Opik.DatasetPublicVisibility)

                    || typeToConvert == typeof(global::Opik.DatasetPublicVisibility?)

                    || typeToConvert == typeof(global::Opik.DatasetPublicStatus)

                    || typeToConvert == typeof(global::Opik.DatasetPublicStatus?)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicType)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicType?)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicEvaluationMethod)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicEvaluationMethod?)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentPublicStatus?)

                    || typeToConvert == typeof(global::Opik.OptimizationPublicStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationPublicStatus?)

                    || typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.ProjectWriteVisibility)

                    || typeToConvert == typeof(global::Opik.ProjectWriteVisibility?)

                    || typeToConvert == typeof(global::Opik.ProjectPublicVisibility)

                    || typeToConvert == typeof(global::Opik.ProjectPublicVisibility?)

                    || typeToConvert == typeof(global::Opik.KpiMetricType)

                    || typeToConvert == typeof(global::Opik.KpiMetricType?)

                    || typeToConvert == typeof(global::Opik.KpiCardRequestEntityType)

                    || typeToConvert == typeof(global::Opik.KpiCardRequestEntityType?)

                    || typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicMetricType)

                    || typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicMetricType?)

                    || typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicInterval)

                    || typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicInterval?)

                    || typeToConvert == typeof(global::Opik.BreakdownConfigPublicField)

                    || typeToConvert == typeof(global::Opik.BreakdownConfigPublicField?)

                    || typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicMetricType)

                    || typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicMetricType?)

                    || typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicInterval)

                    || typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicInterval?)

                    || typeToConvert == typeof(global::Opik.ProjectDetailedVisibility)

                    || typeToConvert == typeof(global::Opik.ProjectDetailedVisibility?)

                    || typeToConvert == typeof(global::Opik.ProjectUpdateVisibility)

                    || typeToConvert == typeof(global::Opik.ProjectUpdateVisibility?)

                    || typeToConvert == typeof(global::Opik.RecentActivityItemPublicType)

                    || typeToConvert == typeof(global::Opik.RecentActivityItemPublicType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerPublicEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerPublicEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertPublicAlertType))
                {
                    return new global::Opik.JsonConverters.AlertPublicAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertPublicAlertType?))
                {
                    return new global::Opik.JsonConverters.AlertPublicAlertTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.DashboardPublicType))
                {
                    return new global::Opik.JsonConverters.DashboardPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DashboardPublicType?))
                {
                    return new global::Opik.JsonConverters.DashboardPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DashboardPublicScope))
                {
                    return new global::Opik.JsonConverters.DashboardPublicScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DashboardPublicScope?))
                {
                    return new global::Opik.JsonConverters.DashboardPublicScopeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.OptimizationPublicStatus))
                {
                    return new global::Opik.JsonConverters.OptimizationPublicStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationPublicStatus?))
                {
                    return new global::Opik.JsonConverters.OptimizationPublicStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptPublicTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptPublicTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectWriteVisibility))
                {
                    return new global::Opik.JsonConverters.ProjectWriteVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectWriteVisibility?))
                {
                    return new global::Opik.JsonConverters.ProjectWriteVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectPublicVisibility))
                {
                    return new global::Opik.JsonConverters.ProjectPublicVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectPublicVisibility?))
                {
                    return new global::Opik.JsonConverters.ProjectPublicVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.KpiMetricType))
                {
                    return new global::Opik.JsonConverters.KpiMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.KpiMetricType?))
                {
                    return new global::Opik.JsonConverters.KpiMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.KpiCardRequestEntityType))
                {
                    return new global::Opik.JsonConverters.KpiCardRequestEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.KpiCardRequestEntityType?))
                {
                    return new global::Opik.JsonConverters.KpiCardRequestEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicMetricType))
                {
                    return new global::Opik.JsonConverters.ProjectMetricResponsePublicMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicMetricType?))
                {
                    return new global::Opik.JsonConverters.ProjectMetricResponsePublicMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicInterval))
                {
                    return new global::Opik.JsonConverters.ProjectMetricResponsePublicIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricResponsePublicInterval?))
                {
                    return new global::Opik.JsonConverters.ProjectMetricResponsePublicIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BreakdownConfigPublicField))
                {
                    return new global::Opik.JsonConverters.BreakdownConfigPublicFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BreakdownConfigPublicField?))
                {
                    return new global::Opik.JsonConverters.BreakdownConfigPublicFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicMetricType))
                {
                    return new global::Opik.JsonConverters.ProjectMetricRequestPublicMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicMetricType?))
                {
                    return new global::Opik.JsonConverters.ProjectMetricRequestPublicMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicInterval))
                {
                    return new global::Opik.JsonConverters.ProjectMetricRequestPublicIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectMetricRequestPublicInterval?))
                {
                    return new global::Opik.JsonConverters.ProjectMetricRequestPublicIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectDetailedVisibility))
                {
                    return new global::Opik.JsonConverters.ProjectDetailedVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectDetailedVisibility?))
                {
                    return new global::Opik.JsonConverters.ProjectDetailedVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectUpdateVisibility))
                {
                    return new global::Opik.JsonConverters.ProjectUpdateVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectUpdateVisibility?))
                {
                    return new global::Opik.JsonConverters.ProjectUpdateVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RecentActivityItemPublicType))
                {
                    return new global::Opik.JsonConverters.RecentActivityItemPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RecentActivityItemPublicType?))
                {
                    return new global::Opik.JsonConverters.RecentActivityItemPublicTypeNullableJsonConverter();
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
                    0 => new ProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}