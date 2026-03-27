using System.Text.Json;
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

                return JsonSerializer.Serialize(response.Content?.Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                    description = p.Description,
                    created_at = p.CreatedAt,
                }));
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

                return JsonSerializer.Serialize(new
                {
                    id = trace.Id,
                    name = trace.Name,
                    start_time = trace.StartTime,
                    end_time = trace.EndTime,
                    tags = trace.Tags,
                });
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

                return JsonSerializer.Serialize(response.Content?.Select(p => new
                {
                    id = p.Id,
                    name = p.Name,
                    description = p.Description,
                    template_structure = p.TemplateStructure?.ToString(),
                    tags = p.Tags,
                    created_at = p.CreatedAt,
                }));
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
}
