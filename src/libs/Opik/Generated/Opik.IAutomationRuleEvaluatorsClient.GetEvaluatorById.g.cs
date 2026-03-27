#nullable enable

namespace Opik
{
    public partial interface IAutomationRuleEvaluatorsClient
    {
        /// <summary>
        /// Get automation rule evaluator by id<br/>
        /// Get automation rule by id
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.AutomationRuleEvaluatorPublic> GetEvaluatorByIdAsync(
            global::System.Guid id,
            global::System.Guid? projectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}