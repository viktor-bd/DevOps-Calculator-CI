using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Api.IntegrationTests;

public class CalculatorEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public CalculatorEndpointTests(WebApplicationFactory<Program> factory) => _factory = factory;

    [Fact]
    public async Task AddEndpoint_ReturnsSum()
    {
        var client = _factory.CreateClient();
        var res = await client.GetAsync("/api/calculator/add?a=5&b=6");
        res.EnsureSuccessStatusCode();
        var txt = await res.Content.ReadAsStringAsync();
        var value = JsonSerializer.Deserialize<double>(txt);
        Assert.Equal(11, value);
    }

    [Fact]
    public async Task Divide_ByZero_ReturnsBadRequest()
    {
        var client = _factory.CreateClient();
        var res = await client.GetAsync("/api/calculator/divide?a=1&b=0");
        Assert.Equal(HttpStatusCode.BadRequest, res.StatusCode);
    }
}
