#nullable enable

namespace Opik
{
    public partial interface IWelcomeWizardClient
    {
        /// <summary>
        /// Get welcome wizard tracking status<br/>
        /// Get welcome wizard tracking status for the current workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Opik.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Opik.WelcomeWizardTracking> GetWelcomeWizardStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}