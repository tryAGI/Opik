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
- `src/libs/Opik/generate.sh` — Downloads spec, fixes operator enums + underscore schema names + auth, runs autosdk
- `src/libs/Opik/Generated/` — **Never edit** — auto-generated code (~2400 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

The `generate.sh` applies fixes via `sed`, Python, `yq` (pre-generation), and `sed` (post-generation):

**Pre-generation:**
1. **Operator enum fix:** Symbolic values (`=`, `!=`, `>`, `>=`, `<`, `<=`) replaced with C#-safe identifiers (`eq`, `neq`, `gt`, `gte`, `lt`, `lte`) via `sed`
2. **Underscore schema fix:** Python script renames 239 schemas with underscores (e.g., `Foo_Public` to `FooPublic`) to prevent AutoSDK `JsonDerivedType` reference mismatches
3. **Auth injection:** Original spec has no `securitySchemes` — `yq` adds `ApiKeyAuth` (http/bearer) and top-level `security` array

**Post-generation:**
4. **Pragma suppression:** `sed` injects `#pragma warning disable CS0108` (member hiding) and `CS8618` (non-nullable uninitialized) in FeedbackDefinition and AutomationRuleEvaluator types caused by allOf inheritance

Uses `--exclude-deprecated-operations` flag.

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
