// CurrentConditionsDisplay.cs
/// <summary>
/// Concrete observer class for displaying current weather conditions.
/// </summary>
public class CurrentConditionsDisplay : IDisplay
{
    private readonly IWeatherData _weatherData;

    /// <summary>
    /// Constructor for CurrentConditionsDisplay.
    /// </summary>
    /// <param name="weatherData">The weather data subject.</param>
    public CurrentConditionsDisplay(IWeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    /// <summary>
    /// Display current weather conditions.
    /// </summary>
    public void Display()
    {
        // Display current weather conditions
        Console.WriteLine($"Current conditions: Temperature {_weatherData.Temperature}°C, Humidity {_weatherData.Humidity}%, Wind {_weatherData.WindSpeed} km/h");
    }
}
