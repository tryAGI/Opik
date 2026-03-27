dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://raw.githubusercontent.com/comet-ml/opik/main/sdks/code_generation/fern/openapi/openapi.yaml

# Inject securitySchemes (http/bearer) and top-level security array
yq -i '.components.securitySchemes.ApiKeyAuth.type = "http"
  | .components.securitySchemes.ApiKeyAuth.scheme = "bearer"
  | .security = [{"ApiKeyAuth": []}]' openapi.yaml

# Rename operator enum values from symbols to valid C# identifiers
# Handles both quoted and unquoted YAML variants
python3 -c "
import re, sys

with open('openapi.yaml', 'r') as f:
    content = f.read()

# Replace operator enum values (both quoted and unquoted forms)
# Order matters: longer patterns first to avoid partial matches
replacements = [
    # Quoted forms (single quotes)
    (r\"- '!='\", '- not_equal'),
    (r\"- '>='\", '- greater_or_equal'),
    (r\"- '<='\", '- less_or_equal'),
    (r\"- '>'\", '- greater_than'),
    (r\"- '<'\", '- less_than'),
    (r\"- '='\", '- equal'),
]
for old, new in replacements:
    content = content.replace(old, new)

# Unquoted forms: must be careful not to replace YAML = in other contexts
# These appear as enum list items with specific indentation
# Match lines like '          - =' at end of line (no trailing content)
content = re.sub(r'^(\s+)- >=$', r'\1- greater_or_equal', content, flags=re.MULTILINE)
content = re.sub(r'^(\s+)- <=$', r'\1- less_or_equal', content, flags=re.MULTILINE)
content = re.sub(r'^(\s+)- !=$', r'\1- not_equal', content, flags=re.MULTILINE)
content = re.sub(r'^(\s+)- =$', r'\1- equal', content, flags=re.MULTILINE)
content = re.sub(r'^(\s+)- >$', r'\1- greater_than', content, flags=re.MULTILINE)
content = re.sub(r'^(\s+)- <$', r'\1- less_than', content, flags=re.MULTILINE)

# Remove underscores before common suffixes in schema names and references
# These appear in schema definition keys and \$ref paths
content = content.replace('_Write', 'Write')
content = content.replace('_Public', 'Public')
content = content.replace('_Create', 'Create')
content = content.replace('_Update', 'Update')

with open('openapi.yaml', 'w') as f:
    f.write(content)

print('Spec transformations applied successfully')
"

autosdk generate openapi.yaml \
  --namespace Opik \
  --clientClassName OpikClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
