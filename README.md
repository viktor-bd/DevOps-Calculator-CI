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

Why this helps
- Automated builds catch compile-time errors early
- Unit tests validate business logic in isolation
- Integration tests validate the HTTP surface and request pipeline

Suggested next steps
1. Add code coverage reporting (Coverlet + upload to Codecov)
2. Upgrade project to a supported .NET (7/8) and update CI image
3. Protect `main` branch and require CI status checks
4. Add README badges / documentation for contributors (done)

If you want, I can implement any of the suggested next steps — tell me which one to start with.
