# Authentication

The Opik API uses Bearer token authentication.

## Getting an API Key

1. Sign up at [comet.com/opik](https://www.comet.com/opik)
2. Navigate to your account settings
3. Create a new API key

## Client Initialization

```csharp
using Opik;

var client = new OpikClient(
    apiKey: Environment.GetEnvironmentVariable("OPIK_API_KEY")!);
```

## Environment Variables

For integration tests, set the following environment variable:

```bash
export OPIK_API_KEY=your-api-key-here
```
