// StatisticsDisplay.cs
/// <summary>
/// Concrete observer class for displaying weather statistics.
/// </summary>
public class StatisticsDisplay : IDisplay
{
    private readonly IWeatherData _weatherData;

    /// <summary>
    /// Constructor for StatisticsDisplay.
    /// </summary>
    /// <param name="weatherData">The weather data subject.</param>
    public StatisticsDisplay(IWeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    /// <summary>
    /// Display weather statistics.
    /// </summary>
    public void Display()
    {
        // Display weather statistics
        Console.WriteLine("Statistics display: Displaying weather statistics...");
    }
}
