#pragma warning disable CS3002 // Return type is not CLS-compliant
using Microsoft.Extensions.AI;

namespace Opik;

/// <summary>
/// Extensions for using OpikClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class OpikToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists projects in Opik.
    /// </summary>
    /// <param name="client">The Opik client.</param>
    /// <param name="size">Maximum number of projects to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListProjectsTool(
        this OpikClient client,
        int size = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? name, CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.FindProjectsAsync(
                    size: size,
                    name: name,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Content?.Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                    description = p.Description,
                    created_at = p.CreatedAt,
                });
            },
            name: "ListProjects",
            description: "Lists projects in Opik. Optionally filter by name (partial match, case insensitive). Returns project IDs, names, descriptions, and creation dates.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves a trace by ID.
    /// </summary>
    /// <param name="client">The Opik client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetTraceTool(this OpikClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string traceId, CancellationToken cancellationToken) =>
            {
                var trace = await client.Traces.GetTraceByIdAsync(
                    id: Guid.Parse(traceId),
                    stripAttachments: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    id = trace.Id,
                    name = trace.Name,
                    start_time = trace.StartTime,
                    end_time = trace.EndTime,
                    tags = trace.Tags,
                };
            },
            name: "GetTrace",
            description: "Retrieves an Opik trace by its ID. Returns the trace's name, start/end times, and tags.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists prompts in Opik.
    /// </summary>
    /// <param name="client">The Opik client.</param>
    /// <param name="size">Maximum number of prompts to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPromptsTool(
        this OpikClient client,
        int size = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? name, CancellationToken cancellationToken) =>
            {
                var response = await client.Prompts.GetPromptsAsync(
                    size: size,
                    name: name,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response.Content?.Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                    description = p.Description,
                    template_structure = p.TemplateStructure?.ToString(),
                    tags = p.Tags,
                    created_at = p.CreatedAt,
                });
            },
            name: "ListPrompts",
            description: "Lists prompts in Opik. Optionally filter by name (partial match, case insensitive). Returns prompt IDs, names, descriptions, template types, tags, and creation dates.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that creates a new project in Opik.
    /// </summary>
    /// <param name="client">The Opik client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateProjectTool(this OpikClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string name, string? description, CancellationToken cancellationToken) =>
            {
                await client.Projects.CreateProjectAsync(
                    name: name,
                    description: description,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Project '{name}' created successfully.";
            },
            name: "CreateProject",
            description: "Creates a new project in Opik for organizing traces and experiments. Requires a name, with optional description.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that logs a trace in Opik.
    /// </summary>
    /// <param name="client">The Opik client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateTraceTool(this OpikClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string name, string? projectName, string? tags, CancellationToken cancellationToken) =>
            {
                var traceId = Guid.NewGuid();
                var tagList = tags?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                    .ToList();

                await client.Traces.CreateTraceAsync(
                    startTime: DateTime.UtcNow,
                    id: traceId,
                    projectName: projectName,
                    name: name,
                    tags: tagList,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    id = traceId,
                    name,
                    project_name = projectName,
                    status = "created",
                };
            },
            name: "CreateTrace",
            description: "Creates a new trace in Opik for logging an LLM operation. Requires a name. Optionally specify a project name and comma-separated tags. Returns the trace ID.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that logs a span within a trace in Opik.
    /// </summary>
    /// <param name="client">The Opik client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsCreateSpanTool(this OpikClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string traceId, string name, string? projectName, string? model, string? provider, CancellationToken cancellationToken) =>
            {
                var spanId = Guid.NewGuid();

                await client.Spans.CreateSpanAsync(
                    startTime: DateTime.UtcNow,
                    id: spanId,
                    traceId: Guid.Parse(traceId),
                    projectName: projectName,
                    name: name,
                    model: model,
                    provider: provider,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    id = spanId,
                    trace_id = traceId,
                    name,
                    status = "created",
                };
            },
            name: "CreateSpan",
            description: "Creates a new span within an Opik trace for logging a sub-operation (e.g., an LLM call). Requires a trace ID and name. Optionally specify project name, model, and provider. Returns the span ID.");
    }
}
