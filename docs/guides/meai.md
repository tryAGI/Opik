# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Opik SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Opik's LLM observability, trace management, and prompt versioning capabilities.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListProjectsTool()` | `ListProjects` | Lists projects with optional name filtering. |
| `AsGetTraceTool()` | `GetTrace` | Retrieves a trace by ID with name, times, and tags. |
| `AsListPromptsTool()` | `ListPrompts` | Lists prompts with optional name filtering. |
| `AsCreateProjectTool()` | `CreateProject` | Creates a new project for organizing traces. |
| `AsCreateTraceTool()` | `CreateTrace` | Logs a new trace for an LLM operation. |
| `AsCreateSpanTool()` | `CreateSpan` | Logs a span within a trace for a sub-operation. |

## Usage

```csharp
using Opik;
using Microsoft.Extensions.AI;

var opik = new OpikClient(apiKey);

// Create tools
var tools = new[]
{
    opik.AsListProjectsTool(),
    opik.AsGetTraceTool(),
    opik.AsListPromptsTool(),
    opik.AsCreateProjectTool(),
    opik.AsCreateTraceTool(),
    opik.AsCreateSpanTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "List all my Opik projects and their descriptions",
    new ChatOptions { Tools = tools });
```

## Tool Details

### ListProjects

Lists projects with optional name filtering (partial match, case insensitive).

```csharp
var tool = opik.AsListProjectsTool(size: 20);
```

### GetTrace

Retrieves a trace by its ID, returning name, start/end times, and tags.

### ListPrompts

Lists prompts with optional name filtering. Returns prompt metadata
including template structure type, tags, and descriptions.

```csharp
var tool = opik.AsListPromptsTool(size: 20);
```

### CreateProject

Creates a new project for organizing traces and experiments.
Accepts a required name and optional description.

### CreateTrace

Logs a new trace for an LLM operation. Requires a name.
Optionally specify a project name and comma-separated tags.
Returns the generated trace ID.

### CreateSpan

Logs a span within an existing trace for a sub-operation (e.g., an LLM call).
Requires a trace ID and name. Optionally specify project name, model, and provider.
Returns the generated span ID.
