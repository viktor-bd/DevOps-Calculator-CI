using System;
using Xunit;
using Api.Services;

namespace Api.UnitTests;

public class CalculatorServiceTests
{
    private readonly CalculatorService _svc = new CalculatorService();

    [Fact]
    public void Add_ReturnsSum()
    {
        var result = _svc.Add(3, 4);
        Assert.Equal(7, result);
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        Assert.Throws<ArgumentException>(() => _svc.Divide(1, 0));
    }

    [Fact]
    public void Multiply_ReturnsProduct()
    {
        var result = _svc.Multiply(2, 5);
        Assert.Equal(10, result);
    }
}
