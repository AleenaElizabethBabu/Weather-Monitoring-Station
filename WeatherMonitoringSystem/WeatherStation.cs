// WeatherStation.cs
using System;

/// <summary>
/// Factory class for creating display objects.
/// </summary>
public class WeatherStation
{
    /// <summary>
    /// Creates a display based on the given type.
    /// </summary>
    /// <param name="displayType">The type of display to create.</param>
    /// <returns>The created display object.</returns>
    public IDisplay CreateDisplay(string displayType)
    {
        IWeatherData weatherData = WeatherData.Instance;

        switch (displayType)
        {
            case "current":
                return new CurrentConditionsDisplay(weatherData);
            case "statistics":
                return new StatisticsDisplay(weatherData);
            case "forecast":
                return new ForecastDisplay(weatherData);
            default:
                throw new ArgumentException("Invalid display type");
        }
    }
}
