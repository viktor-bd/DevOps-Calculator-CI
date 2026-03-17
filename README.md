# DevOps Calculator CI (minimal demo)

![CI](https://github.com/viktor-bd/DevOps-Calculator-CI/actions/workflows/ci.yml/badge.svg)

This small exam project demonstrates a minimal Continuous Integration pipeline with automated tests to improve software quality and detect faults early.

Key points
- Language: C# (.NET 6 minimal API)
- Tests: xUnit unit tests and integration tests
- CI: GitHub Actions runs restore, build and tests on push/PR to `main`

Quick commands (run from repository root `DevOps-Calculator-CI/`)
```
dotnet restore
dotnet build --configuration Release
dotnet test tests/Api.UnitTests/Api.UnitTests.csproj --no-build --configuration Release
dotnet test tests/Api.IntegrationTests/Api.IntegrationTests.csproj --no-build --configuration Release
```

