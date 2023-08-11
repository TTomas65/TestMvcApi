using Microsoft.AspNetCore.Mvc;
using TestMvcApi.Models;
using TestMvcApi.Views;

[ApiController]
[Route("[controller]")]
public class WeatherController4 : ControllerBase
{
    private readonly WeatherView _weatherView;

    public WeatherController4()
    {
        _weatherView = new WeatherView();
    }

    [HttpGet("GetWeather")]
    public ContentResult GetWeather()
    {
        var weatherList = new List<Weather>
        {
            new Weather { City = "Budapest", TemperatureCelsius = 35, WeatherCondition = "Napos" },
            new Weather { City = "New York", TemperatureCelsius = 26, WeatherCondition = "Felhős" },
            new Weather { City = "Tokyo", TemperatureCelsius = 20, WeatherCondition = "Esős" },
            new Weather { City = "London", TemperatureCelsius = 22, WeatherCondition = "Részben felhős" },
            new Weather { City = "Paris", TemperatureCelsius = 28, WeatherCondition = "Napos" },
            new Weather { City = "Sydney", TemperatureCelsius = 26, WeatherCondition = "Tiszta égbolt" },
            new Weather { City = "Berlin", TemperatureCelsius = 24, WeatherCondition = "Részben felhős" },
            new Weather { City = "Moscow", TemperatureCelsius = 19, WeatherCondition = "Esős" },
            new Weather { City = "Los Angeles", TemperatureCelsius = 24, WeatherCondition = "Felhős" },
            new Weather { City = "Beijing", TemperatureCelsius = 26, WeatherCondition = "Napos" }
        };

        var htmlContent = _weatherView.GenerateHtml(weatherList);

        return Content(htmlContent, "text/html");
    }
}

