#nullable enable

namespace Opik
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Update Automation Rule Evaluator by id<br/>
        /// Update Automation Rule Evaluator by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateAutomationRuleEvaluatorAsync(
            global::System.Guid id,

            global::Opik.AutomationRuleEvaluatorUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Automation Rule Evaluator by id<br/>
        /// Update Automation Rule Evaluator by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="samplingRate"></param>
        /// <param name="enabled"></param>
        /// <param name="projectId">
        /// Primary project ID (legacy field, maintained for backwards compatibility)
        /// </param>
        /// <param name="projectIds">
        /// Multiple project IDs (new field for multi-project support)
        /// </param>
        /// <param name="action"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateAutomationRuleEvaluatorAsync(
            global::System.Guid id,
            string name,
            float? samplingRate = default,
            bool? enabled = default,
            global::System.Guid? projectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? projectIds = default,
            global::Opik.AutomationRuleEvaluatorUpdateAction action = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}