
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
        public global::Opik.AnnotationQueueAnnotatorView? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewer>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReviewer? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverage>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAverage? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Conditions? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroup? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreCondition>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreCondition? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroup>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionOperator? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAnnotatorViewWrite? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomationWrite? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionsWrite? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueWrite? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueWriteScope? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroupWrite? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreConditionWrite>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionWrite? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroupWrite>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionWriteOperator? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueBatch? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueue>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueBatchWrite? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueWrite>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAnnotatorViewPublic? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueAutomationPublic? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionsPublic? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePagePublic? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueuePublic>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePublic? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReviewerPublic? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueuePublicScope? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReviewerPublic>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAveragePublic>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAveragePublic? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ConditionGroupPublic? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreConditionPublic>? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionPublic? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ConditionGroupPublic>? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreConditionPublicOperator? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ItemLockInfo? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocksResponse? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ItemLockInfo>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LockResponse? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemPublic? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemPublicSource? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemsPublic? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueItemPublic>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueItemIdsPublic? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueUpdate? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatch? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchEntityType? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResultBatchItem>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItem? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItemStatus? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultBatchItemSource? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Attachment? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AttachmentPage? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Attachment>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompleteMultipartUploadRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompleteMultipartUploadRequestEntityType? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.MultipartUploadPart>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.MultipartUploadPart? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteAttachmentsRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteAttachmentsRequestEntityType? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadResponse? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadRequest? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StartMultipartUploadRequestEntityType? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AuthDetailsHolder? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceNameHolder? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrl? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluator? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectReference>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectReference? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTriggerScope? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorType? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorAction? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorDiscriminator? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorDiscriminatorType? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudge? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeVariant2? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilter>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilter? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCode? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudge? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeVariant2? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilter>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilter? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCode? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPython? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonVariant2? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCode? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudge? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeVariant2? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilter>? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilter? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCode? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPython? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonVariant2? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCode? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPython? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonVariant2? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCode? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrl? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParameters? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessage>? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessage? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchema>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchema? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageRole? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContent>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContent? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrl? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersApi? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaType? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterOperator? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterOperator? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterOperator? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrlWrite? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeWrite? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWrite? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgeWriteVariant2? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterWrite>? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterWrite? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCodeWrite? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWrite? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgeWriteVariant2? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterWrite>? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterWrite? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCodeWrite? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWrite? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonWriteVariant2? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCodeWrite? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWrite? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgeWriteVariant2? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterWrite>? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterWrite? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCodeWrite? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWrite? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonWriteVariant2? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCodeWrite? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWrite? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonWriteVariant2? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCodeWrite? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteTriggerScope? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteType? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteAction? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteDiscriminator? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorWriteDiscriminatorType? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrlWrite? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeWrite? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersWrite? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageWrite>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageWrite? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaWrite>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaWrite? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContentWrite? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrlWrite? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageWriteRole? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentWrite>? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersWriteApi? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaWriteType? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterWriteOperator? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterWriteOperator? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterWriteOperator? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AudioUrlPublic? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgePublic? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublic? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorLlmAsJudgePublicVariant2? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceFilterPublic>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterPublic? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeCodePublic? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublic? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectReferencePublic>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectReferencePublic? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicTriggerScope? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicType? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicAction? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminator? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPagePublic? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AutomationRuleEvaluatorObjectObjectPublic>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublic? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanLlmAsJudgePublicVariant2? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanFilterPublic>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterPublic? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanLlmAsJudgeCodePublic? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublic? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorSpanUserDefinedMetricPythonPublicVariant2? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUserDefinedMetricPythonCodePublic? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublic? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadLlmAsJudgePublicVariant2? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThreadFilterPublic>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterPublic? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadLlmAsJudgeCodePublic? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublic? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorTraceThreadUserDefinedMetricPythonPublicVariant2? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUserDefinedMetricPythonCodePublic? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublic? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUserDefinedMetricPythonPublicVariant2? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UserDefinedMetricPythonCodePublic? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ImageUrlPublic? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodePublic? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersPublic? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessagePublic>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessagePublic? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeOutputSchemaPublic>? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaPublic? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessageContentPublic? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.VideoUrlPublic? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeMessagePublicRole? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LlmAsJudgeMessageContentPublic>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeModelParametersPublicApi? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LlmAsJudgeOutputSchemaPublicType? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanFilterPublicOperator? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceFilterPublicOperator? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadFilterPublicOperator? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicTriggerScope? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicType? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicAction? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicDiscriminator? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorPublicDiscriminatorType? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogItem? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogItemLevel? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogPage? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LogItem>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdate? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTriggerScope? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateType? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateAction? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateDiscriminator? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateDiscriminatorType? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudge? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateLlmAsJudgeVariant2? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudge? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanLlmAsJudgeVariant2? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPython? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateSpanUserDefinedMetricPythonVariant2? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudge? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadLlmAsJudgeVariant2? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPython? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateTraceThreadUserDefinedMetricPythonVariant2? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPython? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AutomationRuleEvaluatorUpdateUserDefinedMetricPythonVariant2? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssistantMessage? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssistantMessageRole? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ToolCall>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolCall? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FunctionCall? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionChoice? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Delta? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogProbs? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionResponse? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ChatCompletionChoice>? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Usage? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CompletionTokensDetails? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LogProb? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LogProb>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptTokensDetails? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolCallType? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChatCompletionRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Message>? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Message? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StreamOptions? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, int>? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResponseFormat? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Tool>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Tool? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptCacheOptions? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Function>? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Function? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonSchema? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResponseFormatType? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolType? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublic? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublicType? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPublicScope? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWrite? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWriteType? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardPagePublic? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DashboardPublic>? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardWidgetQueryRequest? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardUpdatePublic? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DashboardUpdatePublicType? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionPublic? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemPublic>? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemPublic? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyPublic? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemPublicType? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemChangesPublic? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatchUpdate? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemFilter>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemFilter? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemUpdate? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemFilterOperator? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItem>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItem? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicy? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemType? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Dataset? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetType? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVisibility? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetStatus? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionSummary? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWrite? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWriteType? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetWriteVisibility? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResult? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Comment? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItem? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemSource? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItem>? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItem? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummary>? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummary? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatch? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItem>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListString? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScore>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScore? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Comment>? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, long>? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemTraceVisibilityMode? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResult>? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemStatus? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryStatus? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreSource? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntry>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntry? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntrySource? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemBatchWrite? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemWrite>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemWrite? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemWriteSource? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemWrite>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemWrite? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyWrite? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemWriteType? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromSpansRequest? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanEnrichmentOptions? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromTracesRequest? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceEnrichmentOptions? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetIdentifier? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemsDelete? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansionResponse? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansion? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExpansionWrite? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionResultCompare? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnCompare? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnCompareType>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnCompareType? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CommentCompare? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPageCompare? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemCompare>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemCompare? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnCompare>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemCompareSource? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EvaluatorItemCompare>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemCompare? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExecutionPolicyCompare? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemCompare>? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompare? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryCompare>? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryCompare? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EvaluatorItemCompareType? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeCompare? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringCompare? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreCompare>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreCompare? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CommentCompare>? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompareTraceVisibilityMode? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionResultCompare>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemCompareStatus? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryCompareStatus? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreCompareSource? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryCompare>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryCompare? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryCompareSource? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPagePublic? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetPublic>? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublic? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionSummaryPublic? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicType? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicVisibility? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetPublicStatus? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetIdentifierPublic? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AvgValueStatPublic? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublic? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AvgValueStatPublicVariant2? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CountValueStatPublic? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CountValueStatPublicVariant2? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValueStatPublic? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValueStatPublicVariant2? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValuesPublic? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicType? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicDiscriminator? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatItemObjectPublicDiscriminatorType? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsPublic? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectStatItemObjectPublic>? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExportJobPublic? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExportJobPublicStatus? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPublic? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPublicSource? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemPublic>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemPublic? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ExperimentRunSummaryPublic>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryPublic? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemPublicTraceVisibilityMode? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentRunSummaryPublicStatus? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnPublic? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnPublicType>? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnPublicType? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemPagePublic? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetItemPublic>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnPublic>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Column? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ColumnType>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ColumnType? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PageColumns? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Column>? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNode? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodeType? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetExperimentItemStreamRequest? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetItemStreamRequest? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetUpdate? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetUpdateVisibility? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionDiff? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionDiffStats? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionTag? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionPagePublic? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetVersionPublic>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionRestorePublic? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionRetrieveRequestPublic? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DatasetVersionUpdatePublic? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Environment? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentWrite? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentPagePublic? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.EnvironmentPublic>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentPublic? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EnvironmentUpdate? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentBatchUpdate? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdate? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScore? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdateType? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentUpdateStatus? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScore>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.IdsHolder? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionScoreAverage? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Experiment? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentType? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentEvaluationMethod? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValues? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentStatus? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLink? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLink>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionScoreAverage>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScoreWrite? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWrite? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringWrite? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteType? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteEvaluationMethod? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentWriteStatus? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScoreWrite>? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLinkWrite? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkWrite>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemsBatch? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemsDelete? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteIdsHolder? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentExecutionResponse? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentInfo>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentInfo? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentExecutionRequest? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVariant>? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVariant? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.JsonNode>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReference? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Check? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckName? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckResult? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfo? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkRecord? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Trace? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Span>? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Span? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkUpload? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecord>? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemReference? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidation? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Check>? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanType? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSource? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailsValidation>? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceVisibilityMode? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReference>? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSource? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoExperimentItemBulkWriteView? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringExperimentItemBulkWriteView? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceExperimentItemBulkWriteView? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanExperimentItemBulkWriteView>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteView? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreExperimentItemBulkWriteView>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreExperimentItemBulkWriteView? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemBulkUploadExperimentItemBulkWriteView? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentItemBulkRecordExperimentItemBulkWriteView>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreExperimentItemBulkWriteViewSource? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryExperimentItemBulkWriteView>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryExperimentItemBulkWriteView? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteViewType? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanExperimentItemBulkWriteViewSource? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceExperimentItemBulkWriteViewSource? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryExperimentItemBulkWriteViewSource? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AssertionScoreAveragePublic? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CommentPublic? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPagePublic? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentPublic>? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublic? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentScorePublic? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonListStringPublic? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicType? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicEvaluationMethod? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CommentPublic>? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentPublicStatus? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ExperimentScorePublic>? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionLinkPublic? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionLinkPublic>? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AssertionScoreAveragePublic>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreNamesPublic? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreNamePublic>? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreNamePublic? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentGroupResponse? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContent>? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupContent? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupDetails? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupDetail? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GroupDetail>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AggregationData? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentGroupAggregationsResponse? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.GroupContentWithAggregations>? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GroupContentWithAggregations? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemStreamRequest? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodePublic? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ChunkedOutputJsonNodePublicType? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentStreamRequestPublic? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinition? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Feedback? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionVariant2? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetail? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinition? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionVariant2? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetail? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackType? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDiscriminator? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDiscriminatorType? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinition? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionVariant2? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetail? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionCreate? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreate? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionCreateVariant2? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailCreate? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionCreate? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionCreateVariant2? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailCreate? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateType? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateDiscriminator? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackCreateDiscriminatorType? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionCreate? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionCreateVariant2? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailCreate? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionPublic? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublic? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionPublicVariant2? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailPublic? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionPublic? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionPublicVariant2? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailPublic? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackDefinitionPagePublic? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackObjectPublic>? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublic? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicType? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicDiscriminator? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackObjectPublicDiscriminatorType? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionPublic? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionPublicVariant2? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailPublic? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicDiscriminator? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackPublicDiscriminatorType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionUpdate? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdate? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDefinitionUpdateVariant2? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BooleanFeedbackDetailUpdate? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionUpdate? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDefinitionUpdateVariant2? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CategoricalFeedbackDetailUpdate? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateDiscriminator? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackUpdateDiscriminatorType? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionUpdate? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDefinitionUpdateVariant2? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumericalFeedbackDetailUpdate? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailModel? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailTrainingRun? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailModelPage? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailModel>? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailTrainingRunStatus? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailTrainingRunPage? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailTrainingRun>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailModelUpdate? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicy? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyExecutionScope? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRule>? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyRule? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyRuleType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyRuleWrite? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyRuleWriteType? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyWrite? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyWriteExecutionScope? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRuleWrite>? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyPagePublic? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyPublic>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyPublic? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyRulePublic? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyRulePublicType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailPolicyPublicExecutionScope? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailPolicyRulePublic>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Guardrail? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailName? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailResult? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailBatch? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Guardrail>? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailBatchWrite? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailWrite>? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWrite? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWriteName? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailWriteResult? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidationResponse? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ValidationResult>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValidationResult? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValidationResultType? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidationRequest? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ValidationDescriptor>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValidationDescriptor? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValidationDescriptorType? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.EffortParam? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FlagParam? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ModelParams? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.NumberParam? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolsParam? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ModelParams>? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ToolsParamChatCompletions? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CredentialPublic? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPagePublic? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProviderApiKeyPublic>? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPublic? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyPublicProvider? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigPublic? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigPublicSendAs? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CredentialPublic>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Credential? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKey? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyProvider? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfig? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigSendAs? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Credential>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CredentialWrite? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyWrite? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyWriteProvider? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigWrite? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthConfigWriteSendAs? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CredentialWrite>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Result? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderAuthCheck? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProviderApiKeyUpdate? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerLogEntry? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitResponse? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitRequest? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandSubmitRequestType? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateLocalRunnerJobRequest? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Guid>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobMetadata? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommand? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandType? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandStatus? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJob? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobStatus? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Agent? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Param>? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Param? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunner? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerStatus? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Agent>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerType? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ParamPresence? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerHeartbeatResponse? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerHeartbeatRequest? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobPage? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunnerJob>? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerPage? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunner>? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandBatchResponse? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.BridgeCommandItem>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandItem? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandItemType? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandNextRequest? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandResultRequest? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BridgeCommandResultRequestStatus? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobResultRequest? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.LocalRunnerJobResultRequestStatus? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationResponse? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationRequest? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ManualEvaluationRequestEntityType? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaModel? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaInstanceBaseUrlRequest? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllamaConnectionTestResponse? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Optimization? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStatus? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfig? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPrompt? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModel? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluation? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizer? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetric>? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetric? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessage? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessage>? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoWrite? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfigWrite? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPromptWrite? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModelWrite? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluationWrite? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizerWrite? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationWrite? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationWriteStatus? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetricWrite>? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetricWrite? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessageWrite? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessageWrite>? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorInfoPublic? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPagePublic? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OptimizationPublic>? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPublic? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioConfigPublic? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioPromptPublic? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioLlmModelPublic? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioEvaluationPublic? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioOptimizerPublic? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationPublicStatus? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMetricPublic>? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMetricPublic? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.StudioMessagePublic? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.StudioMessagePublic>? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationStudioLog? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationUpdate? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OptimizationUpdateStatus? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ActivateRequest? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionResponse? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionRequest? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateSessionRequestType? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPagePublic? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptPublic>? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPublic? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptPublicTemplateStructure? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorCountWithDeviation? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Project? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectVisibility? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectWrite? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectWriteVisibility? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPagePublic? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectPublic>? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPublic? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectPublicVisibility? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreNames? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ScoreName>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ScoreName? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TokenUsageNames? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardResponse? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.KpiMetric>? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiMetric? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiMetricType? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardRequest? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.KpiCardRequestEntityType? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DataPointNumberPublic? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublic? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublicMetricType? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricResponsePublicInterval? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ResultsNumberPublic>? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ResultsNumberPublic? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DataPointNumberPublic>? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigPublic? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigPublicField? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublic? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublicMetricType? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectMetricRequestPublicInterval? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsSummary? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ProjectStatsSummaryItem>? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectStatsSummaryItem? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorCountWithDeviationDetailed? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreAverageDetailed? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PercentageValuesDetailed? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectDetailed? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectDetailedVisibility? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreAverageDetailed>? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageDetailed? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectRetrieveDetailed? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectUpdate? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectUpdateVisibility? Type944 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Prompt? Type945 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptType? Type946 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptTemplateStructure? Type947 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersion? Type948 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionType? Type949 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionVersionType? Type950 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionTemplateStructure? Type951 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWrite? Type952 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWriteType? Type953 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptWriteTemplateStructure? Type954 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.JsonNodeDetail? Type955 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetail? Type956 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailType? Type957 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailVersionType? Type958 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionDetailTemplateStructure? Type959 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ErrorMessageDetail? Type960 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreatePromptVersionDetail? Type961 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreatePromptVersionDetailTemplateStructure? Type962 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptDetail? Type963 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptDetailTemplateStructure? Type964 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPagePublic? Type965 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionPublic>? Type966 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublic? Type967 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicType? Type968 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicVersionType? Type969 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionPublicTemplateStructure? Type970 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionCommitsRequestPublic? Type971 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionRetrieveDetail? Type972 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionIdsRequestDetail? Type973 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionEnvironmentUpdate? Type974 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptUpdatable? Type975 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionBatchUpdate? Type976 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.PromptVersionUpdate? Type977 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityItemPublic? Type978 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityItemPublicType? Type979 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RecentActivityPagePublic? Type980 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.RecentActivityItemPublic>? Type981 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailure? Type982 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailureType? Type983 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportFailurePage? Type984 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ReportFailure>? Type985 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportCompleteRequest? Type986 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportCompleteRequestStatus? Type987 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GenerateReportResponse? Type988 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ReportPreference? Type989 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReport? Type990 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReportStatus? Type991 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OllieReportPage? Type992 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OllieReport>? Type993 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublic? Type994 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublicLevel? Type995 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePublicRetention? Type996 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRuleWrite? Type997 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRuleWriteRetention? Type998 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetentionRulePagePublic? Type999 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.RetentionRulePublic>? Type1000 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ServiceTogglesConfig? Type1001 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatchUpdate? Type1002 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdate? Type1003 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdateType? Type1004 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanUpdateSource? Type1005 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWrite? Type1006 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWriteType? Type1007 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanWriteSource? Type1008 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatch? Type1009 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanBatchWrite? Type1010 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanWrite>? Type1011 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteFeedbackScore? Type1012 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScorePublic? Type1013 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScorePublicSource? Type1014 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ValueEntryPublic>? Type1015 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryPublic? Type1016 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublic? Type1017 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublicType? Type1018 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScorePublic>? Type1019 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPublicSource? Type1020 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ValueEntryPublicSource? Type1021 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanPagePublic? Type1022 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanPublic>? Type1023 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatch? Type1024 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItem>? Type1025 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItem? Type1026 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemSource? Type1027 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublic? Type1028 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublicType? Type1029 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.SpanSearchStreamRequestPublicExcludeItem>? Type1030 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.SpanSearchStreamRequestPublicExcludeItem? Type1031 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExistenceResponse? Type1032 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Attempt? Type1033 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AttemptStatus? Type1034 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DayCount? Type1035 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.OtherStats? Type1036 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DayCount>? Type1037 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectTopics? Type1038 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ProjectTopicsStatus? Type1039 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TopicStats>? Type1040 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TopicStats? Type1041 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatchUpdate? Type1042 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceUpdate? Type1043 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceUpdateSource? Type1044 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadBatchUpdate? Type1045 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadUpdate? Type1046 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadBatchIdentifier? Type1047 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceWrite? Type1048 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceWriteSource? Type1049 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatch? Type1050 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Trace>? Type1051 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceBatchWrite? Type1052 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceWrite>? Type1053 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteThreadFeedbackScores? Type1054 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DeleteTraceThreads? Type1055 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BatchDeleteByProject? Type1056 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnnotationQueueReferencePublic? Type1057 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublic? Type1058 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublicName? Type1059 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CheckPublicResult? Type1060 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ExperimentItemReferencePublic? Type1061 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GuardrailsValidationPublic? Type1062 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.CheckPublic>? Type1063 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublic? Type1064 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.GuardrailsValidationPublic>? Type1065 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublicVisibilityMode? Type1066 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnnotationQueueReferencePublic>? Type1067 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePublicSource? Type1068 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThread? Type1069 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadStatus? Type1070 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadIdentifier? Type1071 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadPage? Type1072 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceThread>? Type1073 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TracePagePublic? Type1074 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TracePublic>? Type1075 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemThread? Type1076 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchItemThreadSource? Type1077 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FeedbackScoreBatchThread? Type1078 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.FeedbackScoreBatchItemThread>? Type1079 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceThreadSearchStreamRequest? Type1080 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSearchStreamRequestPublic? Type1081 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.TraceSearchStreamRequestPublicExcludeItem>? Type1082 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TraceSearchStreamRequestPublicExcludeItem? Type1083 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.View? Type1084 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewArea? Type1085 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersion? Type1086 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewInput? Type1087 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewInputKind? Type1088 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionAuthor? Type1089 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionType? Type1090 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Opik.ViewInput>? Type1091 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewCreate? Type1092 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewCreateArea? Type1093 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewCreateAuthor? Type1094 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewCreateType? Type1095 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionCreate? Type1096 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionCreateAuthor? Type1097 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionCreateType? Type1098 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionPage? Type1099 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.ViewVersionSummary>? Type1100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionSummary? Type1101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewVersionSummaryAuthor? Type1102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewCurrentVersion? Type1103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ViewUpdate? Type1104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WelcomeWizardTracking? Type1105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WelcomeWizardSubmission? Type1106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.Permission? Type1107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceUserPermissions? Type1108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Permission>? Type1109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricsSummaryRequest? Type1110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DataPointDouble? Type1111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricResponse? Type1112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.Result>? Type1113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricRequest? Type1114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceConfiguration? Type1115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfig? Type1116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.BreakdownConfigField? Type1117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequest? Type1118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequestMetricType? Type1119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceSpanMetricRequestInterval? Type1120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceTokenUsageNamesRequest? Type1121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.WorkspaceMetricsSummaryResponse? Type1122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RevokeRequest? Type1123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.TokenRequest? Type1124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromCsvRequest? Type1125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromJsonRequest? Type1126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateDatasetItemsFromJsonRequestFormat? Type1127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.CreateGuardrailModelRequest? Type1128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.RetrainGuardrailModelRequest? Type1129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.LocalRunnerLogEntry>? Type1130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindAgentInsightsIssuesStatus? Type1131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindAgentInsightsIssuesSeverity? Type1132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetWebhookExamplesAlertType? Type1133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AttachmentListEntityType? Type1134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.DownloadAttachmentEntityType? Type1135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.UploadAttachmentEntityType? Type1136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindFeedbackDefinitionsType? Type1137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindGuardrailModelsLatestRunStatus? Type1138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindGuardrailPoliciesExecutionScope? Type1139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.ListRunnersStatus? Type1140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindReportFailuresType? Type1141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetSpansByProjectType? Type1142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.FindFeedbackScoreNames1Type? Type1143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.GetSpanStatsType? Type1144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type1145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>>? Type1146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>? Type1147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.DatasetExportJobPublic>? Type1148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>? Type1149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>? Type1150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>? Type1151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>? Type1152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>? Type1153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>? Type1154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.OllamaModel>? Type1155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.PromptVersionDetail>? Type1156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>? Type1157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>? Type1158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>? Type1159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>? Type1160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>? Type1161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>? Type1162 { get; set; }

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
        public global::System.Collections.Generic.List<global::Opik.GuardrailModel>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailTrainingRun>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailPolicyRule>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailPolicyRuleWrite>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailPolicyPublic>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailPolicyRulePublic>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Guardrail>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailWrite>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ValidationResult>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ValidationDescriptor>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProviderApiKeyPublic>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CredentialPublic>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Credential>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CredentialWrite>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Param>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Agent>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LocalRunnerJob>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LocalRunner>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.BridgeCommandItem>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMetric>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMessage>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMetricWrite>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMessageWrite>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.OptimizationPublic>? ListType146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMetricPublic>? ListType147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.StudioMessagePublic>? ListType148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptPublic>? ListType149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProjectPublic>? ListType150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ScoreName>? ListType151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.KpiMetric>? ListType152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ResultsNumberPublic>? ListType153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DataPointNumberPublic>? ListType154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ProjectStatsSummaryItem>? ListType155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreAverageDetailed>? ListType156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVersionPublic>? ListType157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.RecentActivityItemPublic>? ListType158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ReportFailure>? ListType159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.OllieReport>? ListType160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.RetentionRulePublic>? ListType161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanWrite>? ListType162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScorePublic>? ListType163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanPublic>? ListType164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreBatchItem>? ListType165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.SpanSearchStreamRequestPublicExcludeItem>? ListType166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DayCount>? ListType167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TopicStats>? ListType168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Trace>? ListType169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceWrite>? ListType170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.CheckPublic>? ListType171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.GuardrailsValidationPublic>? ListType172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnnotationQueueReferencePublic>? ListType173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceThread>? ListType174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TracePublic>? ListType175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.FeedbackScoreBatchItemThread>? ListType176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.TraceSearchStreamRequestPublicExcludeItem>? ListType177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.ViewVersionSummary>? ListType178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Permission>? ListType179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.Result>? ListType180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.LocalRunnerLogEntry>? ListType181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ChatCompletionResponse, global::Opik.ErrorMessage>>? ListType182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.DatasetExportJobPublic>? ListType183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentItem, global::Opik.ErrorMessage>>? ListType184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.DatasetItem, global::Opik.ErrorMessage>>? ListType185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.ExperimentPublic, global::Opik.ErrorMessagePublic>>? ListType186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.OllamaModel>? ListType187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.PromptVersionDetail>? ListType188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.SpanPublic, global::Opik.ErrorMessagePublic>>? ListType189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TraceThread, global::Opik.ErrorMessage>>? ListType190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Opik.AnyOf<global::Opik.TracePublic, global::Opik.ErrorMessagePublic>>? ListType191 { get; set; }
    }
}