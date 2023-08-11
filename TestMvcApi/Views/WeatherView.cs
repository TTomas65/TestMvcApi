using TestMvcApi.Models;

namespace TestMvcApi.Views
{
    public class WeatherView
    {
        public string GenerateHtml(List<Weather> weatherList)
        {
            var html = @"
        <!DOCTYPE html>
        <html>
        <html>
        <head>
            <meta charset=""utf-8""> <!-- Karakterkódolás beállítása -->
            <title>Weather Report</title>
            <style>
                body {
                    text-align: center;
                }
                table {
                    border-collapse: collapse;
                    width: 50%;
                    margin: auto;
                }
                th, td {
                    border: 1px solid black;
                    padding: 8px;
                    text-align: center;
                }
                th {
                    background-color: #f2f2f2;
                }
            </style>
        </head>
        <body>
            <h1>Időjárás jelentés</h1>
            <table>
                <tr>
                    <th>Város</th>
                    <th>Hőmérséklet (°C)</th>
                    <th>Időjárási körülmények</th>
                </tr>";

            foreach (var weather in weatherList)
            {
                html += $@"
                <tr>
                    <td>{weather.City}</td>
                    <td>{weather.TemperatureCelsius}</td>
                    <td>{weather.WeatherCondition}</td>
                </tr>";
            }

            html += @"
            </table>
            <script>
                // JavaScript kód itt
                   var tableRows = [];
                var currentIndex = -1;

                function boldTableRow() {
                    if (tableRows.length > 0) {
                        if (currentIndex >= 0) {
                            tableRows[currentIndex].style.fontWeight = 'normal';
                        }

                        currentIndex = (currentIndex + 1) % tableRows.length;
                        tableRows[currentIndex].style.fontWeight = 'bold';
                    }
                }

                window.onload = function() {
                    tableRows = Array.from(document.querySelectorAll('tr'));
                    setInterval(boldTableRow, 1000); // 1000 ms = 1 sec
                };
            </script>
        </body>
        </html>";

            return html;
        }
    }
}
