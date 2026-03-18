# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Leonardo.AI](https://leonardo.ai/) image generation platform, auto-generated from the Leonardo OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package named `LeonardoAI` under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Leonardo.slnx

# Build for release (also produces NuGet package)
dotnet build Leonardo.slnx -c Release

# Run integration tests (requires LEONARDO_API_KEY env var)
dotnet test src/tests/Leonardo.IntegrationTests/Leonardo.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Leonardo && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** — do not manually edit files in `src/libs/Leonardo/Generated/`.

1. `src/libs/Leonardo/openapi.yaml` — the Leonardo OpenAPI spec (fetched from `https://api-docs-nine-delta.vercel.app/cloud/openapi.json`)
2. `src/helpers/FixOpenApiSpec/` — converts OpenAPI 3.1 → 3.0 format for compatibility
3. `src/libs/Leonardo/generate.sh` — orchestrates: download spec → fix spec → run AutoSDK CLI → output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Leonardo/` | Main SDK library (`LeonardoClient`) |
| `src/tests/Leonardo.IntegrationTests/` | Integration tests against real Leonardo API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |

### Build Configuration

- **Target:** `net10.0` (single target)
- **NuGet Package ID:** `LeonardoAI` (differs from project name `Leonardo`)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
