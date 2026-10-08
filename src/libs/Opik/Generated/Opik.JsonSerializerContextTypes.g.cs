
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Opik
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConsentResponse? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConsentRequest? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AuthorizeContext? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceInfo>? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceInfo? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AuthorizationServerMetadata? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ClientRegistrationResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ClientRegistrationRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TokenResponse? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OAuthError? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValidatedToken? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Response? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Request? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnalyticsQueryResponse? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.JsonNode>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNode? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessage? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnalyticsQueryRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScopedAnalyticsQueryRequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UsageProjectsResponse? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceProjectName>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceProjectName? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UsageProjectsRequest? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BiInformation? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BiInformationResponse? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.BiInformation>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UsageByWorkspaceProjectUserResponse? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceProjectUserCount>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceProjectUserCount? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpansCountResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceSpansCount>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpansCount? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceCountResponse? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceTraceCount>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceTraceCount? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageWrite? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintWrite? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintWriteType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigValueWrite>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueWrite? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigCreateWrite? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueWriteType? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigEnv? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigEnvUpdate? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigEnv>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintPublic? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintPublicType? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigValuePublic>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValuePublic? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValuePublicType? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessagePublic? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintHistory? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintHistoryType? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigValueHistory>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueHistory? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueHistoryType? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BlueprintPageHistory? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentBlueprintHistory>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageHistory? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigRemoveValues? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigEnvSetByName? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJob? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJobStatus? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJobUpdate? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJobUpdateStatus? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssue? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueStatus? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueSeverity? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssuePage? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentInsightsIssue>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueDetail? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueWithDetails? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueWithDetailsStatus? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueWithDetailsSeverity? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentInsightsIssueDetail>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsReport? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ReportedIssue>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportedIssue? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportedIssueSeverity? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueUpdate? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueUpdateStatus? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Alert? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertAlertType? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Webhook? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTrigger>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTrigger? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerEventType? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfig>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfig? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigType? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigWrite? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigWriteType? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerWrite? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerWriteEventType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigWrite>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertWrite? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertWriteAlertType? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookWrite? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerWrite>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BatchDelete? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertPagePublic? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertPublic>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertPublic? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigPublic? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigPublicType? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerPublic? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerPublicEventType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigPublic>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertPublicAlertType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookPublic? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerPublic>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookExamples? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookTestResult? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookTestResultStatus? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemIds? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueue? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueScope? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomation? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewer>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReviewer? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverage>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAverage? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Conditions? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroup? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreCondition>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreCondition? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroup>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionOperator? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomationWrite? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionsWrite? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueWrite? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueWriteScope? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroupWrite? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreConditionWrite>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionWrite? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroupWrite>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionWriteOperator? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueBatch? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueue>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueBatchWrite? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueWrite>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomationPublic? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionsPublic? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePagePublic? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueuePublic>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePublic? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReviewerPublic? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePublicScope? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewerPublic>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAveragePublic? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroupPublic? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreConditionPublic>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionPublic? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroupPublic>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionPublicOperator? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ItemLockInfo? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocksResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ItemLockInfo>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LockResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemPublic? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemPublicSource? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemsPublic? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueItemPublic>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemIdsPublic? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueUpdate? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatch? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchEntityType? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResultBatchItem>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItem? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItemStatus? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItemSource? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Attachment? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AttachmentPage? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Attachment>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompleteMultipartUploadRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompleteMultipartUploadRequestEntityType? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.MultipartUploadPart>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.MultipartUploadPart? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteAttachmentsRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteAttachmentsRequestEntityType? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadRequestEntityType? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AuthDetailsHolder? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceNameHolder? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrl? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluator? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectReference>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectReference? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTriggerScope? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorType? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorAction? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorDiscriminator? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorDiscriminatorType? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudge? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeVariant2? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilter>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilter? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCode? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudge? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeVariant2? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilter>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilter? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCode? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPython? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonVariant2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCode? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudge? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeVariant2? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilter>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilter? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCode? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonVariant2? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCode? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPython? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonVariant2? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCode? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrl? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParameters? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessage>? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessage? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchema>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchema? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageRole? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContent>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContent? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrl? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaType? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterOperator? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterOperator? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterOperator? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrlWrite? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeWrite? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWrite? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeWriteVariant2? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterWrite>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterWrite? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCodeWrite? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWrite? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWriteVariant2? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterWrite>? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterWrite? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCodeWrite? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWriteVariant2? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCodeWrite? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWriteVariant2? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterWrite>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterWrite? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCodeWrite? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWriteVariant2? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCodeWrite? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWrite? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCodeWrite? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteTriggerScope? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteType? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteAction? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteDiscriminator? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrlWrite? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeWrite? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersWrite? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageWrite>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageWrite? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaWrite>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaWrite? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContentWrite? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrlWrite? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageWriteRole? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentWrite>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaWriteType? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterWriteOperator? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterWriteOperator? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterWriteOperator? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrlPublic? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgePublic? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublic? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgePublicVariant2? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterPublic? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCodePublic? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublic? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectReferencePublic>? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectReferencePublic? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicType? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminator? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPagePublic? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AutomationRuleEvaluatorObjectObjectPublic>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublic? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterPublic? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCodePublic? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublic? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublicVariant2? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCodePublic? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublicVariant2? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterPublic? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCodePublic? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublic? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublicVariant2? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCodePublic? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublic? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublicVariant2? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCodePublic? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrlPublic? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodePublic? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersPublic? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessagePublic>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessagePublic? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaPublic>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaPublic? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContentPublic? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrlPublic? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessagePublicRole? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentPublic>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaPublicType? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterPublicOperator? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterPublicOperator? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterPublicOperator? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicTriggerScope? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicType? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicAction? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicDiscriminator? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogItem? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogItemLevel? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogPage? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LogItem>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdate? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTriggerScope? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateType? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateAction? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateDiscriminator? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudge? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudgeVariant2? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudge? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudgeVariant2? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudge? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudgeVariant2? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPythonVariant2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPython? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPythonVariant2? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssistantMessage? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssistantMessageRole? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ToolCall>? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolCall? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FunctionCall? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionChoice? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Delta? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogProbs? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionResponse? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ChatCompletionChoice>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Usage? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompletionTokensDetails? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogProb? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LogProb>? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptTokensDetails? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolCallType? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionRequest? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Message>? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Message? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StreamOptions? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResponseFormat? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Tool>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Tool? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptCacheOptions? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Function>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Function? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonSchema? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResponseFormatType? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolType? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublic? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublicType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublicScope? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWrite? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWriteType? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPagePublic? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DashboardPublic>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardUpdatePublic? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardUpdatePublicType? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionPublic? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemPublic>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemPublic? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyPublic? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemPublicType? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemChangesPublic? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatchUpdate? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemFilter>? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemFilter? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemUpdate? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemFilterOperator? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItem>? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItem? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicy? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemType? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Dataset? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetType? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVisibility? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetStatus? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionSummary? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWrite? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWriteType? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWriteVisibility? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResult? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Comment? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItem? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemSource? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItem>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItem? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummary>? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummary? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatch? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItem>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListString? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScore>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScore? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Comment>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemTraceVisibilityMode? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResult>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemStatus? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryStatus? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreSource? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntry>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntry? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntrySource? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatchWrite? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemWrite>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemWrite? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemWriteSource? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemWrite>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemWrite? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyWrite? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemWriteType? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromSpansRequest? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanEnrichmentOptions? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromTracesRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceEnrichmentOptions? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetIdentifier? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemsDelete? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansionResponse? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansion? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansionWrite? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultCompare? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnCompare? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnCompareType>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnCompareType? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CommentCompare? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPageCompare? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemCompare>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemCompare? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnCompare>? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemCompareSource? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemCompare>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemCompare? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyCompare? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemCompare>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompare? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryCompare>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryCompare? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemCompareType? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeCompare? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringCompare? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreCompare>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreCompare? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CommentCompare>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompareTraceVisibilityMode? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResultCompare>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompareStatus? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryCompareStatus? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreCompareSource? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryCompare>? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryCompare? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryCompareSource? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPagePublic? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetPublic>? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublic? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionSummaryPublic? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicType? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicVisibility? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicStatus? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetIdentifierPublic? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AvgValueStatPublic? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublic? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AvgValueStatPublicVariant2? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CountValueStatPublic? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CountValueStatPublicVariant2? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValueStatPublic? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValueStatPublicVariant2? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValuesPublic? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicType? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicDiscriminator? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicDiscriminatorType? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsPublic? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectStatItemObjectPublic>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExportJobPublic? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExportJobPublicStatus? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPublic? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPublicSource? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemPublic>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemPublic? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryPublic>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryPublic? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemPublicTraceVisibilityMode? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryPublicStatus? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnPublic? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnPublicType>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnPublicType? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPagePublic? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemPublic>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnPublic>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Column? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnType>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnType? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PageColumns? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Column>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNode? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodeType? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemStreamRequest? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetUpdate? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetUpdateVisibility? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionDiff? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionDiffStats? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionTag? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionPagePublic? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetVersionPublic>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionRestorePublic? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionRetrieveRequestPublic? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionUpdatePublic? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Environment? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentWrite? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentPagePublic? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EnvironmentPublic>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentPublic? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentUpdate? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentBatchUpdate? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdate? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScore? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdateType? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdateStatus? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScore>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionScoreAverage? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Experiment? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentType? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentEvaluationMethod? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValues? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentStatus? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLink? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionScoreAverage>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScoreWrite? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWrite? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringWrite? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteEvaluationMethod? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteStatus? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScoreWrite>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLinkWrite? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkWrite>? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemsBatch? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemsDelete? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteIdsHolder? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentExecutionResponse? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentInfo>? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentInfo? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentExecutionRequest? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVariant>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVariant? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.JsonNode>? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReference? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Check? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckName? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckResult? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfo? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkRecord? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Trace? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Span>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Span? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkUpload? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecord>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemReference? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidation? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Check>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanType? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSource? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailsValidation>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceVisibilityMode? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReference>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSource? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoExperimentItemBulkWriteView? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringExperimentItemBulkWriteView? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceExperimentItemBulkWriteView? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanExperimentItemBulkWriteView>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteView? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreExperimentItemBulkWriteView>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreExperimentItemBulkWriteView? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkUploadExperimentItemBulkWriteView? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryExperimentItemBulkWriteView>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryExperimentItemBulkWriteView? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteViewType? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteViewSource? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceExperimentItemBulkWriteViewSource? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryExperimentItemBulkWriteViewSource? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionScoreAveragePublic? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CommentPublic? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPagePublic? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentPublic>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublic? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScorePublic? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringPublic? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicEvaluationMethod? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CommentPublic>? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicStatus? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScorePublic>? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLinkPublic? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkPublic>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionScoreAveragePublic>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreNamesPublic? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreNamePublic>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreNamePublic? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentGroupResponse? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContent>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupContent? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupDetails? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupDetail? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GroupDetail>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AggregationData? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentGroupAggregationsResponse? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContentWithAggregations>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupContentWithAggregations? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.IdsHolder? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemStreamRequest? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodePublic? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodePublicType? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentStreamRequestPublic? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinition? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Feedback? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionVariant2? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetail? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinition? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionVariant2? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetail? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackType? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDiscriminator? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDiscriminatorType? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinition? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionVariant2? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetail? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionCreate? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreate? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionCreateVariant2? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailCreate? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionCreate? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionCreateVariant2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailCreate? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateType? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateDiscriminator? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateDiscriminatorType? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionCreate? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionCreateVariant2? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailCreate? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionPublic? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublic? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionPublicVariant2? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailPublic? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionPublic? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionPublicVariant2? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailPublic? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDefinitionPagePublic? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackObjectPublic>? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublic? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicType? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicDiscriminator? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicDiscriminatorType? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionPublic? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionPublicVariant2? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailPublic? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicType? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicDiscriminator? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicDiscriminatorType? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionUpdate? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdate? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionUpdateVariant2? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailUpdate? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionUpdate? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionUpdateVariant2? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailUpdate? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateDiscriminator? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateDiscriminatorType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionUpdate? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionUpdateVariant2? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailUpdate? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Guardrail? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailName? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailResult? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailBatch? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Guardrail>? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailBatchWrite? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailWrite>? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWrite? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWriteName? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWriteResult? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CredentialPublic? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPagePublic? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProviderApiKeyPublic>? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPublic? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPublicProvider? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigPublic? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigPublicSendAs? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CredentialPublic>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Credential? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKey? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyProvider? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfig? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigSendAs? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Credential>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CredentialWrite? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyWrite? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyWriteProvider? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigWrite? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigWriteSendAs? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CredentialWrite>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Result? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthCheck? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyUpdate? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerLogEntry? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitResponse? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitRequest? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitRequestType? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateLocalRunnerJobRequest? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Guid>? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobMetadata? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommand? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandType? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandStatus? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJob? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobStatus? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Agent? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Param>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Param? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunner? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerStatus? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Agent>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerType? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ParamPresence? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerHeartbeatResponse? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerHeartbeatRequest? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobPage? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunnerJob>? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerPage? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunner>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandBatchResponse? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.BridgeCommandItem>? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandItem? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandItemType? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandNextRequest? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandResultRequest? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandResultRequestStatus? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobResultRequest? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobResultRequestStatus? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationResponse? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationRequest? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationRequestEntityType? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaModel? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaInstanceBaseUrlRequest? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaConnectionTestResponse? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Optimization? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStatus? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfig? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPrompt? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModel? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluation? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizer? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetric>? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetric? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessage? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessage>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoWrite? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfigWrite? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPromptWrite? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModelWrite? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluationWrite? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizerWrite? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationWrite? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationWriteStatus? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetricWrite>? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetricWrite? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessageWrite? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessageWrite>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoPublic? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPagePublic? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OptimizationPublic>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPublic? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfigPublic? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPromptPublic? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModelPublic? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluationPublic? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizerPublic? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPublicStatus? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetricPublic>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetricPublic? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessagePublic? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessagePublic>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioLog? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationUpdate? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationUpdateStatus? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ActivateRequest? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionResponse? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionRequest? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionRequestType? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPagePublic? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptPublic>? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPublic? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPublicTemplateStructure? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorCountWithDeviation? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Project? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectVisibility? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectWrite? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectWriteVisibility? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPagePublic? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectPublic>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPublic? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPublicVisibility? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreNames? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreName>? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreName? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TokenUsageNames? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardResponse? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.KpiMetric>? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiMetric? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiMetricType? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardRequest? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardRequestEntityType? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DataPointNumberPublic? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublic? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublicMetricType? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublicInterval? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ResultsNumberPublic>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResultsNumberPublic? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DataPointNumberPublic>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigPublic? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigPublicField? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublic? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublicMetricType? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublicInterval? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsSummary? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectStatsSummaryItem>? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsSummaryItem? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorCountWithDeviationDetailed? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAverageDetailed? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValuesDetailed? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectDetailed? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectDetailedVisibility? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverageDetailed>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageDetailed? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectRetrieveDetailed? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectUpdate? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectUpdateVisibility? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Prompt? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptType? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptTemplateStructure? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersion? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionType? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionVersionType? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionTemplateStructure? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWrite? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWriteType? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWriteTemplateStructure? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeDetail? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetail? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailType? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailVersionType? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailTemplateStructure? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageDetail? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreatePromptVersionDetail? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreatePromptVersionDetailTemplateStructure? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptDetail? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptDetailTemplateStructure? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPagePublic? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionPublic>? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublic? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicType? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicVersionType? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicTemplateStructure? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionCommitsRequestPublic? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionRetrieveDetail? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionIdsRequestDetail? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionEnvironmentUpdate? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptUpdatable? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionBatchUpdate? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionUpdate? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityItemPublic? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityItemPublicType? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityPagePublic? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.RecentActivityItemPublic>? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailure? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailureType? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailurePage? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ReportFailure>? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportCompleteRequest? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportCompleteRequestStatus? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GenerateReportResponse? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportPreference? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReport? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReportStatus? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReportPage? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OllieReport>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublic? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublicLevel? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublicRetention? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRuleWrite? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRuleWriteRetention? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePagePublic? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.RetentionRulePublic>? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ServiceTogglesConfig? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatchUpdate? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdate? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdateType? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdateSource? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWrite? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWriteType? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWriteSource? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatch? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatchWrite? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanWrite>? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteFeedbackScore? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScorePublic? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScorePublicSource? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryPublic>? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryPublic? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublic? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublicType? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScorePublic>? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublicSource? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryPublicSource? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPagePublic? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanPublic>? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatch? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItem>? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItem? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemSource? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublic? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublicType? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanSearchStreamRequestPublicExcludeItem>? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublicExcludeItem? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExistenceResponse? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatchUpdate? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceUpdate? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceUpdateSource? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadBatchUpdate? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUpdate? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadBatchIdentifier? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceWrite? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceWriteSource? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatch? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Trace>? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatchWrite? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceWrite>? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteThreadFeedbackScores? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteTraceThreads? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BatchDeleteByProject? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReferencePublic? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublic? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublicName? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublicResult? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemReferencePublic? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidationPublic? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CheckPublic>? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublic? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailsValidationPublic>? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublicVisibilityMode? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReferencePublic>? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublicSource? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThread? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadStatus? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadIdentifier? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadPage? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThread>? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePagePublic? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TracePublic>? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemThread? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemThreadSource? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchThread? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItemThread>? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadSearchStreamRequest? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSearchStreamRequestPublic? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceSearchStreamRequestPublicExcludeItem>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSearchStreamRequestPublicExcludeItem? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WelcomeWizardTracking? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WelcomeWizardSubmission? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Permission? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceUserPermissions? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Permission>? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricsSummaryRequest? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DataPointDouble? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricResponse? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Result>? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricRequest? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceConfiguration? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfig? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigField? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequest? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequestMetricType? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequestInterval? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceTokenUsageNamesRequest? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricsSummaryResponse? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RevokeRequest? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TokenRequest? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromCsvRequest? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromJsonRequest? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromJsonRequestFormat? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunnerLogEntry>? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindAgentInsightsIssuesStatus? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindAgentInsightsIssuesSeverity? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetWebhookExamplesAlertType? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AttachmentListEntityType? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DownloadAttachmentEntityType? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UploadAttachmentEntityType? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindFeedbackDefinitionsType? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ListRunnersStatus? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindReportFailuresType? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetSpansByProjectType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindFeedbackScoreNames1Type? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetSpanStatsType? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>>? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetExportJobPublic>? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OllamaModel>? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>? Type1078 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.WorkspaceInfo>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.JsonNode>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.WorkspaceProjectName>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.BiInformation>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.WorkspaceProjectUserCount>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.WorkspaceSpansCount>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.WorkspaceTraceCount>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AgentConfigValueWrite>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AgentConfigEnv>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AgentConfigValuePublic>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AgentConfigValueHistory>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AgentBlueprintHistory>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AgentInsightsIssue>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AgentInsightsIssueDetail>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ReportedIssue>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AlertTrigger>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AlertTriggerConfig>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AlertTriggerConfigWrite>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AlertTriggerWrite>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AlertPublic>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AlertTriggerConfigPublic>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AlertTriggerPublic>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueueReviewer>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreAverage>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ScoreCondition>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ConditionGroup>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ScoreConditionWrite>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ConditionGroupWrite>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueue>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueueWrite>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueuePublic>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueueReviewerPublic>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreAveragePublic>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ScoreConditionPublic>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ConditionGroupPublic>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueueItemPublic>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AssertionResultBatchItem>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Attachment>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.MultipartUploadPart>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProjectReference>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceFilter>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanFilter>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceThreadFilter>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessage>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeOutputSchema>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageContent>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceFilterWrite>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanFilterWrite>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceThreadFilterWrite>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageWrite>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeOutputSchemaWrite>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageContentWrite>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceFilterPublic>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProjectReferencePublic>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AutomationRuleEvaluatorObjectObjectPublic>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanFilterPublic>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceThreadFilterPublic>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessagePublic>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeOutputSchemaPublic>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LlmAsJudgeMessageContentPublic>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LogItem>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ToolCall>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ChatCompletionChoice>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LogProb>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Message>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Tool>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Function>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DashboardPublic>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.EvaluatorItemPublic>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetItemFilter>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.EvaluatorItem>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentItem>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetItem>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScore>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Comment>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AssertionResult>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetItemWrite>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.EvaluatorItemWrite>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ColumnCompareType>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetItemCompare>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ColumnCompare>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.EvaluatorItemCompare>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentItemCompare>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreCompare>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CommentCompare>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AssertionResultCompare>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetPublic>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProjectStatItemObjectPublic>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentItemPublic>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ColumnPublicType>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetItemPublic>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ColumnPublic>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ColumnType>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Column>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetVersionPublic>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.EnvironmentPublic>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentScore>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVersionLink>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AssertionScoreAverage>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentScoreWrite>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVersionLinkWrite>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentInfo>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVariant>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Span>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentItemBulkRecord>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Check>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailsValidation>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueueReference>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanExperimentItemBulkWriteView>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreExperimentItemBulkWriteView>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentPublic>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CommentPublic>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ExperimentScorePublic>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVersionLinkPublic>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AssertionScoreAveragePublic>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ScoreNamePublic>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GroupDetail>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackObjectPublic>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Guardrail>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailWrite>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProviderApiKeyPublic>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CredentialPublic>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Credential>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CredentialWrite>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Param>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Agent>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LocalRunnerJob>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LocalRunner>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.BridgeCommandItem>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMetric>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMessage>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMetricWrite>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMessageWrite>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.OptimizationPublic>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMetricPublic>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMessagePublic>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptPublic>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProjectPublic>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ScoreName>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.KpiMetric>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ResultsNumberPublic>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DataPointNumberPublic>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProjectStatsSummaryItem>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreAverageDetailed>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVersionPublic>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.RecentActivityItemPublic>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ReportFailure>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.OllieReport>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.RetentionRulePublic>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanWrite>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScorePublic>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanPublic>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreBatchItem>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanSearchStreamRequestPublicExcludeItem>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Trace>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceWrite>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CheckPublic>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailsValidationPublic>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueueReferencePublic>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceThread>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TracePublic>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreBatchItemThread>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceSearchStreamRequestPublicExcludeItem>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Permission>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Result>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LocalRunnerLogEntry>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetExportJobPublic>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.OllamaModel>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVersionDetail>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>? ListType180 { get; set; }
    }
}