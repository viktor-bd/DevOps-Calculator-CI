using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();
builder.Services.AddScoped<ICalculatorService, CalculatorService>();

var app = builder.Build();

app.MapControllers();

app.Run();

// Make the implicit Program class public for integration testing
public partial class Program { }
