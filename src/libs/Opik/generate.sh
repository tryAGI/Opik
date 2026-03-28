#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/comet-ml/opik/main/sdks/code_generation/fern/openapi/openapi.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://raw.githubusercontent.com/comet-ml/opik/main/sdks/code_generation/fern/openapi/openapi.yaml

# Fix 1: Replace operator enum values that collide after sanitization
# = != > >= < <= all sanitize to x_ or x__ causing CS0102 duplicate members
sed -i '' \
  -e "s/^          - =$/          - eq/" \
  -e "s/^          - '!='$/          - neq/" \
  -e "s/^          - '>'$/          - gt/" \
  -e "s/^          - '>='$/          - gte/" \
  -e "s/^          - <$/          - lt/" \
  -e "s/^          - <=$/          - lte/" \
  openapi.yaml

# Fix 2: Remove underscores from schema names that cause AutoSDK JsonDerivedType reference mismatches.
# AutoSDK strips underscores in type names but not in JsonDerivedType typeof() references.
# We rename schemas like Foo_Public -> FooPublic, Foo_Write -> FooWrite, etc.
python3 -c "
import re
import sys

with open('openapi.yaml', 'r') as f:
    content = f.read()

# Find all unique schema names with underscores from definitions
# Match lines like '    SchemaName_Suffix:' (exactly 4 spaces indent = top-level schema)
schema_pattern = re.compile(r'^    ([A-Za-z][A-Za-z0-9]*(?:_[A-Za-z][A-Za-z0-9]*)+):', re.MULTILINE)
schemas_with_underscores = set(schema_pattern.findall(content))

print(f'Found {len(schemas_with_underscores)} schemas with underscores', file=sys.stderr)

# Sort by length descending to avoid partial replacements
for schema in sorted(schemas_with_underscores, key=len, reverse=True):
    new_name = schema.replace('_', '')
    # Replace in \$ref paths
    content = content.replace(f'schemas/{schema}', f'schemas/{new_name}')
    # Replace in schema definitions (4-space indent)
    content = content.replace(f'    {schema}:', f'    {new_name}:')

with open('openapi.yaml', 'w') as f:
    f.write(content)
"

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
  [ -f "$f" ] && sed -i '' '1s/^/#pragma warning disable CS0108 \/\/ member hides inherited member\n#pragma warning disable CS8618 \/\/ non-nullable field uninitialized\n/' "$f"
done
