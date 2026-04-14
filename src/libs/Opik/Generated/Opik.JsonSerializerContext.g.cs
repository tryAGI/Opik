
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
            typeof(global::Opik.JsonConverters.AgentBlueprintWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AgentBlueprintWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AgentConfigValueWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AgentConfigValueWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AgentBlueprintPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AgentBlueprintPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AgentConfigValuePublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AgentConfigValuePublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AgentBlueprintHistoryTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AgentBlueprintHistoryTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AgentConfigValueHistoryTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AgentConfigValueHistoryTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertAlertTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertAlertTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerEventTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerEventTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerConfigTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerConfigTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerConfigWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerConfigWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerWriteEventTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerWriteEventTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertWriteAlertTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertWriteAlertTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerConfigPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerConfigPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerPublicEventTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertTriggerPublicEventTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AlertPublicAlertTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AlertPublicAlertTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.WebhookTestResultStatusJsonConverter),

            typeof(global::Opik.JsonConverters.WebhookTestResultStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AnnotationQueueScopeJsonConverter),

            typeof(global::Opik.JsonConverters.AnnotationQueueScopeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AnnotationQueueWriteScopeJsonConverter),

            typeof(global::Opik.JsonConverters.AnnotationQueueWriteScopeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AnnotationQueuePublicScopeJsonConverter),

            typeof(global::Opik.JsonConverters.AnnotationQueuePublicScopeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.CompleteMultipartUploadRequestEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.CompleteMultipartUploadRequestEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DeleteAttachmentsRequestEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DeleteAttachmentsRequestEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.StartMultipartUploadRequestEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.StartMultipartUploadRequestEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorActionJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorActionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeMessageRoleJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeMessageRoleNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeOutputSchemaTypeJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeOutputSchemaTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanFilterOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.SpanFilterOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceFilterOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.TraceFilterOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadFilterOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadFilterOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorWriteActionJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorWriteActionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorWriteDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorWriteDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeMessageWriteRoleJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeMessageWriteRoleNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeOutputSchemaWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeOutputSchemaWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanFilterWriteOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.SpanFilterWriteOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceFilterWriteOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.TraceFilterWriteOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadFilterWriteOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadFilterWriteOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicActionJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicActionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeMessagePublicRoleJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeMessagePublicRoleNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeOutputSchemaPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.LlmAsJudgeOutputSchemaPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanFilterPublicOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.SpanFilterPublicOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceFilterPublicOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.TraceFilterPublicOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadFilterPublicOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadFilterPublicOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorPublicActionJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorPublicActionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorPublicDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorPublicDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LogItemLevelJsonConverter),

            typeof(global::Opik.JsonConverters.LogItemLevelNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateActionJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateActionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AutomationRuleEvaluatorUpdateDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AssistantMessageRoleJsonConverter),

            typeof(global::Opik.JsonConverters.AssistantMessageRoleNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ToolCallTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ToolCallTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ToolTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardPublicScopeJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardPublicScopeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardUpdatePublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DashboardUpdatePublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemFilterOperatorJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemFilterOperatorNullableJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemTypeJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetStatusJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetWriteVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetWriteVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemSourceJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemTraceVisibilityModeJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemTraceVisibilityModeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentRunSummaryStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentRunSummaryStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreSourceJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntrySourceJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntrySourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemWriteSourceJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemWriteSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ColumnCompareTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ColumnCompareTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemCompareSourceJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemCompareSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemCompareTypeJsonConverter),

            typeof(global::Opik.JsonConverters.EvaluatorItemCompareTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemCompareTraceVisibilityModeJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemCompareTraceVisibilityModeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemCompareStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemCompareStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentRunSummaryCompareStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentRunSummaryCompareStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreCompareSourceJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreCompareSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntryCompareSourceJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntryCompareSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetPublicVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetPublicVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetPublicStatusJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetPublicStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectStatItemObjectPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectStatItemObjectPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectStatItemObjectPublicDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectStatItemObjectPublicDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetExportJobPublicStatusJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetExportJobPublicStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemPublicSourceJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetItemPublicSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemPublicTraceVisibilityModeJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentItemPublicTraceVisibilityModeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentRunSummaryPublicStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentRunSummaryPublicStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ColumnPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ColumnPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ColumnTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ColumnTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetUpdateVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.DatasetUpdateVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentUpdateTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentUpdateTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentUpdateStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentUpdateStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentEvaluationMethodJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentEvaluationMethodNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentWriteEvaluationMethodJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentWriteEvaluationMethodNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentWriteStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentWriteStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.CheckNameJsonConverter),

            typeof(global::Opik.JsonConverters.CheckNameNullableJsonConverter),

            typeof(global::Opik.JsonConverters.CheckResultJsonConverter),

            typeof(global::Opik.JsonConverters.CheckResultNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanTypeJsonConverter),

            typeof(global::Opik.JsonConverters.SpanTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanSourceJsonConverter),

            typeof(global::Opik.JsonConverters.SpanSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceVisibilityModeJsonConverter),

            typeof(global::Opik.JsonConverters.TraceVisibilityModeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceSourceJsonConverter),

            typeof(global::Opik.JsonConverters.TraceSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreExperimentItemBulkWriteViewSourceJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreExperimentItemBulkWriteViewSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewTypeJsonConverter),

            typeof(global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewSourceJsonConverter),

            typeof(global::Opik.JsonConverters.SpanExperimentItemBulkWriteViewSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceExperimentItemBulkWriteViewSourceJsonConverter),

            typeof(global::Opik.JsonConverters.TraceExperimentItemBulkWriteViewSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntryExperimentItemBulkWriteViewSourceJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntryExperimentItemBulkWriteViewSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentPublicEvaluationMethodJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentPublicEvaluationMethodNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentPublicStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ExperimentPublicStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackCreateTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackCreateTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackCreateDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackCreateDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackObjectPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackObjectPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackObjectPublicDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackObjectPublicDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackPublicDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackPublicDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackUpdateTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackUpdateTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackUpdateDiscriminatorTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackUpdateDiscriminatorTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailNameJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailNameNullableJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailResultJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailResultNullableJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailWriteNameJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailWriteNameNullableJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailWriteResultJsonConverter),

            typeof(global::Opik.JsonConverters.GuardrailWriteResultNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProviderApiKeyPublicProviderJsonConverter),

            typeof(global::Opik.JsonConverters.ProviderApiKeyPublicProviderNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProviderApiKeyProviderJsonConverter),

            typeof(global::Opik.JsonConverters.ProviderApiKeyProviderNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProviderApiKeyWriteProviderJsonConverter),

            typeof(global::Opik.JsonConverters.ProviderApiKeyWriteProviderNullableJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandSubmitRequestTypeJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandSubmitRequestTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandTypeJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandStatusJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerJobStatusJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerJobStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerStatusJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerTypeJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandItemTypeJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandItemTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandResultRequestStatusJsonConverter),

            typeof(global::Opik.JsonConverters.BridgeCommandResultRequestStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerJobResultRequestStatusJsonConverter),

            typeof(global::Opik.JsonConverters.LocalRunnerJobResultRequestStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ManualEvaluationRequestEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ManualEvaluationRequestEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationStatusJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationWriteStatusJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationWriteStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationPublicStatusJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationPublicStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationUpdateStatusJsonConverter),

            typeof(global::Opik.JsonConverters.OptimizationUpdateStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.CreateSessionRequestTypeJsonConverter),

            typeof(global::Opik.JsonConverters.CreateSessionRequestTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptPublicTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.PromptPublicTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectWriteVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectWriteVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectPublicVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectPublicVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.KpiMetricTypeJsonConverter),

            typeof(global::Opik.JsonConverters.KpiMetricTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.KpiCardRequestEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.KpiCardRequestEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricResponsePublicMetricTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricResponsePublicMetricTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricResponsePublicIntervalJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricResponsePublicIntervalNullableJsonConverter),

            typeof(global::Opik.JsonConverters.BreakdownConfigPublicFieldJsonConverter),

            typeof(global::Opik.JsonConverters.BreakdownConfigPublicFieldNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricRequestPublicMetricTypeJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricRequestPublicMetricTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricRequestPublicIntervalJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectMetricRequestPublicIntervalNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectDetailedVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectDetailedVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectUpdateVisibilityJsonConverter),

            typeof(global::Opik.JsonConverters.ProjectUpdateVisibilityNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptTypeJsonConverter),

            typeof(global::Opik.JsonConverters.PromptTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.PromptTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionTypeJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.PromptWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptWriteTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.PromptWriteTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionDetailTypeJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionDetailTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionDetailTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionDetailTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.CreatePromptVersionDetailTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.CreatePromptVersionDetailTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptDetailTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.PromptDetailTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionPublicTemplateStructureJsonConverter),

            typeof(global::Opik.JsonConverters.PromptVersionPublicTemplateStructureNullableJsonConverter),

            typeof(global::Opik.JsonConverters.RetentionRulePublicLevelJsonConverter),

            typeof(global::Opik.JsonConverters.RetentionRulePublicLevelNullableJsonConverter),

            typeof(global::Opik.JsonConverters.RetentionRulePublicRetentionJsonConverter),

            typeof(global::Opik.JsonConverters.RetentionRulePublicRetentionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.RetentionRuleWriteRetentionJsonConverter),

            typeof(global::Opik.JsonConverters.RetentionRuleWriteRetentionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanUpdateTypeJsonConverter),

            typeof(global::Opik.JsonConverters.SpanUpdateTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanUpdateSourceJsonConverter),

            typeof(global::Opik.JsonConverters.SpanUpdateSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanWriteTypeJsonConverter),

            typeof(global::Opik.JsonConverters.SpanWriteTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanWriteSourceJsonConverter),

            typeof(global::Opik.JsonConverters.SpanWriteSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScorePublicSourceJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScorePublicSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.SpanPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanPublicSourceJsonConverter),

            typeof(global::Opik.JsonConverters.SpanPublicSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntryPublicSourceJsonConverter),

            typeof(global::Opik.JsonConverters.ValueEntryPublicSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreBatchItemSourceJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreBatchItemSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanSearchStreamRequestPublicTypeJsonConverter),

            typeof(global::Opik.JsonConverters.SpanSearchStreamRequestPublicTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.SpanSearchStreamRequestPublicExcludeItemJsonConverter),

            typeof(global::Opik.JsonConverters.SpanSearchStreamRequestPublicExcludeItemNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceUpdateSourceJsonConverter),

            typeof(global::Opik.JsonConverters.TraceUpdateSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceWriteSourceJsonConverter),

            typeof(global::Opik.JsonConverters.TraceWriteSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.CheckPublicNameJsonConverter),

            typeof(global::Opik.JsonConverters.CheckPublicNameNullableJsonConverter),

            typeof(global::Opik.JsonConverters.CheckPublicResultJsonConverter),

            typeof(global::Opik.JsonConverters.CheckPublicResultNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TracePublicVisibilityModeJsonConverter),

            typeof(global::Opik.JsonConverters.TracePublicVisibilityModeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TracePublicSourceJsonConverter),

            typeof(global::Opik.JsonConverters.TracePublicSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadStatusJsonConverter),

            typeof(global::Opik.JsonConverters.TraceThreadStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreBatchItemThreadSourceJsonConverter),

            typeof(global::Opik.JsonConverters.FeedbackScoreBatchItemThreadSourceNullableJsonConverter),

            typeof(global::Opik.JsonConverters.TraceSearchStreamRequestPublicExcludeItemJsonConverter),

            typeof(global::Opik.JsonConverters.TraceSearchStreamRequestPublicExcludeItemNullableJsonConverter),

            typeof(global::Opik.JsonConverters.WorkspaceVersionOpikVersionJsonConverter),

            typeof(global::Opik.JsonConverters.WorkspaceVersionOpikVersionNullableJsonConverter),

            typeof(global::Opik.JsonConverters.GetWebhookExamplesAlertTypeJsonConverter),

            typeof(global::Opik.JsonConverters.GetWebhookExamplesAlertTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.AttachmentListEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.AttachmentListEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.DownloadAttachmentEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.DownloadAttachmentEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.UploadAttachmentEntityTypeJsonConverter),

            typeof(global::Opik.JsonConverters.UploadAttachmentEntityTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FindFeedbackDefinitionsTypeJsonConverter),

            typeof(global::Opik.JsonConverters.FindFeedbackDefinitionsTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.ListRunnersStatusJsonConverter),

            typeof(global::Opik.JsonConverters.ListRunnersStatusNullableJsonConverter),

            typeof(global::Opik.JsonConverters.GetSpansByProjectTypeJsonConverter),

            typeof(global::Opik.JsonConverters.GetSpansByProjectTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.FindFeedbackScoreNames1TypeJsonConverter),

            typeof(global::Opik.JsonConverters.FindFeedbackScoreNames1TypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.GetSpanStatsTypeJsonConverter),

            typeof(global::Opik.JsonConverters.GetSpanStatsTypeNullableJsonConverter),

            typeof(global::Opik.JsonConverters.JsonListStringJsonConverter),

            typeof(global::Opik.JsonConverters.JsonListStringCompareJsonConverter),

            typeof(global::Opik.JsonConverters.JsonListStringWriteJsonConverter),

            typeof(global::Opik.JsonConverters.JsonListStringExperimentItemBulkWriteViewJsonConverter),

            typeof(global::Opik.JsonConverters.JsonListStringPublicJsonConverter),

            typeof(global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>),

            typeof(global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.DatasetItem, global::Opik.ErrorMessage>),

            typeof(global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ExperimentItem, global::Opik.ErrorMessage>),

            typeof(global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>),

            typeof(global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>),

            typeof(global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.TraceThread, global::Opik.ErrorMessage>),

            typeof(global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>),

            typeof(global::Opik.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BiInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BiInformationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.BiInformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpansCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.WorkspaceSpansCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceSpansCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.WorkspaceTraceCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceTraceCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessageWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWriteType), TypeInfoPropertyName = "AgentBlueprintWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigValueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigCreateWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWriteType), TypeInfoPropertyName = "AgentConfigValueWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigEnv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigEnvUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigEnv>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintPublicType), TypeInfoPropertyName = "AgentBlueprintPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigValuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValuePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValuePublicType), TypeInfoPropertyName = "AgentConfigValuePublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintHistoryType), TypeInfoPropertyName = "AgentBlueprintHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigValueHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueHistoryType), TypeInfoPropertyName = "AgentConfigValueHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BlueprintPageHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentBlueprintHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessageHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigRemoveValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigEnvSetByName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Alert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertAlertType), TypeInfoPropertyName = "AlertAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTrigger))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerEventType), TypeInfoPropertyName = "AlertTriggerEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigType), TypeInfoPropertyName = "AlertTriggerConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigWriteType), TypeInfoPropertyName = "AlertTriggerConfigWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerWriteEventType), TypeInfoPropertyName = "AlertTriggerWriteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertWriteAlertType), TypeInfoPropertyName = "AlertWriteAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AlertTriggerWrite>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookExamples))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookTestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookTestResultStatus), TypeInfoPropertyName = "WebhookTestResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueItemIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueScope), TypeInfoPropertyName = "AnnotationQueueScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueReviewer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueWriteScope), TypeInfoPropertyName = "AnnotationQueueWriteScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueReviewerPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePublicScope), TypeInfoPropertyName = "AnnotationQueuePublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreAveragePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Attachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AttachmentPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CompleteMultipartUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CompleteMultipartUploadRequestEntityType), TypeInfoPropertyName = "CompleteMultipartUploadRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.MultipartUploadPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.MultipartUploadPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteAttachmentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteAttachmentsRequestEntityType), TypeInfoPropertyName = "DeleteAttachmentsRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StartMultipartUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StartMultipartUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StartMultipartUploadRequestEntityType), TypeInfoPropertyName = "StartMultipartUploadRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AuthDetailsHolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceNameHolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AudioUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ProjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorAction), TypeInfoPropertyName = "AutomationRuleEvaluatorAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorDiscriminatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorLlmAsJudge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorLlmAsJudgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LlmAsJudgeCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanLlmAsJudge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanLlmAsJudgeCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUserDefinedMetricPythonCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceThreadFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadLlmAsJudgeCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadUserDefinedMetricPythonCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUserDefinedMetricPython))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UserDefinedMetricPythonCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNode))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteAction), TypeInfoPropertyName = "AutomationRuleEvaluatorWriteAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorWriteType), TypeInfoPropertyName = "AutomationRuleEvaluatorWriteType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction), TypeInfoPropertyName = "AutomationRuleEvaluatorObjectObjectPublicAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorObjectObjectPublicType), TypeInfoPropertyName = "AutomationRuleEvaluatorObjectObjectPublicType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicAction), TypeInfoPropertyName = "AutomationRuleEvaluatorPublicAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicType), TypeInfoPropertyName = "AutomationRuleEvaluatorPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogItemLevel), TypeInfoPropertyName = "LogItemLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LogItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateAction), TypeInfoPropertyName = "AutomationRuleEvaluatorUpdateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorUpdateType), TypeInfoPropertyName = "AutomationRuleEvaluatorUpdateType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssistantMessageRole), TypeInfoPropertyName = "AssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ToolCallType), TypeInfoPropertyName = "ToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ResponseFormatType), TypeInfoPropertyName = "ResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicType), TypeInfoPropertyName = "DashboardPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicScope), TypeInfoPropertyName = "DashboardPublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardWriteType), TypeInfoPropertyName = "DashboardWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DashboardPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardUpdatePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardUpdatePublicType), TypeInfoPropertyName = "DashboardUpdatePublicType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetType), TypeInfoPropertyName = "DatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVisibility), TypeInfoPropertyName = "DatasetVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetStatus), TypeInfoPropertyName = "DatasetStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVersionSummary))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemBatch))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetExpansion))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChunkedOutputJsonNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChunkedOutputJsonNodeType))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateType), TypeInfoPropertyName = "ExperimentUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateStatus), TypeInfoPropertyName = "ExperimentUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionScoreAverage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentType), TypeInfoPropertyName = "ExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentEvaluationMethod), TypeInfoPropertyName = "ExperimentEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PercentageValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentStatus), TypeInfoPropertyName = "ExperimentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AssertionScoreAverage>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Check))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckName), TypeInfoPropertyName = "CheckName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckResult), TypeInfoPropertyName = "CheckResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemBulkRecord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Trace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Span))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemBulkUpload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailsValidation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Check>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanType), TypeInfoPropertyName = "SpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanSource), TypeInfoPropertyName = "SpanSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.GuardrailsValidation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceVisibilityMode), TypeInfoPropertyName = "TraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceSource), TypeInfoPropertyName = "TraceSource2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.IdsHolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChunkedOutputJsonNodePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChunkedOutputJsonNodePublicType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentStreamRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Feedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BooleanFeedbackDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CategoricalFeedbackDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackType), TypeInfoPropertyName = "FeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackDiscriminatorType), TypeInfoPropertyName = "FeedbackDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDefinitionVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.NumericalFeedbackDetail))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Guardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailName), TypeInfoPropertyName = "GuardrailName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailResult), TypeInfoPropertyName = "GuardrailResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.GuardrailWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailWriteName), TypeInfoPropertyName = "GuardrailWriteName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailWriteResult), TypeInfoPropertyName = "GuardrailWriteResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ProviderApiKeyPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyPublicProvider), TypeInfoPropertyName = "ProviderApiKeyPublicProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyProvider), TypeInfoPropertyName = "ProviderApiKeyProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyWriteProvider), TypeInfoPropertyName = "ProviderApiKeyWriteProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequestType), TypeInfoPropertyName = "BridgeCommandSubmitRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateLocalRunnerJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommand))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandType), TypeInfoPropertyName = "BridgeCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandStatus), TypeInfoPropertyName = "BridgeCommandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobStatus), TypeInfoPropertyName = "LocalRunnerJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Param>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Param))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerStatus), TypeInfoPropertyName = "LocalRunnerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerType), TypeInfoPropertyName = "LocalRunnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerHeartbeatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerHeartbeatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LocalRunnerJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LocalRunner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.BridgeCommandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandItemType), TypeInfoPropertyName = "BridgeCommandItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandNextRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandResultRequestStatus), TypeInfoPropertyName = "BridgeCommandResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobResultRequestStatus), TypeInfoPropertyName = "LocalRunnerJobResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ManualEvaluationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ManualEvaluationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ManualEvaluationRequestEntityType), TypeInfoPropertyName = "ManualEvaluationRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OllamaModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OllamaInstanceBaseUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OllamaConnectionTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Optimization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationStatus), TypeInfoPropertyName = "OptimizationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationStudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioLlmModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioOptimizer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.StudioMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StudioMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.StudioMessage>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ActivateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateSessionRequestType), TypeInfoPropertyName = "CreateSessionRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublicTemplateStructure), TypeInfoPropertyName = "PromptPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorCountWithDeviation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectVisibility), TypeInfoPropertyName = "ProjectVisibility2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptType), TypeInfoPropertyName = "PromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptTemplateStructure), TypeInfoPropertyName = "PromptTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionType), TypeInfoPropertyName = "PromptVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionTemplateStructure), TypeInfoPropertyName = "PromptVersionTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteType), TypeInfoPropertyName = "PromptWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteTemplateStructure), TypeInfoPropertyName = "PromptWriteTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailType), TypeInfoPropertyName = "PromptVersionDetailType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicTemplateStructure), TypeInfoPropertyName = "PromptVersionPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionCommitsRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionRetrieveDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptUpdatable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRulePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRulePublicLevel), TypeInfoPropertyName = "RetentionRulePublicLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRulePublicRetention), TypeInfoPropertyName = "RetentionRulePublicRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRuleWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRuleWriteRetention), TypeInfoPropertyName = "RetentionRuleWriteRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRulePagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.RetentionRulePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ServiceTogglesConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdateType), TypeInfoPropertyName = "SpanUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanUpdateSource), TypeInfoPropertyName = "SpanUpdateSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfoWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteType), TypeInfoPropertyName = "SpanWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteSource), TypeInfoPropertyName = "SpanWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.SpanWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteFeedbackScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorInfoPublic))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceUpdateSource), TypeInfoPropertyName = "TraceUpdateSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadBatchIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceWriteSource), TypeInfoPropertyName = "TraceWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Trace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceBatchWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteThreadFeedbackScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteTraceThreads))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BatchDeleteByProject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckPublicName), TypeInfoPropertyName = "CheckPublicName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckPublicResult), TypeInfoPropertyName = "CheckPublicResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentItemReferencePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailsValidationPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.CheckPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TracePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.GuardrailsValidationPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TracePublicVisibilityMode), TypeInfoPropertyName = "TracePublicVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TracePublicSource), TypeInfoPropertyName = "TracePublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadStatus), TypeInfoPropertyName = "TraceThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TracePagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TracePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatchItemThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatchItemThreadSource), TypeInfoPropertyName = "FeedbackScoreBatchItemThreadSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatchThread))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItemThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadSearchStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceSearchStreamRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.TraceSearchStreamRequestPublicExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceSearchStreamRequestPublicExcludeItem), TypeInfoPropertyName = "TraceSearchStreamRequestPublicExcludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WelcomeWizardTracking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WelcomeWizardSubmission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Permission))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceUserPermissions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricsSummaryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DataPointDouble))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Result>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceVersionOpikVersion), TypeInfoPropertyName = "WorkspaceVersionOpikVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricsSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromCsvRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LocalRunnerLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetWebhookExamplesAlertType), TypeInfoPropertyName = "GetWebhookExamplesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AttachmentListEntityType), TypeInfoPropertyName = "AttachmentListEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DownloadAttachmentEntityType), TypeInfoPropertyName = "DownloadAttachmentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UploadAttachmentEntityType), TypeInfoPropertyName = "UploadAttachmentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackDefinitionsType), TypeInfoPropertyName = "FindFeedbackDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ListRunnersStatus), TypeInfoPropertyName = "ListRunnersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpansByProjectType), TypeInfoPropertyName = "GetSpansByProjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackScoreNames1Type), TypeInfoPropertyName = "FindFeedbackScoreNames1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpanStatsType), TypeInfoPropertyName = "GetSpanStatsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>), TypeInfoPropertyName = "AnyOfChatCompletionResponseErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.DatasetExportJobPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>), TypeInfoPropertyName = "AnyOfDatasetItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>), TypeInfoPropertyName = "AnyOfExperimentItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>), TypeInfoPropertyName = "AnyOfExperimentPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.OllamaModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>), TypeInfoPropertyName = "AnyOfSpanPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>), TypeInfoPropertyName = "AnyOfTraceThreadErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>), TypeInfoPropertyName = "AnyOfTracePublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.BiInformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.WorkspaceSpansCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.WorkspaceTraceCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigEnv>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValueHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentBlueprintHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTrigger>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerConfigWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerConfigPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AlertTriggerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueueReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnnotationQueueReviewerPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreAveragePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Attachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.MultipartUploadPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ProjectReference>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Function>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DashboardPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.EvaluatorItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetItemFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.EvaluatorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionScoreAverage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentScoreWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionLinkWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVariant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Span>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ExperimentItemBulkRecord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Check>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.GuardrailsValidation>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackObjectPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.GuardrailWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ProviderApiKeyPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Param>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LocalRunnerJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LocalRunner>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.BridgeCommandItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMetricWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.StudioMessageWrite>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.RetentionRulePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScorePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreBatchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.SpanSearchStreamRequestPublicExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Trace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.CheckPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.GuardrailsValidationPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TracePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.FeedbackScoreBatchItemThread>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.TraceSearchStreamRequestPublicExcludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Permission>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Result>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LocalRunnerLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.DatasetExportJobPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.OllamaModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}