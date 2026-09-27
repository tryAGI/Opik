
#nullable enable

namespace Opik
{
    public partial interface IAgentInsightsEnrollmentClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}