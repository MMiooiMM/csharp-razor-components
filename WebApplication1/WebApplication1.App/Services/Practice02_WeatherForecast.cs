using System;

namespace WebApplication1.App.Services
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public decimal TemperatureC { get; set; }

        public decimal TemperatureF { get { return TemperatureC * (9m / 5m) + 32m; } }

        public string Summary { get; set; }
    }
}
