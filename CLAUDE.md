# CLAUDE.md — Opik SDK

## Overview

Auto-generated C# SDK for [Opik](https://www.comet.com/site/products/opik/) (by Comet) — LLM observability, evaluation, and experimentation platform for traces, spans, datasets, experiments, prompts, feedback, guardrails, and annotation queues.
OpenAPI spec from the official [comet-ml/opik](https://github.com/comet-ml/opik) repo.

## Build & Test

```bash
dotnet build Opik.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new OpikClient(apiKey); // OPIK_API_KEY env var
```

## Key Files

- `src/libs/Opik/openapi.yaml` — OpenAPI spec (downloaded from comet-ml/opik)
- `src/libs/Opik/generate.sh` — Downloads spec, runs autosdk with `--security-scheme`
- `src/libs/Opik/Generated/` — **Never edit** — auto-generated code (~2400 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

**Auth:** `--security-scheme Http:Header:Bearer` injects bearer auth (spec has no `securitySchemes` declaration).

Uses `--exclude-deprecated-operations` flag.

No spec fixes needed — AutoSDK dev.154+ handles symbolic enum naming and allOf inheritance natively.

## Sub-client Pattern

Opik API has tagged operations generating sub-clients:
- `client.Projects.*` — Project management
- `client.Traces.*` — Trace management (CRUD, batch)
- `client.Spans.*` — Span management (CRUD, batch)
- `client.Datasets.*` — Dataset management
- `client.Experiments.*` — Experiment management
- `client.Prompts.*` — Prompt versioning and management
- `client.FeedbackDefinitions.*` — Feedback definition management
- `client.AnnotationQueues.*` — Annotation queue management
- `client.Guardrails.*` — Guardrail configuration
- `client.AutomationRuleEvaluators.*` — Automation rule evaluators
- `client.Optimizations.*` — Optimization management
- `client.ChatCompletions.*` — Chat completion proxying
- `client.LlmProviderKey.*` — LLM provider key management
- `client.LlmModels.*` — LLM model configuration
- `client.Workspaces.*` — Workspace management
- `client.Alerts.*` — Alert management
- `client.Dashboards.*` — Dashboard management
- `client.InsightsViews.*` — Insights view management
- `client.OpenTelemetryIngestion.*` — OpenTelemetry ingestion

## MEAI

No MEAI interface implemented — Opik is an observability/evaluation platform with no matching MEAI interface.
