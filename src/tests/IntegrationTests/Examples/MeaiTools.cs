/* order: 10, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Opik.IntegrationTests;

public partial class Tests
{
    //// Opik provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// LLM observability, tracing, and prompt management.

    [TestMethod]
    public async Task Meai_AsListProjectsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists projects:
        var tool = client.AsListProjectsTool(size: 5);

        tool.Name.Should().Be("ListProjects");
        tool.Description.Should().Contain("projects");

        //// The tool accepts an optional `name` parameter for filtering.
        var result = await tool.InvokeAsync(
            new AIFunctionArguments { ["name"] = null },
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListProjects result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsGetTraceTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that retrieves a trace by ID:
        var tool = client.AsGetTraceTool();

        tool.Name.Should().Be("GetTrace");
        tool.Description.Should().Contain("trace");
    }

    [TestMethod]
    public async Task Meai_AsListPromptsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists prompts:
        var tool = client.AsListPromptsTool(size: 5);

        tool.Name.Should().Be("ListPrompts");
        tool.Description.Should().Contain("prompt");

        //// The tool accepts an optional `name` parameter for filtering.
        var result = await tool.InvokeAsync(
            new AIFunctionArguments { ["name"] = null },
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListPrompts result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsCreateProjectTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that creates a new project:
        var tool = client.AsCreateProjectTool();

        tool.Name.Should().Be("CreateProject");
        tool.Description.Should().Contain("project");
    }

    [TestMethod]
    public async Task Meai_AsCreateTraceTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that logs a trace for an LLM operation:
        var tool = client.AsCreateTraceTool();

        tool.Name.Should().Be("CreateTrace");
        tool.Description.Should().Contain("trace");
    }

    [TestMethod]
    public async Task Meai_AsCreateSpanTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that logs a span within a trace:
        var tool = client.AsCreateSpanTool();

        tool.Name.Should().Be("CreateSpan");
        tool.Description.Should().Contain("span");
    }
}
