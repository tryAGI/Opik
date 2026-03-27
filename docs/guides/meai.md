# Microsoft.Extensions.AI Integration

Opik provides `AIFunction` tools compatible with
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI),
allowing any `IChatClient` to interact with Opik's observability and prompt management features.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListProjectsTool()` | `ListProjects` | Lists projects with optional name filtering. |
| `AsGetTraceTool()` | `GetTrace` | Retrieves a trace by ID with name, times, and tags. |
| `AsListPromptsTool()` | `ListPrompts` | Lists prompts with optional name filtering. |
| `AsCreateProjectTool()` | `CreateProject` | Creates a new project for organizing traces. |

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
