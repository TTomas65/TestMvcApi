using Microsoft.AspNetCore.Mvc;

namespace TestMvcApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController3 : ControllerBase
    {
        [HttpGet("cityWeather1Html")]
        public IActionResult GetCityWeather1Html()
        {
            // Példa városok időjárás adatai
            var citiesWeather = new[]
            {
                new { City = "Budapest", Temperature = 25, Description = "Sunny" },
                new { City = "New York", Temperature = 22, Description = "Partly Cloudy" },
                new { City = "Tokyo", Temperature = 28, Description = "Clear Sky" }
            };

            // HTML táblázat létrehozása
            var htmlTable = "<table><tr><th>City</th><th>Temperature (C)</th><th>Description</th></tr>";
            foreach (var city in citiesWeather)
            {
                htmlTable += $"<tr><td>{city.City}</td><td>{city.Temperature}</td><td>{city.Description}</td></tr>";
            }
            htmlTable += "</table>";

            // Teljes HTML oldal létrehozása
            var htmlPage = $@"
                <html>
                <head><title>City Weather</title></head>
                <body>
                    <h1>City Weather</h1>
                    {htmlTable}
                </body>
                </html>
            ";

            return Content(htmlPage, "text/html");
        }
    }
}
