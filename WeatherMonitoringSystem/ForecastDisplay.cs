// ForecastDisplay.cs
/// <summary>
/// Concrete observer class for displaying weather forecast.
/// </summary>
public class ForecastDisplay : IDisplay
{
    private readonly IWeatherData _weatherData;

    /// <summary>
    /// Constructor for ForecastDisplay.
    /// </summary>
    /// <param name="weatherData">The weather data subject.</param>
    public ForecastDisplay(IWeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    /// <summary>
    /// Display weather forecast.
    /// </summary>
    public void Display()
    {
        // Display weather forecast
        Console.WriteLine("Forecast display: Displaying weather forecast...");
    }
}
