
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ConsentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ConsentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AuthorizeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.WorkspaceInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AuthorizationServerMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ClientRegistrationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ClientRegistrationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OAuthError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ValidatedToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnalyticsQueryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.JsonNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnalyticsQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BiInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BiInformationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.BiInformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UsageByWorkspaceProjectUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.WorkspaceProjectUserCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceProjectUserCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpansCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.WorkspaceSpansCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceSpansCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.WorkspaceTraceCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceTraceCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ErrorMessageWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWriteType), TypeInfoPropertyName = "AgentBlueprintWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AgentConfigValueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigCreateWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWriteType), TypeInfoPropertyName = "AgentConfigValueWriteType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsJobStatus), TypeInfoPropertyName = "AgentInsightsJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsJobUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsJobUpdateStatus), TypeInfoPropertyName = "AgentInsightsJobUpdateStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Alert))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertAlertType), TypeInfoPropertyName = "AlertAlertType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ItemLockInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Opik.ItemLockInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LockResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatchEntityType), TypeInfoPropertyName = "AssertionResultBatchEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AssertionResultBatchItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatchItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatchItemStatus), TypeInfoPropertyName = "AssertionResultBatchItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatchItemSource), TypeInfoPropertyName = "AssertionResultBatchItemSource2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTriggerScope), TypeInfoPropertyName = "AutomationRuleEvaluatorTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorType), TypeInfoPropertyName = "AutomationRuleEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorAction), TypeInfoPropertyName = "AutomationRuleEvaluatorAction2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssistantMessageRole), TypeInfoPropertyName = "AssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Delta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogProbs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LogProb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LogProb>))]
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
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Environment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EnvironmentWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EnvironmentPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.EnvironmentPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EnvironmentPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EnvironmentUpdate))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CredentialPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ProviderApiKeyPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyPublicProvider), TypeInfoPropertyName = "ProviderApiKeyPublicProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigPublicSendAs), TypeInfoPropertyName = "ProviderAuthConfigPublicSendAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.CredentialPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Credential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyProvider), TypeInfoPropertyName = "ProviderApiKeyProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigSendAs), TypeInfoPropertyName = "ProviderAuthConfigSendAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Credential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CredentialWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyWriteProvider), TypeInfoPropertyName = "ProviderApiKeyWriteProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigWriteSendAs), TypeInfoPropertyName = "ProviderAuthConfigWriteSendAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.CredentialWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequestType), TypeInfoPropertyName = "BridgeCommandSubmitRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateLocalRunnerJobRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Guid>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ParamPresence), TypeInfoPropertyName = "ParamPresence2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionVersionType), TypeInfoPropertyName = "PromptVersionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionTemplateStructure), TypeInfoPropertyName = "PromptVersionTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteType), TypeInfoPropertyName = "PromptWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteTemplateStructure), TypeInfoPropertyName = "PromptWriteTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonNodeDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailType), TypeInfoPropertyName = "PromptVersionDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailVersionType), TypeInfoPropertyName = "PromptVersionDetailVersionType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicVersionType), TypeInfoPropertyName = "PromptVersionPublicVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicTemplateStructure), TypeInfoPropertyName = "PromptVersionPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionCommitsRequestPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionRetrieveDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionIdsRequestDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionEnvironmentUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptUpdatable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionBatchUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityItemPublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityItemPublicType), TypeInfoPropertyName = "RecentActivityItemPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityPagePublic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.RecentActivityItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportFailure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportFailureType), TypeInfoPropertyName = "ReportFailureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportFailurePage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.ReportFailure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportCompleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportCompleteRequestStatus), TypeInfoPropertyName = "ReportCompleteRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GenerateReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportPreference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OllieReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OllieReportStatus), TypeInfoPropertyName = "OllieReportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OllieReportPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.OllieReport>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWrite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteType), TypeInfoPropertyName = "SpanWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanWriteSource), TypeInfoPropertyName = "SpanWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanBatch))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricsSummaryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DataPointDouble))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.Result>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BreakdownConfig))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BreakdownConfigField), TypeInfoPropertyName = "BreakdownConfigField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceSpanMetricRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceSpanMetricRequestMetricType), TypeInfoPropertyName = "WorkspaceSpanMetricRequestMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceSpanMetricRequestInterval), TypeInfoPropertyName = "WorkspaceSpanMetricRequestInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceTokenUsageNamesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceMetricsSummaryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RevokeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromCsvRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromJsonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat), TypeInfoPropertyName = "CreateDatasetItemsFromJsonRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.LocalRunnerLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesStatus), TypeInfoPropertyName = "FindAgentInsightsIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesSeverity), TypeInfoPropertyName = "FindAgentInsightsIssuesSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetWebhookExamplesAlertType), TypeInfoPropertyName = "GetWebhookExamplesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AttachmentListEntityType), TypeInfoPropertyName = "AttachmentListEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DownloadAttachmentEntityType), TypeInfoPropertyName = "DownloadAttachmentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UploadAttachmentEntityType), TypeInfoPropertyName = "UploadAttachmentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackDefinitionsType), TypeInfoPropertyName = "FindFeedbackDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ListRunnersStatus), TypeInfoPropertyName = "ListRunnersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindReportFailuresType), TypeInfoPropertyName = "FindReportFailuresType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>), TypeInfoPropertyName = "AnyOfSpanPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>), TypeInfoPropertyName = "AnyOfTraceThreadErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>), TypeInfoPropertyName = "AnyOfTracePublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintWriteType?), TypeInfoPropertyName = "NullableAgentBlueprintWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueWriteType?), TypeInfoPropertyName = "NullableAgentConfigValueWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintPublicType?), TypeInfoPropertyName = "NullableAgentBlueprintPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValuePublicType?), TypeInfoPropertyName = "NullableAgentConfigValuePublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentBlueprintHistoryType?), TypeInfoPropertyName = "NullableAgentBlueprintHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentConfigValueHistoryType?), TypeInfoPropertyName = "NullableAgentConfigValueHistoryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsJobStatus?), TypeInfoPropertyName = "NullableAgentInsightsJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsJobUpdateStatus?), TypeInfoPropertyName = "NullableAgentInsightsJobUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueStatus?), TypeInfoPropertyName = "NullableAgentInsightsIssueStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueSeverity?), TypeInfoPropertyName = "NullableAgentInsightsIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueWithDetailsStatus?), TypeInfoPropertyName = "NullableAgentInsightsIssueWithDetailsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueWithDetailsSeverity?), TypeInfoPropertyName = "NullableAgentInsightsIssueWithDetailsSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportedIssueSeverity?), TypeInfoPropertyName = "NullableReportedIssueSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AgentInsightsIssueUpdateStatus?), TypeInfoPropertyName = "NullableAgentInsightsIssueUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertAlertType?), TypeInfoPropertyName = "NullableAlertAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerEventType?), TypeInfoPropertyName = "NullableAlertTriggerEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigType?), TypeInfoPropertyName = "NullableAlertTriggerConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigWriteType?), TypeInfoPropertyName = "NullableAlertTriggerConfigWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerWriteEventType?), TypeInfoPropertyName = "NullableAlertTriggerWriteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertWriteAlertType?), TypeInfoPropertyName = "NullableAlertWriteAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerConfigPublicType?), TypeInfoPropertyName = "NullableAlertTriggerConfigPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertTriggerPublicEventType?), TypeInfoPropertyName = "NullableAlertTriggerPublicEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AlertPublicAlertType?), TypeInfoPropertyName = "NullableAlertPublicAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WebhookTestResultStatus?), TypeInfoPropertyName = "NullableWebhookTestResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueScope?), TypeInfoPropertyName = "NullableAnnotationQueueScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueueWriteScope?), TypeInfoPropertyName = "NullableAnnotationQueueWriteScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnnotationQueuePublicScope?), TypeInfoPropertyName = "NullableAnnotationQueuePublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatchEntityType?), TypeInfoPropertyName = "NullableAssertionResultBatchEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatchItemStatus?), TypeInfoPropertyName = "NullableAssertionResultBatchItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssertionResultBatchItemSource?), TypeInfoPropertyName = "NullableAssertionResultBatchItemSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CompleteMultipartUploadRequestEntityType?), TypeInfoPropertyName = "NullableCompleteMultipartUploadRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DeleteAttachmentsRequestEntityType?), TypeInfoPropertyName = "NullableDeleteAttachmentsRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.StartMultipartUploadRequestEntityType?), TypeInfoPropertyName = "NullableStartMultipartUploadRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorTriggerScope?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorTriggerScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorAction?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AutomationRuleEvaluatorDiscriminatorType?), TypeInfoPropertyName = "NullableAutomationRuleEvaluatorDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AssistantMessageRole?), TypeInfoPropertyName = "NullableAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ToolCallType?), TypeInfoPropertyName = "NullableToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ResponseFormatType?), TypeInfoPropertyName = "NullableResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ToolType?), TypeInfoPropertyName = "NullableToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicType?), TypeInfoPropertyName = "NullableDashboardPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardPublicScope?), TypeInfoPropertyName = "NullableDashboardPublicScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardWriteType?), TypeInfoPropertyName = "NullableDashboardWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DashboardUpdatePublicType?), TypeInfoPropertyName = "NullableDashboardUpdatePublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemPublicType?), TypeInfoPropertyName = "NullableEvaluatorItemPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetItemFilterOperator?), TypeInfoPropertyName = "NullableDatasetItemFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.EvaluatorItemType?), TypeInfoPropertyName = "NullableEvaluatorItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetType?), TypeInfoPropertyName = "NullableDatasetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetVisibility?), TypeInfoPropertyName = "NullableDatasetVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DatasetStatus?), TypeInfoPropertyName = "NullableDatasetStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateType?), TypeInfoPropertyName = "NullableExperimentUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentUpdateStatus?), TypeInfoPropertyName = "NullableExperimentUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentType?), TypeInfoPropertyName = "NullableExperimentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentEvaluationMethod?), TypeInfoPropertyName = "NullableExperimentEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentStatus?), TypeInfoPropertyName = "NullableExperimentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.JsonListStringWrite?), TypeInfoPropertyName = "NullableJsonListStringWrite2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteType?), TypeInfoPropertyName = "NullableExperimentWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteEvaluationMethod?), TypeInfoPropertyName = "NullableExperimentWriteEvaluationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ExperimentWriteStatus?), TypeInfoPropertyName = "NullableExperimentWriteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckName?), TypeInfoPropertyName = "NullableCheckName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckResult?), TypeInfoPropertyName = "NullableCheckResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanType?), TypeInfoPropertyName = "NullableSpanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.SpanSource?), TypeInfoPropertyName = "NullableSpanSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceVisibilityMode?), TypeInfoPropertyName = "NullableTraceVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceSource?), TypeInfoPropertyName = "NullableTraceSource2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackType?), TypeInfoPropertyName = "NullableFeedbackType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreateType?), TypeInfoPropertyName = "NullableFeedbackCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackCreateDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackCreateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublicType?), TypeInfoPropertyName = "NullableFeedbackObjectPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackObjectPublicDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackObjectPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublicType?), TypeInfoPropertyName = "NullableFeedbackPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackPublicDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackPublicDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdateType?), TypeInfoPropertyName = "NullableFeedbackUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackUpdateDiscriminatorType?), TypeInfoPropertyName = "NullableFeedbackUpdateDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailName?), TypeInfoPropertyName = "NullableGuardrailName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailResult?), TypeInfoPropertyName = "NullableGuardrailResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailWriteName?), TypeInfoPropertyName = "NullableGuardrailWriteName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GuardrailWriteResult?), TypeInfoPropertyName = "NullableGuardrailWriteResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyPublicProvider?), TypeInfoPropertyName = "NullableProviderApiKeyPublicProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigPublicSendAs?), TypeInfoPropertyName = "NullableProviderAuthConfigPublicSendAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyProvider?), TypeInfoPropertyName = "NullableProviderApiKeyProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigSendAs?), TypeInfoPropertyName = "NullableProviderAuthConfigSendAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderApiKeyWriteProvider?), TypeInfoPropertyName = "NullableProviderApiKeyWriteProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProviderAuthConfigWriteSendAs?), TypeInfoPropertyName = "NullableProviderAuthConfigWriteSendAs2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandSubmitRequestType?), TypeInfoPropertyName = "NullableBridgeCommandSubmitRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandType?), TypeInfoPropertyName = "NullableBridgeCommandType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandStatus?), TypeInfoPropertyName = "NullableBridgeCommandStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobStatus?), TypeInfoPropertyName = "NullableLocalRunnerJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerStatus?), TypeInfoPropertyName = "NullableLocalRunnerStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerType?), TypeInfoPropertyName = "NullableLocalRunnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ParamPresence?), TypeInfoPropertyName = "NullableParamPresence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandItemType?), TypeInfoPropertyName = "NullableBridgeCommandItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BridgeCommandResultRequestStatus?), TypeInfoPropertyName = "NullableBridgeCommandResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.LocalRunnerJobResultRequestStatus?), TypeInfoPropertyName = "NullableLocalRunnerJobResultRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ManualEvaluationRequestEntityType?), TypeInfoPropertyName = "NullableManualEvaluationRequestEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationStatus?), TypeInfoPropertyName = "NullableOptimizationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationWriteStatus?), TypeInfoPropertyName = "NullableOptimizationWriteStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationPublicStatus?), TypeInfoPropertyName = "NullableOptimizationPublicStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OptimizationUpdateStatus?), TypeInfoPropertyName = "NullableOptimizationUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateSessionRequestType?), TypeInfoPropertyName = "NullableCreateSessionRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptPublicTemplateStructure?), TypeInfoPropertyName = "NullablePromptPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ProjectVisibility?), TypeInfoPropertyName = "NullableProjectVisibility2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptType?), TypeInfoPropertyName = "NullablePromptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptTemplateStructure?), TypeInfoPropertyName = "NullablePromptTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionType?), TypeInfoPropertyName = "NullablePromptVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionVersionType?), TypeInfoPropertyName = "NullablePromptVersionVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionTemplateStructure?), TypeInfoPropertyName = "NullablePromptVersionTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteType?), TypeInfoPropertyName = "NullablePromptWriteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptWriteTemplateStructure?), TypeInfoPropertyName = "NullablePromptWriteTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailType?), TypeInfoPropertyName = "NullablePromptVersionDetailType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailVersionType?), TypeInfoPropertyName = "NullablePromptVersionDetailVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionDetailTemplateStructure?), TypeInfoPropertyName = "NullablePromptVersionDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreatePromptVersionDetailTemplateStructure?), TypeInfoPropertyName = "NullableCreatePromptVersionDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptDetailTemplateStructure?), TypeInfoPropertyName = "NullablePromptDetailTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicType?), TypeInfoPropertyName = "NullablePromptVersionPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicVersionType?), TypeInfoPropertyName = "NullablePromptVersionPublicVersionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.PromptVersionPublicTemplateStructure?), TypeInfoPropertyName = "NullablePromptVersionPublicTemplateStructure2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RecentActivityItemPublicType?), TypeInfoPropertyName = "NullableRecentActivityItemPublicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportFailureType?), TypeInfoPropertyName = "NullableReportFailureType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ReportCompleteRequestStatus?), TypeInfoPropertyName = "NullableReportCompleteRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.OllieReportStatus?), TypeInfoPropertyName = "NullableOllieReportStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRulePublicLevel?), TypeInfoPropertyName = "NullableRetentionRulePublicLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRulePublicRetention?), TypeInfoPropertyName = "NullableRetentionRulePublicRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.RetentionRuleWriteRetention?), TypeInfoPropertyName = "NullableRetentionRuleWriteRetention2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceUpdateSource?), TypeInfoPropertyName = "NullableTraceUpdateSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceWriteSource?), TypeInfoPropertyName = "NullableTraceWriteSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckPublicName?), TypeInfoPropertyName = "NullableCheckPublicName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CheckPublicResult?), TypeInfoPropertyName = "NullableCheckPublicResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TracePublicVisibilityMode?), TypeInfoPropertyName = "NullableTracePublicVisibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TracePublicSource?), TypeInfoPropertyName = "NullableTracePublicSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceThreadStatus?), TypeInfoPropertyName = "NullableTraceThreadStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FeedbackScoreBatchItemThreadSource?), TypeInfoPropertyName = "NullableFeedbackScoreBatchItemThreadSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.TraceSearchStreamRequestPublicExcludeItem?), TypeInfoPropertyName = "NullableTraceSearchStreamRequestPublicExcludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.BreakdownConfigField?), TypeInfoPropertyName = "NullableBreakdownConfigField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceSpanMetricRequestMetricType?), TypeInfoPropertyName = "NullableWorkspaceSpanMetricRequestMetricType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.WorkspaceSpanMetricRequestInterval?), TypeInfoPropertyName = "NullableWorkspaceSpanMetricRequestInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat?), TypeInfoPropertyName = "NullableCreateDatasetItemsFromJsonRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesStatus?), TypeInfoPropertyName = "NullableFindAgentInsightsIssuesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindAgentInsightsIssuesSeverity?), TypeInfoPropertyName = "NullableFindAgentInsightsIssuesSeverity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetWebhookExamplesAlertType?), TypeInfoPropertyName = "NullableGetWebhookExamplesAlertType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AttachmentListEntityType?), TypeInfoPropertyName = "NullableAttachmentListEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.DownloadAttachmentEntityType?), TypeInfoPropertyName = "NullableDownloadAttachmentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.UploadAttachmentEntityType?), TypeInfoPropertyName = "NullableUploadAttachmentEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackDefinitionsType?), TypeInfoPropertyName = "NullableFindFeedbackDefinitionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.ListRunnersStatus?), TypeInfoPropertyName = "NullableListRunnersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindReportFailuresType?), TypeInfoPropertyName = "NullableFindReportFailuresType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpansByProjectType?), TypeInfoPropertyName = "NullableGetSpansByProjectType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.FindFeedbackScoreNames1Type?), TypeInfoPropertyName = "NullableFindFeedbackScoreNames1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.GetSpanStatsType?), TypeInfoPropertyName = "NullableGetSpanStatsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>?), TypeInfoPropertyName = "NullableAnyOfChatCompletionResponseErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>?), TypeInfoPropertyName = "NullableAnyOfDatasetItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>?), TypeInfoPropertyName = "NullableAnyOfExperimentItemErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>?), TypeInfoPropertyName = "NullableAnyOfExperimentPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>?), TypeInfoPropertyName = "NullableAnyOfSpanPublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>?), TypeInfoPropertyName = "NullableAnyOfTraceThreadErrorMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>?), TypeInfoPropertyName = "NullableAnyOfTracePublicErrorMessagePublic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.WorkspaceInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.JsonNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.BiInformation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.WorkspaceProjectUserCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.WorkspaceSpansCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.WorkspaceTraceCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValueWrite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigEnv>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValuePublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentConfigValueHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentBlueprintHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentInsightsIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AgentInsightsIssueDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ReportedIssue>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AssertionResultBatchItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.LogProb>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.EnvironmentPublic>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.CredentialPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.Credential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.CredentialWrite>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.RecentActivityItemPublic>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.ReportFailure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.OllieReport>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.PromptVersionDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringCompareJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringWriteJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringExperimentItemBulkWriteViewJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.JsonListStringPublicJsonConverter());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.DatasetItem, global::Opik.ErrorMessage>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ExperimentItem, global::Opik.ErrorMessage>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.TraceThread, global::Opik.ErrorMessage>());
            options.Converters.Add(new global::Opik.JsonConverters.AnyOfJsonConverter<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>());
            options.Converters.Add(new global::Opik.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Opik.AgentBlueprintWriteType)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintWriteType?)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueWriteType)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueWriteType?)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintPublicType)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintPublicType?)

                    || typeToConvert == typeof(global::Opik.AgentConfigValuePublicType)

                    || typeToConvert == typeof(global::Opik.AgentConfigValuePublicType?)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType)

                    || typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType?)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType)

                    || typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType?)

                    || typeToConvert == typeof(global::Opik.AgentInsightsJobStatus)

                    || typeToConvert == typeof(global::Opik.AgentInsightsJobStatus?)

                    || typeToConvert == typeof(global::Opik.AgentInsightsJobUpdateStatus)

                    || typeToConvert == typeof(global::Opik.AgentInsightsJobUpdateStatus?)

                    || typeToConvert == typeof(global::Opik.AgentInsightsIssueStatus)

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

                    || typeToConvert == typeof(global::Opik.AlertAlertType)

                    || typeToConvert == typeof(global::Opik.AlertAlertType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerEventType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerEventType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType?)

                    || typeToConvert == typeof(global::Opik.AlertWriteAlertType)

                    || typeToConvert == typeof(global::Opik.AlertWriteAlertType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerConfigPublicType?)

                    || typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType)

                    || typeToConvert == typeof(global::Opik.AlertTriggerPublicEventType?)

                    || typeToConvert == typeof(global::Opik.AlertPublicAlertType)

                    || typeToConvert == typeof(global::Opik.AlertPublicAlertType?)

                    || typeToConvert == typeof(global::Opik.WebhookTestResultStatus)

                    || typeToConvert == typeof(global::Opik.WebhookTestResultStatus?)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueScope)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueScope?)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope)

                    || typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope?)

                    || typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope)

                    || typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope?)

                    || typeToConvert == typeof(global::Opik.AssertionResultBatchEntityType)

                    || typeToConvert == typeof(global::Opik.AssertionResultBatchEntityType?)

                    || typeToConvert == typeof(global::Opik.AssertionResultBatchItemStatus)

                    || typeToConvert == typeof(global::Opik.AssertionResultBatchItemStatus?)

                    || typeToConvert == typeof(global::Opik.AssertionResultBatchItemSource)

                    || typeToConvert == typeof(global::Opik.AssertionResultBatchItemSource?)

                    || typeToConvert == typeof(global::Opik.CompleteMultipartUploadRequestEntityType)

                    || typeToConvert == typeof(global::Opik.CompleteMultipartUploadRequestEntityType?)

                    || typeToConvert == typeof(global::Opik.DeleteAttachmentsRequestEntityType)

                    || typeToConvert == typeof(global::Opik.DeleteAttachmentsRequestEntityType?)

                    || typeToConvert == typeof(global::Opik.StartMultipartUploadRequestEntityType)

                    || typeToConvert == typeof(global::Opik.StartMultipartUploadRequestEntityType?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorTriggerScope)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorTriggerScope?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorType?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorAction)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorAction?)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.LlmAsJudgeMessageRole)

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

                    || typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.AssistantMessageRole)

                    || typeToConvert == typeof(global::Opik.AssistantMessageRole?)

                    || typeToConvert == typeof(global::Opik.ToolCallType)

                    || typeToConvert == typeof(global::Opik.ToolCallType?)

                    || typeToConvert == typeof(global::Opik.ResponseFormatType)

                    || typeToConvert == typeof(global::Opik.ResponseFormatType?)

                    || typeToConvert == typeof(global::Opik.ToolType)

                    || typeToConvert == typeof(global::Opik.ToolType?)

                    || typeToConvert == typeof(global::Opik.DashboardPublicType)

                    || typeToConvert == typeof(global::Opik.DashboardPublicType?)

                    || typeToConvert == typeof(global::Opik.DashboardPublicScope)

                    || typeToConvert == typeof(global::Opik.DashboardPublicScope?)

                    || typeToConvert == typeof(global::Opik.DashboardWriteType)

                    || typeToConvert == typeof(global::Opik.DashboardWriteType?)

                    || typeToConvert == typeof(global::Opik.DashboardUpdatePublicType)

                    || typeToConvert == typeof(global::Opik.DashboardUpdatePublicType?)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemPublicType)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemPublicType?)

                    || typeToConvert == typeof(global::Opik.DatasetItemFilterOperator)

                    || typeToConvert == typeof(global::Opik.DatasetItemFilterOperator?)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemType)

                    || typeToConvert == typeof(global::Opik.EvaluatorItemType?)

                    || typeToConvert == typeof(global::Opik.DatasetType)

                    || typeToConvert == typeof(global::Opik.DatasetType?)

                    || typeToConvert == typeof(global::Opik.DatasetVisibility)

                    || typeToConvert == typeof(global::Opik.DatasetVisibility?)

                    || typeToConvert == typeof(global::Opik.DatasetStatus)

                    || typeToConvert == typeof(global::Opik.DatasetStatus?)

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

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateType)

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateType?)

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentUpdateStatus?)

                    || typeToConvert == typeof(global::Opik.ExperimentType)

                    || typeToConvert == typeof(global::Opik.ExperimentType?)

                    || typeToConvert == typeof(global::Opik.ExperimentEvaluationMethod)

                    || typeToConvert == typeof(global::Opik.ExperimentEvaluationMethod?)

                    || typeToConvert == typeof(global::Opik.ExperimentStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentStatus?)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteType)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteType?)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteEvaluationMethod)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteEvaluationMethod?)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteStatus)

                    || typeToConvert == typeof(global::Opik.ExperimentWriteStatus?)

                    || typeToConvert == typeof(global::Opik.CheckName)

                    || typeToConvert == typeof(global::Opik.CheckName?)

                    || typeToConvert == typeof(global::Opik.CheckResult)

                    || typeToConvert == typeof(global::Opik.CheckResult?)

                    || typeToConvert == typeof(global::Opik.SpanType)

                    || typeToConvert == typeof(global::Opik.SpanType?)

                    || typeToConvert == typeof(global::Opik.SpanSource)

                    || typeToConvert == typeof(global::Opik.SpanSource?)

                    || typeToConvert == typeof(global::Opik.TraceVisibilityMode)

                    || typeToConvert == typeof(global::Opik.TraceVisibilityMode?)

                    || typeToConvert == typeof(global::Opik.TraceSource)

                    || typeToConvert == typeof(global::Opik.TraceSource?)

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

                    || typeToConvert == typeof(global::Opik.ExperimentPublicStatus?)

                    || typeToConvert == typeof(global::Opik.FeedbackType)

                    || typeToConvert == typeof(global::Opik.FeedbackType?)

                    || typeToConvert == typeof(global::Opik.FeedbackDiscriminatorType)

                    || typeToConvert == typeof(global::Opik.FeedbackDiscriminatorType?)

                    || typeToConvert == typeof(global::Opik.FeedbackCreateType)

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

                    || typeToConvert == typeof(global::Opik.GuardrailName)

                    || typeToConvert == typeof(global::Opik.GuardrailName?)

                    || typeToConvert == typeof(global::Opik.GuardrailResult)

                    || typeToConvert == typeof(global::Opik.GuardrailResult?)

                    || typeToConvert == typeof(global::Opik.GuardrailWriteName)

                    || typeToConvert == typeof(global::Opik.GuardrailWriteName?)

                    || typeToConvert == typeof(global::Opik.GuardrailWriteResult)

                    || typeToConvert == typeof(global::Opik.GuardrailWriteResult?)

                    || typeToConvert == typeof(global::Opik.ProviderApiKeyPublicProvider)

                    || typeToConvert == typeof(global::Opik.ProviderApiKeyPublicProvider?)

                    || typeToConvert == typeof(global::Opik.ProviderAuthConfigPublicSendAs)

                    || typeToConvert == typeof(global::Opik.ProviderAuthConfigPublicSendAs?)

                    || typeToConvert == typeof(global::Opik.ProviderApiKeyProvider)

                    || typeToConvert == typeof(global::Opik.ProviderApiKeyProvider?)

                    || typeToConvert == typeof(global::Opik.ProviderAuthConfigSendAs)

                    || typeToConvert == typeof(global::Opik.ProviderAuthConfigSendAs?)

                    || typeToConvert == typeof(global::Opik.ProviderApiKeyWriteProvider)

                    || typeToConvert == typeof(global::Opik.ProviderApiKeyWriteProvider?)

                    || typeToConvert == typeof(global::Opik.ProviderAuthConfigWriteSendAs)

                    || typeToConvert == typeof(global::Opik.ProviderAuthConfigWriteSendAs?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType)

                    || typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandType)

                    || typeToConvert == typeof(global::Opik.BridgeCommandType?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandStatus)

                    || typeToConvert == typeof(global::Opik.BridgeCommandStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobStatus)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerStatus)

                    || typeToConvert == typeof(global::Opik.LocalRunnerStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerType)

                    || typeToConvert == typeof(global::Opik.LocalRunnerType?)

                    || typeToConvert == typeof(global::Opik.ParamPresence)

                    || typeToConvert == typeof(global::Opik.ParamPresence?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandItemType)

                    || typeToConvert == typeof(global::Opik.BridgeCommandItemType?)

                    || typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus)

                    || typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus?)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus)

                    || typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus?)

                    || typeToConvert == typeof(global::Opik.ManualEvaluationRequestEntityType)

                    || typeToConvert == typeof(global::Opik.ManualEvaluationRequestEntityType?)

                    || typeToConvert == typeof(global::Opik.OptimizationStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationStatus?)

                    || typeToConvert == typeof(global::Opik.OptimizationWriteStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationWriteStatus?)

                    || typeToConvert == typeof(global::Opik.OptimizationPublicStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationPublicStatus?)

                    || typeToConvert == typeof(global::Opik.OptimizationUpdateStatus)

                    || typeToConvert == typeof(global::Opik.OptimizationUpdateStatus?)

                    || typeToConvert == typeof(global::Opik.CreateSessionRequestType)

                    || typeToConvert == typeof(global::Opik.CreateSessionRequestType?)

                    || typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.ProjectVisibility)

                    || typeToConvert == typeof(global::Opik.ProjectVisibility?)

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

                    || typeToConvert == typeof(global::Opik.PromptType)

                    || typeToConvert == typeof(global::Opik.PromptType?)

                    || typeToConvert == typeof(global::Opik.PromptTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptVersionType)

                    || typeToConvert == typeof(global::Opik.PromptVersionType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionVersionType)

                    || typeToConvert == typeof(global::Opik.PromptVersionVersionType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptVersionTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptWriteType)

                    || typeToConvert == typeof(global::Opik.PromptWriteType?)

                    || typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailType)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure)

                    || typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicType)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType?)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure)

                    || typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure?)

                    || typeToConvert == typeof(global::Opik.RecentActivityItemPublicType)

                    || typeToConvert == typeof(global::Opik.RecentActivityItemPublicType?)

                    || typeToConvert == typeof(global::Opik.ReportFailureType)

                    || typeToConvert == typeof(global::Opik.ReportFailureType?)

                    || typeToConvert == typeof(global::Opik.ReportCompleteRequestStatus)

                    || typeToConvert == typeof(global::Opik.ReportCompleteRequestStatus?)

                    || typeToConvert == typeof(global::Opik.OllieReportStatus)

                    || typeToConvert == typeof(global::Opik.OllieReportStatus?)

                    || typeToConvert == typeof(global::Opik.RetentionRulePublicLevel)

                    || typeToConvert == typeof(global::Opik.RetentionRulePublicLevel?)

                    || typeToConvert == typeof(global::Opik.RetentionRulePublicRetention)

                    || typeToConvert == typeof(global::Opik.RetentionRulePublicRetention?)

                    || typeToConvert == typeof(global::Opik.RetentionRuleWriteRetention)

                    || typeToConvert == typeof(global::Opik.RetentionRuleWriteRetention?)

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

                    || typeToConvert == typeof(global::Opik.TraceUpdateSource)

                    || typeToConvert == typeof(global::Opik.TraceUpdateSource?)

                    || typeToConvert == typeof(global::Opik.TraceWriteSource)

                    || typeToConvert == typeof(global::Opik.TraceWriteSource?)

                    || typeToConvert == typeof(global::Opik.CheckPublicName)

                    || typeToConvert == typeof(global::Opik.CheckPublicName?)

                    || typeToConvert == typeof(global::Opik.CheckPublicResult)

                    || typeToConvert == typeof(global::Opik.CheckPublicResult?)

                    || typeToConvert == typeof(global::Opik.TracePublicVisibilityMode)

                    || typeToConvert == typeof(global::Opik.TracePublicVisibilityMode?)

                    || typeToConvert == typeof(global::Opik.TracePublicSource)

                    || typeToConvert == typeof(global::Opik.TracePublicSource?)

                    || typeToConvert == typeof(global::Opik.TraceThreadStatus)

                    || typeToConvert == typeof(global::Opik.TraceThreadStatus?)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemThreadSource)

                    || typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemThreadSource?)

                    || typeToConvert == typeof(global::Opik.TraceSearchStreamRequestPublicExcludeItem)

                    || typeToConvert == typeof(global::Opik.TraceSearchStreamRequestPublicExcludeItem?)

                    || typeToConvert == typeof(global::Opik.BreakdownConfigField)

                    || typeToConvert == typeof(global::Opik.BreakdownConfigField?)

                    || typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestMetricType)

                    || typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestMetricType?)

                    || typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestInterval)

                    || typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestInterval?)

                    || typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat)

                    || typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat?)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesStatus)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesStatus?)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesSeverity)

                    || typeToConvert == typeof(global::Opik.FindAgentInsightsIssuesSeverity?)

                    || typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType)

                    || typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType?)

                    || typeToConvert == typeof(global::Opik.AttachmentListEntityType)

                    || typeToConvert == typeof(global::Opik.AttachmentListEntityType?)

                    || typeToConvert == typeof(global::Opik.DownloadAttachmentEntityType)

                    || typeToConvert == typeof(global::Opik.DownloadAttachmentEntityType?)

                    || typeToConvert == typeof(global::Opik.UploadAttachmentEntityType)

                    || typeToConvert == typeof(global::Opik.UploadAttachmentEntityType?)

                    || typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType)

                    || typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType?)

                    || typeToConvert == typeof(global::Opik.ListRunnersStatus)

                    || typeToConvert == typeof(global::Opik.ListRunnersStatus?)

                    || typeToConvert == typeof(global::Opik.FindReportFailuresType)

                    || typeToConvert == typeof(global::Opik.FindReportFailuresType?)

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
                if (typeToConvert == typeof(global::Opik.AgentBlueprintWriteType))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintWriteType?))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueWriteType))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueWriteType?))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintPublicType))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintPublicType?))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValuePublicType))
                {
                    return new global::Opik.JsonConverters.AgentConfigValuePublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValuePublicType?))
                {
                    return new global::Opik.JsonConverters.AgentConfigValuePublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintHistoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentBlueprintHistoryType?))
                {
                    return new global::Opik.JsonConverters.AgentBlueprintHistoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueHistoryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentConfigValueHistoryType?))
                {
                    return new global::Opik.JsonConverters.AgentConfigValueHistoryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsJobStatus))
                {
                    return new global::Opik.JsonConverters.AgentInsightsJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsJobStatus?))
                {
                    return new global::Opik.JsonConverters.AgentInsightsJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsJobUpdateStatus))
                {
                    return new global::Opik.JsonConverters.AgentInsightsJobUpdateStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AgentInsightsJobUpdateStatus?))
                {
                    return new global::Opik.JsonConverters.AgentInsightsJobUpdateStatusNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Opik.AlertAlertType))
                {
                    return new global::Opik.JsonConverters.AlertAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertAlertType?))
                {
                    return new global::Opik.JsonConverters.AlertAlertTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerEventType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerEventType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerConfigWriteType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerConfigWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType))
                {
                    return new global::Opik.JsonConverters.AlertTriggerWriteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertTriggerWriteEventType?))
                {
                    return new global::Opik.JsonConverters.AlertTriggerWriteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertWriteAlertType))
                {
                    return new global::Opik.JsonConverters.AlertWriteAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AlertWriteAlertType?))
                {
                    return new global::Opik.JsonConverters.AlertWriteAlertTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Opik.WebhookTestResultStatus))
                {
                    return new global::Opik.JsonConverters.WebhookTestResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.WebhookTestResultStatus?))
                {
                    return new global::Opik.JsonConverters.WebhookTestResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueScope))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueScope?))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueWriteScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueueWriteScope?))
                {
                    return new global::Opik.JsonConverters.AnnotationQueueWriteScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope))
                {
                    return new global::Opik.JsonConverters.AnnotationQueuePublicScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AnnotationQueuePublicScope?))
                {
                    return new global::Opik.JsonConverters.AnnotationQueuePublicScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AssertionResultBatchEntityType))
                {
                    return new global::Opik.JsonConverters.AssertionResultBatchEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AssertionResultBatchEntityType?))
                {
                    return new global::Opik.JsonConverters.AssertionResultBatchEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AssertionResultBatchItemStatus))
                {
                    return new global::Opik.JsonConverters.AssertionResultBatchItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AssertionResultBatchItemStatus?))
                {
                    return new global::Opik.JsonConverters.AssertionResultBatchItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AssertionResultBatchItemSource))
                {
                    return new global::Opik.JsonConverters.AssertionResultBatchItemSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AssertionResultBatchItemSource?))
                {
                    return new global::Opik.JsonConverters.AssertionResultBatchItemSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CompleteMultipartUploadRequestEntityType))
                {
                    return new global::Opik.JsonConverters.CompleteMultipartUploadRequestEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CompleteMultipartUploadRequestEntityType?))
                {
                    return new global::Opik.JsonConverters.CompleteMultipartUploadRequestEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DeleteAttachmentsRequestEntityType))
                {
                    return new global::Opik.JsonConverters.DeleteAttachmentsRequestEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DeleteAttachmentsRequestEntityType?))
                {
                    return new global::Opik.JsonConverters.DeleteAttachmentsRequestEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.StartMultipartUploadRequestEntityType))
                {
                    return new global::Opik.JsonConverters.StartMultipartUploadRequestEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.StartMultipartUploadRequestEntityType?))
                {
                    return new global::Opik.JsonConverters.StartMultipartUploadRequestEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorTriggerScope))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorTriggerScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorTriggerScope?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorTriggerScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorAction))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorAction?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AutomationRuleEvaluatorDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.AutomationRuleEvaluatorDiscriminatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Opik.AssistantMessageRole))
                {
                    return new global::Opik.JsonConverters.AssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AssistantMessageRole?))
                {
                    return new global::Opik.JsonConverters.AssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ToolCallType))
                {
                    return new global::Opik.JsonConverters.ToolCallTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ToolCallType?))
                {
                    return new global::Opik.JsonConverters.ToolCallTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ResponseFormatType))
                {
                    return new global::Opik.JsonConverters.ResponseFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ResponseFormatType?))
                {
                    return new global::Opik.JsonConverters.ResponseFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ToolType))
                {
                    return new global::Opik.JsonConverters.ToolTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ToolType?))
                {
                    return new global::Opik.JsonConverters.ToolTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.DashboardWriteType))
                {
                    return new global::Opik.JsonConverters.DashboardWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DashboardWriteType?))
                {
                    return new global::Opik.JsonConverters.DashboardWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DashboardUpdatePublicType))
                {
                    return new global::Opik.JsonConverters.DashboardUpdatePublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DashboardUpdatePublicType?))
                {
                    return new global::Opik.JsonConverters.DashboardUpdatePublicTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Opik.DatasetType))
                {
                    return new global::Opik.JsonConverters.DatasetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetType?))
                {
                    return new global::Opik.JsonConverters.DatasetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetVisibility))
                {
                    return new global::Opik.JsonConverters.DatasetVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetVisibility?))
                {
                    return new global::Opik.JsonConverters.DatasetVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetStatus))
                {
                    return new global::Opik.JsonConverters.DatasetStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DatasetStatus?))
                {
                    return new global::Opik.JsonConverters.DatasetStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.ExperimentType))
                {
                    return new global::Opik.JsonConverters.ExperimentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentType?))
                {
                    return new global::Opik.JsonConverters.ExperimentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentEvaluationMethod))
                {
                    return new global::Opik.JsonConverters.ExperimentEvaluationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentEvaluationMethod?))
                {
                    return new global::Opik.JsonConverters.ExperimentEvaluationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentStatus))
                {
                    return new global::Opik.JsonConverters.ExperimentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ExperimentStatus?))
                {
                    return new global::Opik.JsonConverters.ExperimentStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.CheckName))
                {
                    return new global::Opik.JsonConverters.CheckNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CheckName?))
                {
                    return new global::Opik.JsonConverters.CheckNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CheckResult))
                {
                    return new global::Opik.JsonConverters.CheckResultJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CheckResult?))
                {
                    return new global::Opik.JsonConverters.CheckResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanType))
                {
                    return new global::Opik.JsonConverters.SpanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanType?))
                {
                    return new global::Opik.JsonConverters.SpanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanSource))
                {
                    return new global::Opik.JsonConverters.SpanSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.SpanSource?))
                {
                    return new global::Opik.JsonConverters.SpanSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceVisibilityMode))
                {
                    return new global::Opik.JsonConverters.TraceVisibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceVisibilityMode?))
                {
                    return new global::Opik.JsonConverters.TraceVisibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceSource))
                {
                    return new global::Opik.JsonConverters.TraceSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceSource?))
                {
                    return new global::Opik.JsonConverters.TraceSourceNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.FeedbackType))
                {
                    return new global::Opik.JsonConverters.FeedbackTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackType?))
                {
                    return new global::Opik.JsonConverters.FeedbackTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackDiscriminatorType))
                {
                    return new global::Opik.JsonConverters.FeedbackDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackDiscriminatorType?))
                {
                    return new global::Opik.JsonConverters.FeedbackDiscriminatorTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Opik.GuardrailName))
                {
                    return new global::Opik.JsonConverters.GuardrailNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GuardrailName?))
                {
                    return new global::Opik.JsonConverters.GuardrailNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GuardrailResult))
                {
                    return new global::Opik.JsonConverters.GuardrailResultJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GuardrailResult?))
                {
                    return new global::Opik.JsonConverters.GuardrailResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GuardrailWriteName))
                {
                    return new global::Opik.JsonConverters.GuardrailWriteNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GuardrailWriteName?))
                {
                    return new global::Opik.JsonConverters.GuardrailWriteNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GuardrailWriteResult))
                {
                    return new global::Opik.JsonConverters.GuardrailWriteResultJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GuardrailWriteResult?))
                {
                    return new global::Opik.JsonConverters.GuardrailWriteResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderApiKeyPublicProvider))
                {
                    return new global::Opik.JsonConverters.ProviderApiKeyPublicProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderApiKeyPublicProvider?))
                {
                    return new global::Opik.JsonConverters.ProviderApiKeyPublicProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderAuthConfigPublicSendAs))
                {
                    return new global::Opik.JsonConverters.ProviderAuthConfigPublicSendAsJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderAuthConfigPublicSendAs?))
                {
                    return new global::Opik.JsonConverters.ProviderAuthConfigPublicSendAsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderApiKeyProvider))
                {
                    return new global::Opik.JsonConverters.ProviderApiKeyProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderApiKeyProvider?))
                {
                    return new global::Opik.JsonConverters.ProviderApiKeyProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderAuthConfigSendAs))
                {
                    return new global::Opik.JsonConverters.ProviderAuthConfigSendAsJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderAuthConfigSendAs?))
                {
                    return new global::Opik.JsonConverters.ProviderAuthConfigSendAsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderApiKeyWriteProvider))
                {
                    return new global::Opik.JsonConverters.ProviderApiKeyWriteProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderApiKeyWriteProvider?))
                {
                    return new global::Opik.JsonConverters.ProviderApiKeyWriteProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderAuthConfigWriteSendAs))
                {
                    return new global::Opik.JsonConverters.ProviderAuthConfigWriteSendAsJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProviderAuthConfigWriteSendAs?))
                {
                    return new global::Opik.JsonConverters.ProviderAuthConfigWriteSendAsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType))
                {
                    return new global::Opik.JsonConverters.BridgeCommandSubmitRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandSubmitRequestType?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandSubmitRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandType))
                {
                    return new global::Opik.JsonConverters.BridgeCommandTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandType?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandStatus))
                {
                    return new global::Opik.JsonConverters.BridgeCommandStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandStatus?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobStatus))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobStatus?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerStatus))
                {
                    return new global::Opik.JsonConverters.LocalRunnerStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerStatus?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerType))
                {
                    return new global::Opik.JsonConverters.LocalRunnerTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerType?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ParamPresence))
                {
                    return new global::Opik.JsonConverters.ParamPresenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ParamPresence?))
                {
                    return new global::Opik.JsonConverters.ParamPresenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandItemType))
                {
                    return new global::Opik.JsonConverters.BridgeCommandItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandItemType?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus))
                {
                    return new global::Opik.JsonConverters.BridgeCommandResultRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BridgeCommandResultRequestStatus?))
                {
                    return new global::Opik.JsonConverters.BridgeCommandResultRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobResultRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.LocalRunnerJobResultRequestStatus?))
                {
                    return new global::Opik.JsonConverters.LocalRunnerJobResultRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ManualEvaluationRequestEntityType))
                {
                    return new global::Opik.JsonConverters.ManualEvaluationRequestEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ManualEvaluationRequestEntityType?))
                {
                    return new global::Opik.JsonConverters.ManualEvaluationRequestEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationStatus))
                {
                    return new global::Opik.JsonConverters.OptimizationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OptimizationStatus?))
                {
                    return new global::Opik.JsonConverters.OptimizationStatusNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Opik.CreateSessionRequestType))
                {
                    return new global::Opik.JsonConverters.CreateSessionRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreateSessionRequestType?))
                {
                    return new global::Opik.JsonConverters.CreateSessionRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptPublicTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptPublicTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptPublicTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectVisibility))
                {
                    return new global::Opik.JsonConverters.ProjectVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ProjectVisibility?))
                {
                    return new global::Opik.JsonConverters.ProjectVisibilityNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.PromptType))
                {
                    return new global::Opik.JsonConverters.PromptTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptType?))
                {
                    return new global::Opik.JsonConverters.PromptTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionType))
                {
                    return new global::Opik.JsonConverters.PromptVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionVersionType))
                {
                    return new global::Opik.JsonConverters.PromptVersionVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionVersionType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptVersionTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptVersionTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteType))
                {
                    return new global::Opik.JsonConverters.PromptWriteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteType?))
                {
                    return new global::Opik.JsonConverters.PromptWriteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptWriteTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptWriteTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptWriteTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailType))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailVersionType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionDetailTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptVersionDetailTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure))
                {
                    return new global::Opik.JsonConverters.CreatePromptVersionDetailTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreatePromptVersionDetailTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.CreatePromptVersionDetailTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptDetailTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptDetailTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptDetailTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicType))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicVersionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicVersionType?))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicVersionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTemplateStructureJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.PromptVersionPublicTemplateStructure?))
                {
                    return new global::Opik.JsonConverters.PromptVersionPublicTemplateStructureNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RecentActivityItemPublicType))
                {
                    return new global::Opik.JsonConverters.RecentActivityItemPublicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RecentActivityItemPublicType?))
                {
                    return new global::Opik.JsonConverters.RecentActivityItemPublicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ReportFailureType))
                {
                    return new global::Opik.JsonConverters.ReportFailureTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ReportFailureType?))
                {
                    return new global::Opik.JsonConverters.ReportFailureTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ReportCompleteRequestStatus))
                {
                    return new global::Opik.JsonConverters.ReportCompleteRequestStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ReportCompleteRequestStatus?))
                {
                    return new global::Opik.JsonConverters.ReportCompleteRequestStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OllieReportStatus))
                {
                    return new global::Opik.JsonConverters.OllieReportStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.OllieReportStatus?))
                {
                    return new global::Opik.JsonConverters.OllieReportStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RetentionRulePublicLevel))
                {
                    return new global::Opik.JsonConverters.RetentionRulePublicLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RetentionRulePublicLevel?))
                {
                    return new global::Opik.JsonConverters.RetentionRulePublicLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RetentionRulePublicRetention))
                {
                    return new global::Opik.JsonConverters.RetentionRulePublicRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RetentionRulePublicRetention?))
                {
                    return new global::Opik.JsonConverters.RetentionRulePublicRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RetentionRuleWriteRetention))
                {
                    return new global::Opik.JsonConverters.RetentionRuleWriteRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.RetentionRuleWriteRetention?))
                {
                    return new global::Opik.JsonConverters.RetentionRuleWriteRetentionNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.TraceUpdateSource))
                {
                    return new global::Opik.JsonConverters.TraceUpdateSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceUpdateSource?))
                {
                    return new global::Opik.JsonConverters.TraceUpdateSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceWriteSource))
                {
                    return new global::Opik.JsonConverters.TraceWriteSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceWriteSource?))
                {
                    return new global::Opik.JsonConverters.TraceWriteSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CheckPublicName))
                {
                    return new global::Opik.JsonConverters.CheckPublicNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CheckPublicName?))
                {
                    return new global::Opik.JsonConverters.CheckPublicNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CheckPublicResult))
                {
                    return new global::Opik.JsonConverters.CheckPublicResultJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CheckPublicResult?))
                {
                    return new global::Opik.JsonConverters.CheckPublicResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TracePublicVisibilityMode))
                {
                    return new global::Opik.JsonConverters.TracePublicVisibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TracePublicVisibilityMode?))
                {
                    return new global::Opik.JsonConverters.TracePublicVisibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TracePublicSource))
                {
                    return new global::Opik.JsonConverters.TracePublicSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TracePublicSource?))
                {
                    return new global::Opik.JsonConverters.TracePublicSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadStatus))
                {
                    return new global::Opik.JsonConverters.TraceThreadStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceThreadStatus?))
                {
                    return new global::Opik.JsonConverters.TraceThreadStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemThreadSource))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreBatchItemThreadSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FeedbackScoreBatchItemThreadSource?))
                {
                    return new global::Opik.JsonConverters.FeedbackScoreBatchItemThreadSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceSearchStreamRequestPublicExcludeItem))
                {
                    return new global::Opik.JsonConverters.TraceSearchStreamRequestPublicExcludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.TraceSearchStreamRequestPublicExcludeItem?))
                {
                    return new global::Opik.JsonConverters.TraceSearchStreamRequestPublicExcludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BreakdownConfigField))
                {
                    return new global::Opik.JsonConverters.BreakdownConfigFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.BreakdownConfigField?))
                {
                    return new global::Opik.JsonConverters.BreakdownConfigFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestMetricType))
                {
                    return new global::Opik.JsonConverters.WorkspaceSpanMetricRequestMetricTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestMetricType?))
                {
                    return new global::Opik.JsonConverters.WorkspaceSpanMetricRequestMetricTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestInterval))
                {
                    return new global::Opik.JsonConverters.WorkspaceSpanMetricRequestIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.WorkspaceSpanMetricRequestInterval?))
                {
                    return new global::Opik.JsonConverters.WorkspaceSpanMetricRequestIntervalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat))
                {
                    return new global::Opik.JsonConverters.CreateDatasetItemsFromJsonRequestFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.CreateDatasetItemsFromJsonRequestFormat?))
                {
                    return new global::Opik.JsonConverters.CreateDatasetItemsFromJsonRequestFormatNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType))
                {
                    return new global::Opik.JsonConverters.GetWebhookExamplesAlertTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.GetWebhookExamplesAlertType?))
                {
                    return new global::Opik.JsonConverters.GetWebhookExamplesAlertTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AttachmentListEntityType))
                {
                    return new global::Opik.JsonConverters.AttachmentListEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.AttachmentListEntityType?))
                {
                    return new global::Opik.JsonConverters.AttachmentListEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DownloadAttachmentEntityType))
                {
                    return new global::Opik.JsonConverters.DownloadAttachmentEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.DownloadAttachmentEntityType?))
                {
                    return new global::Opik.JsonConverters.DownloadAttachmentEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.UploadAttachmentEntityType))
                {
                    return new global::Opik.JsonConverters.UploadAttachmentEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.UploadAttachmentEntityType?))
                {
                    return new global::Opik.JsonConverters.UploadAttachmentEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType))
                {
                    return new global::Opik.JsonConverters.FindFeedbackDefinitionsTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindFeedbackDefinitionsType?))
                {
                    return new global::Opik.JsonConverters.FindFeedbackDefinitionsTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ListRunnersStatus))
                {
                    return new global::Opik.JsonConverters.ListRunnersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.ListRunnersStatus?))
                {
                    return new global::Opik.JsonConverters.ListRunnersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindReportFailuresType))
                {
                    return new global::Opik.JsonConverters.FindReportFailuresTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Opik.FindReportFailuresType?))
                {
                    return new global::Opik.JsonConverters.FindReportFailuresTypeNullableJsonConverter();
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}