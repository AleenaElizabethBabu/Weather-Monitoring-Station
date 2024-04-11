// IWeatherData.cs
/// <summary>
/// Interface for weather data subject.
/// </summary>
public interface IWeatherData
{
    /// <summary>
    /// Register an observer to receive updates.
    /// </summary>
    /// <param name="display">The display to register.</param>
    void RegisterObserver(IDisplay display);

    /// <summary>
    /// Remove an observer from receiving updates.
    /// </summary>
    /// <param name="display">The display to remove.</param>
    void RemoveObserver(IDisplay display);

    /// <summary>
    /// Notify all observers when weather data changes.
    /// </summary>
    void NotifyObservers();

    /// <summary>
    /// Set the current weather measurements.
    /// </summary>
    /// <param name="temperature">The temperature.</param>
    /// <param name="humidity">The humidity.</param>
    /// <param name="windSpeed">The wind speed.</param>
    void SetMeasurements(float temperature, float humidity, float windSpeed);

    /// <summary>
    /// Gets the current temperature.
    /// </summary>
    float Temperature { get; }

    /// <summary>
    /// Gets the current humidity.
    /// </summary>
    float Humidity { get; }

    /// <summary>
    /// Gets the current wind speed.
    /// </summary>
    float WindSpeed { get; }
}
