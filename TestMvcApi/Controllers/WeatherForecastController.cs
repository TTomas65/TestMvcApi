using Microsoft.AspNetCore.Mvc;
using TestMvcApi.Models;

namespace TestMvcApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return new[]
        {
            new WeatherForecast
            {
                Date = DateTime.Today,
                Summary = "Felhős",
                TemperatureC = 21
            }
        };
    }
}