
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Opik.DashboardSavedQuery? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UsageProjectsResponse? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceProjectName>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceProjectName? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UsageProjectsRequest? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BiInformation? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BiInformationResponse? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.BiInformation>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UsageByWorkspaceProjectUserResponse? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceProjectUserCount>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceProjectUserCount? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpansCountResponse? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceSpansCount>? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpansCount? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceCountResponse? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.WorkspaceTraceCount>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceTraceCount? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageWrite? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintWrite? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintWriteType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigValueWrite>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueWrite? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigCreateWrite? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueWriteType? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigEnv? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigEnvUpdate? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigEnv>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintPublic? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintPublicType? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigValuePublic>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValuePublic? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValuePublicType? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessagePublic? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintHistory? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentBlueprintHistoryType? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentConfigValueHistory>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueHistory? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigValueHistoryType? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BlueprintPageHistory? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentBlueprintHistory>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageHistory? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigRemoveValues? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentConfigEnvSetByName? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJob? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJobStatus? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJobUpdate? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsJobUpdateStatus? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsGuidanceUpdate? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssue? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueStatus? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueSeverity? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssuePage? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentInsightsIssue>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueDetail? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueWithDetails? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueWithDetailsStatus? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueWithDetailsSeverity? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AgentInsightsIssueDetail>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsReport? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ReportedIssue>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportedIssue? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportedIssueSeverity? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueUpdate? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AgentInsightsIssueUpdateStatus? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Alert? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertAlertType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Webhook? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTrigger>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTrigger? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerEventType? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfig>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfig? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigType? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigWrite? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigWriteType? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerWrite? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerWriteEventType? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigWrite>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertWrite? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertWriteAlertType? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookWrite? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerWrite>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BatchDelete? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertPagePublic? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertPublic>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertPublic? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigPublic? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerConfigPublicType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerPublic? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertTriggerPublicEventType? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerConfigPublic>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AlertPublicAlertType? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookPublic? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AlertTriggerPublic>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookExamples? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookTestResult? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WebhookTestResultStatus? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemIds? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueue? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueScope? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomation? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewer>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReviewer? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverage>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAverage? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Conditions? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroup? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreCondition>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreCondition? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroup>? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionOperator? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomationWrite? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionsWrite? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueWrite? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueWriteScope? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroupWrite? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreConditionWrite>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionWrite? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroupWrite>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionWriteOperator? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueBatch? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueue>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueBatchWrite? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueWrite>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomationPublic? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionsPublic? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePagePublic? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueuePublic>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePublic? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReviewerPublic? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePublicScope? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewerPublic>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAveragePublic? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroupPublic? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreConditionPublic>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionPublic? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroupPublic>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionPublicOperator? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ItemLockInfo? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocksResponse? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ItemLockInfo>? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LockResponse? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemPublic? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemPublicSource? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemsPublic? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueItemPublic>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemIdsPublic? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueUpdate? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatch? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchEntityType? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResultBatchItem>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItem? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItemStatus? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItemSource? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Attachment? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AttachmentPage? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Attachment>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompleteMultipartUploadRequest? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompleteMultipartUploadRequestEntityType? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.MultipartUploadPart>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.MultipartUploadPart? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteAttachmentsRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteAttachmentsRequestEntityType? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadResponse? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadRequestEntityType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AuthDetailsHolder? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceNameHolder? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrl? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluator? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectReference>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectReference? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTriggerScope? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorType? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorAction? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorDiscriminator? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorDiscriminatorType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudge? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeVariant2? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilter>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilter? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCode? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudge? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeVariant2? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilter>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilter? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCode? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPython? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonVariant2? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCode? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudge? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeVariant2? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilter>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilter? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCode? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonVariant2? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCode? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPython? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonVariant2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCode? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrl? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParameters? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessage>? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessage? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchema>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchema? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageRole? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContent>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContent? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrl? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaType? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterOperator? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterOperator? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterOperator? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrlWrite? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeWrite? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWrite? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeWriteVariant2? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterWrite>? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterWrite? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCodeWrite? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWrite? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWriteVariant2? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterWrite>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterWrite? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCodeWrite? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWriteVariant2? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCodeWrite? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWriteVariant2? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterWrite>? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterWrite? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCodeWrite? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWriteVariant2? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCodeWrite? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWrite? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCodeWrite? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteTriggerScope? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteType? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteAction? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteDiscriminator? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrlWrite? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeWrite? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersWrite? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageWrite>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageWrite? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaWrite>? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaWrite? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContentWrite? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrlWrite? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageWriteRole? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentWrite>? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaWriteType? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterWriteOperator? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterWriteOperator? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterWriteOperator? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrlPublic? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgePublic? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublic? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgePublicVariant2? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterPublic? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCodePublic? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublic? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectReferencePublic>? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectReferencePublic? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicType? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminator? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPagePublic? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AutomationRuleEvaluatorObjectObjectPublic>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublic? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterPublic? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCodePublic? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublic? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublicVariant2? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCodePublic? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublicVariant2? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterPublic? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCodePublic? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublic? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublicVariant2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCodePublic? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublic? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublicVariant2? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCodePublic? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrlPublic? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodePublic? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersPublic? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessagePublic>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessagePublic? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaPublic>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaPublic? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContentPublic? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrlPublic? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessagePublicRole? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentPublic>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaPublicType? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterPublicOperator? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterPublicOperator? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterPublicOperator? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicTriggerScope? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicType? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicAction? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicDiscriminator? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogItem? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogItemLevel? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogPage? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LogItem>? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdate? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTriggerScope? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateType? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateAction? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateDiscriminator? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudge? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudgeVariant2? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudge? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudgeVariant2? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudge? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudgeVariant2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPythonVariant2? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPython? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPythonVariant2? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssistantMessage? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssistantMessageRole? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ToolCall>? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolCall? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FunctionCall? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionChoice? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Delta? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogProbs? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionResponse? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ChatCompletionChoice>? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Usage? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompletionTokensDetails? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogProb? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LogProb>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptTokensDetails? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolCallType? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionRequest? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Message>? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Message? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StreamOptions? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResponseFormat? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Tool>? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Tool? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptCacheOptions? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Function>? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Function? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonSchema? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResponseFormatType? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolType? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublic? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublicType? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublicScope? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWrite? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWriteType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPagePublic? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DashboardPublic>? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWidgetQueryRequest? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardUpdatePublic? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardUpdatePublicType? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionPublic? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemPublic>? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemPublic? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyPublic? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemPublicType? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemChangesPublic? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatchUpdate? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemFilter>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemFilter? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemUpdate? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemFilterOperator? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItem>? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItem? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicy? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemType? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Dataset? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetType? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVisibility? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetStatus? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionSummary? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWrite? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWriteType? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWriteVisibility? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResult? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Comment? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItem? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemSource? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItem>? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItem? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummary>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummary? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatch? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItem>? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListString? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScore>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScore? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Comment>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemTraceVisibilityMode? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResult>? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemStatus? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryStatus? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreSource? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntry>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntry? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntrySource? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatchWrite? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemWrite>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemWrite? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemWriteSource? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemWrite>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemWrite? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyWrite? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemWriteType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromSpansRequest? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanEnrichmentOptions? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromTracesRequest? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceEnrichmentOptions? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetIdentifier? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemsDelete? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansionResponse? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansion? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansionWrite? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultCompare? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnCompare? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnCompareType>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnCompareType? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CommentCompare? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPageCompare? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemCompare>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemCompare? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnCompare>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemCompareSource? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemCompare>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemCompare? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyCompare? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemCompare>? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompare? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryCompare>? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryCompare? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemCompareType? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeCompare? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringCompare? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreCompare>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreCompare? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CommentCompare>? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompareTraceVisibilityMode? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResultCompare>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompareStatus? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryCompareStatus? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreCompareSource? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryCompare>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryCompare? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryCompareSource? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPagePublic? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetPublic>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublic? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionSummaryPublic? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicType? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicVisibility? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicStatus? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetIdentifierPublic? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AvgValueStatPublic? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublic? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AvgValueStatPublicVariant2? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CountValueStatPublic? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CountValueStatPublicVariant2? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValueStatPublic? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValueStatPublicVariant2? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValuesPublic? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicType? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicDiscriminator? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicDiscriminatorType? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsPublic? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectStatItemObjectPublic>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExportJobPublic? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExportJobPublicStatus? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPublic? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPublicSource? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemPublic>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemPublic? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryPublic>? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryPublic? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemPublicTraceVisibilityMode? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryPublicStatus? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnPublic? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnPublicType>? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnPublicType? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPagePublic? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemPublic>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnPublic>? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Column? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnType>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PageColumns? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Column>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNode? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodeType? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemStreamRequest? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetUpdate? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetUpdateVisibility? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionDiff? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionDiffStats? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionTag? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionPagePublic? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetVersionPublic>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionRestorePublic? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionRetrieveRequestPublic? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionUpdatePublic? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Environment? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentWrite? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentPagePublic? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EnvironmentPublic>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentPublic? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentUpdate? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentBatchUpdate? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdate? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScore? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdateType? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdateStatus? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScore>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionScoreAverage? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Experiment? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentType? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentEvaluationMethod? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValues? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentStatus? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLink? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionScoreAverage>? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScoreWrite? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWrite? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringWrite? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteType? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteEvaluationMethod? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteStatus? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScoreWrite>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLinkWrite? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkWrite>? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemsBatch? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemsDelete? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteIdsHolder? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentExecutionResponse? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentInfo>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentInfo? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentExecutionRequest? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVariant>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVariant? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.JsonNode>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReference? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Check? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckName? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckResult? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfo? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkRecord? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Trace? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Span>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Span? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkUpload? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecord>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemReference? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidation? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Check>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanType? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSource? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailsValidation>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceVisibilityMode? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReference>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSource? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoExperimentItemBulkWriteView? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringExperimentItemBulkWriteView? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceExperimentItemBulkWriteView? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanExperimentItemBulkWriteView>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteView? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreExperimentItemBulkWriteView>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreExperimentItemBulkWriteView? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkUploadExperimentItemBulkWriteView? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView>? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryExperimentItemBulkWriteView>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryExperimentItemBulkWriteView? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteViewType? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteViewSource? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceExperimentItemBulkWriteViewSource? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryExperimentItemBulkWriteViewSource? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionScoreAveragePublic? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CommentPublic? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPagePublic? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentPublic>? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublic? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScorePublic? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringPublic? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicType? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicEvaluationMethod? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CommentPublic>? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicStatus? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScorePublic>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLinkPublic? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkPublic>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionScoreAveragePublic>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreNamesPublic? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreNamePublic>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreNamePublic? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentGroupResponse? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContent>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupContent? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupDetails? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupDetail? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GroupDetail>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AggregationData? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentGroupAggregationsResponse? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContentWithAggregations>? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupContentWithAggregations? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.IdsHolder? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemStreamRequest? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodePublic? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodePublicType? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentStreamRequestPublic? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinition? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Feedback? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionVariant2? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetail? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinition? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionVariant2? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetail? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackType? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDiscriminator? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDiscriminatorType? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinition? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionVariant2? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetail? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionCreate? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreate? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionCreateVariant2? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailCreate? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionCreate? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionCreateVariant2? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailCreate? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateType? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateDiscriminator? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateDiscriminatorType? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionCreate? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionCreateVariant2? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailCreate? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionPublic? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublic? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionPublicVariant2? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailPublic? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionPublic? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionPublicVariant2? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailPublic? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDefinitionPagePublic? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackObjectPublic>? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublic? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicType? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicDiscriminator? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicDiscriminatorType? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionPublic? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionPublicVariant2? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailPublic? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicType? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicDiscriminator? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicDiscriminatorType? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionUpdate? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdate? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionUpdateVariant2? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailUpdate? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionUpdate? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionUpdateVariant2? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailUpdate? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateType? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateDiscriminator? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateDiscriminatorType? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionUpdate? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionUpdateVariant2? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailUpdate? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Guardrail? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailName? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailResult? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailBatch? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Guardrail>? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailBatchWrite? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailWrite>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWrite? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWriteName? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWriteResult? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CredentialPublic? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPagePublic? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProviderApiKeyPublic>? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPublic? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPublicProvider? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigPublic? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigPublicSendAs? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CredentialPublic>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Credential? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKey? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyProvider? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfig? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigSendAs? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Credential>? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CredentialWrite? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyWrite? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyWriteProvider? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigWrite? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigWriteSendAs? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CredentialWrite>? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Result? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthCheck? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyUpdate? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerLogEntry? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitResponse? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitRequest? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitRequestType? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateLocalRunnerJobRequest? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Guid>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobMetadata? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommand? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandType? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandStatus? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJob? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobStatus? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Agent? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Param>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Param? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunner? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerStatus? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Agent>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ParamPresence? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerHeartbeatResponse? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerHeartbeatRequest? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobPage? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunnerJob>? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerPage? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunner>? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandBatchResponse? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.BridgeCommandItem>? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandItem? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandItemType? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandNextRequest? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandResultRequest? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandResultRequestStatus? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobResultRequest? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobResultRequestStatus? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationResponse? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationRequest? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationRequestEntityType? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaModel? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaInstanceBaseUrlRequest? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaConnectionTestResponse? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Optimization? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStatus? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfig? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPrompt? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModel? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluation? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizer? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetric>? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetric? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessage? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessage>? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoWrite? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfigWrite? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPromptWrite? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModelWrite? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluationWrite? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizerWrite? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationWrite? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationWriteStatus? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetricWrite>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetricWrite? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessageWrite? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessageWrite>? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoPublic? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPagePublic? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OptimizationPublic>? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPublic? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfigPublic? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPromptPublic? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModelPublic? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluationPublic? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizerPublic? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPublicStatus? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetricPublic>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetricPublic? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessagePublic? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessagePublic>? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioLog? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationUpdate? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationUpdateStatus? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ActivateRequest? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionResponse? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionRequest? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionRequestType? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPagePublic? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptPublic>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPublic? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPublicTemplateStructure? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorCountWithDeviation? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Project? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectVisibility? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectWrite? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectWriteVisibility? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPagePublic? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectPublic>? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPublic? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPublicVisibility? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreNames? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreName>? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreName? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TokenUsageNames? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardResponse? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.KpiMetric>? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiMetric? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiMetricType? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardRequest? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardRequestEntityType? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DataPointNumberPublic? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublic? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublicMetricType? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublicInterval? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ResultsNumberPublic>? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResultsNumberPublic? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DataPointNumberPublic>? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigPublic? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigPublicField? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublic? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublicMetricType? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublicInterval? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsSummary? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectStatsSummaryItem>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsSummaryItem? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorCountWithDeviationDetailed? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAverageDetailed? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValuesDetailed? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectDetailed? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectDetailedVisibility? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverageDetailed>? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageDetailed? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectRetrieveDetailed? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectUpdate? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectUpdateVisibility? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Prompt? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptType? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptTemplateStructure? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersion? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionType? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionVersionType? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionTemplateStructure? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWrite? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWriteType? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWriteTemplateStructure? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeDetail? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetail? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailType? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailVersionType? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailTemplateStructure? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageDetail? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreatePromptVersionDetail? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreatePromptVersionDetailTemplateStructure? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptDetail? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptDetailTemplateStructure? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPagePublic? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionPublic>? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublic? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicType? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicVersionType? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicTemplateStructure? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionCommitsRequestPublic? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionRetrieveDetail? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionIdsRequestDetail? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionEnvironmentUpdate? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptUpdatable? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionBatchUpdate? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionUpdate? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityItemPublic? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityItemPublicType? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityPagePublic? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.RecentActivityItemPublic>? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailure? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailureType? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailurePage? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ReportFailure>? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportCompleteRequest? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportCompleteRequestStatus? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GenerateReportResponse? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportPreference? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReport? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReportStatus? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReportPage? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OllieReport>? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublic? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublicLevel? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublicRetention? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRuleWrite? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRuleWriteRetention? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePagePublic? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.RetentionRulePublic>? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ServiceTogglesConfig? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatchUpdate? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdate? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdateType? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdateSource? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWrite? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWriteType? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWriteSource? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatch? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatchWrite? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanWrite>? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteFeedbackScore? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScorePublic? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScorePublicSource? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryPublic>? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryPublic? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublic? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublicType? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScorePublic>? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublicSource? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryPublicSource? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPagePublic? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanPublic>? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatch? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItem>? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItem? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemSource? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublic? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublicType? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanSearchStreamRequestPublicExcludeItem>? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublicExcludeItem? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExistenceResponse? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatchUpdate? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceUpdate? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceUpdateSource? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadBatchUpdate? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUpdate? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadBatchIdentifier? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceWrite? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceWriteSource? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatch? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Trace>? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatchWrite? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceWrite>? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteThreadFeedbackScores? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteTraceThreads? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BatchDeleteByProject? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReferencePublic? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublic? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublicName? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublicResult? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemReferencePublic? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidationPublic? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CheckPublic>? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublic? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailsValidationPublic>? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublicVisibilityMode? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReferencePublic>? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublicSource? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThread? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadStatus? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadIdentifier? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadPage? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThread>? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePagePublic? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TracePublic>? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemThread? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemThreadSource? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchThread? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItemThread>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadSearchStreamRequest? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSearchStreamRequestPublic? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceSearchStreamRequestPublicExcludeItem>? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSearchStreamRequestPublicExcludeItem? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WelcomeWizardTracking? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WelcomeWizardSubmission? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Permission? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceUserPermissions? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Permission>? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricsSummaryRequest? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DataPointDouble? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricResponse? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Result>? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricRequest? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceConfiguration? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfig? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigField? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequest? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequestMetricType? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequestInterval? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceTokenUsageNamesRequest? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricsSummaryResponse? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RevokeRequest? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TokenRequest? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromCsvRequest? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromJsonRequest? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromJsonRequestFormat? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunnerLogEntry>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindAgentInsightsIssuesStatus? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindAgentInsightsIssuesSeverity? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetWebhookExamplesAlertType? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AttachmentListEntityType? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DownloadAttachmentEntityType? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UploadAttachmentEntityType? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindFeedbackDefinitionsType? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ListRunnersStatus? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindReportFailuresType? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetSpansByProjectType? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindFeedbackScoreNames1Type? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetSpanStatsType? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>>? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetExportJobPublic>? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OllamaModel>? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>? Type1081 { get; set; }

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