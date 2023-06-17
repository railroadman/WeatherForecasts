using WeatherForecasts.Domain.Models;

namespace WeatherForecasts.Domain.Interfaces
{
    public interface IWeatherForecastRepository
    {
        WeatherForecast[] GetForecasts();

    }
}
