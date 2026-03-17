using Microsoft.AspNetCore.Mvc;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calc;

    public CalculatorController(ICalculatorService calc) => _calc = calc;

    [HttpGet("add")]
    public ActionResult<double> Add([FromQuery] double a, [FromQuery] double b)
        => Ok(_calc.Add(a, b));

    [HttpGet("subtract")]
    public ActionResult<double> Subtract([FromQuery] double a, [FromQuery] double b)
        => Ok(_calc.Subtract(a, b));

    [HttpGet("divide")]
    public ActionResult<double> Divide([FromQuery] double a, [FromQuery] double b)
    {
        try
        {
            return Ok(_calc.Divide(a, b));
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
