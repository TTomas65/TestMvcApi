using Microsoft.AspNetCore.Mvc;
using TestMvcApi.Models;

namespace TestMvcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecast2Controller : ControllerBase
{
    [HttpGet]
    public IEnumerable<WeatherForecast2> Get()
    {
        return new[]
        {
            new WeatherForecast2
            {
                Date = DateTime.Today,
                Summary = "Napos",
                TemperatureF = 89,
                City = "Budapest"
            }
        };
    }
}