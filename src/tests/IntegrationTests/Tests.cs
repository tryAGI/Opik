namespace Opik.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OpikClient GetAuthenticatedClient()
    {
        var apiKey =
            System.Environment.GetEnvironmentVariable("OPIK_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("OPIK_API_KEY environment variable is not found.");

        var client = new OpikClient(apiKey);
        
        return client;
    }
}
