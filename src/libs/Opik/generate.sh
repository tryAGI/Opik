#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/comet-ml/opik/main/sdks/code_generation/fern/openapi/openapi.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/comet-ml/opik/main/sdks/code_generation/fern/openapi/openapi.yaml

# Fix 1: Replace operator enum values that collide after sanitization
# = != > >= < <= all sanitize to x_ or x__ causing CS0102 duplicate members
sed \
  -e "s/^          - =$/          - eq/" \
  -e "s/^          - '!='$/          - neq/" \
  -e "s/^          - '>'$/          - gt/" \
  -e "s/^          - '>='$/          - gte/" \
  -e "s/^          - <$/          - lt/" \
  -e "s/^          - <=$/          - lte/" \
  openapi.yaml > openapi.yaml.tmp && mv openapi.yaml.tmp openapi.yaml

# Auth: --security-scheme injects bearer auth (spec has no securitySchemes declaration).
autosdk generate openapi.yaml \
  --namespace Opik \
  --clientClassName OpikClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# Fix 3: Suppress CS0108 (member hiding) and CS8618 (non-nullable uninitialized) in derived types.
# The OpenAPI spec uses allOf inheritance where derived types redeclare parent properties
# (e.g., *FeedbackDefinition* extends Feedback, AutomationRuleEvaluator* extends AutomationRuleEvaluator).
# AutoSDK generates both parent and child with the same properties, causing:
#   CS0108: derived property hides inherited member (needs 'new' keyword)
#   CS8618: 'required' parent property not set in derived constructor
for f in Generated/Opik.Models.*FeedbackDefinition*.g.cs Generated/Opik.Models.AutomationRuleEvaluator?*.g.cs; do
  [ -f "$f" ] && printf '%s\n' '#pragma warning disable CS0108 // member hides inherited member' '#pragma warning disable CS8618 // non-nullable field uninitialized' "$(cat "$f")" > "$f"
done
