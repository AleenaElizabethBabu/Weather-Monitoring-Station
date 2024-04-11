// WeatherData.cs
using System;
using System.Collections.Generic;

/// <summary>
/// Singleton class for weather data subject.
/// </summary>
public class WeatherData : IWeatherData
{
    private static WeatherData? _instance; // Make the field nullable
    private List<IDisplay> _observers;
    private float _temperature;
    private float _humidity;
    private float _windSpeed;

    /// <summary>
    /// Constructor for WeatherData.
    /// </summary>
    private WeatherData()
    {
        _observers = new List<IDisplay>();
    }

    /// <summary>
    /// Gets the singleton instance of WeatherData.
    /// </summary>
    public static WeatherData Instance
    {
        get
        {
            if (_instance == null)
                _instance = new WeatherData();
            return _instance;
        }
    }

    /// <summary>
    /// Register an observer to receive updates.
    /// </summary>
    /// <param name="display">The display to register.</param>
    public void RegisterObserver(IDisplay display)
    {
        _observers.Add(display);
    }

    /// <summary>
    /// Remove an observer from receiving updates.
    /// </summary>
    /// <param name="display">The display to remove.</param>
    public void RemoveObserver(IDisplay display)
    {
        _observers.Remove(display);
    }

    /// <summary>
    /// Notify all observers when weather data changes.
    /// </summary>
    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Display();
        }
    }

    /// <summary>
    /// Simulate updating weather data.
    /// </summary>
    /// <param name="temperature">The new temperature.</param>
    /// <param name="humidity">The new humidity.</param>
    /// <param name="windSpeed">The new wind speed.</param>
    public void SetMeasurements(float temperature, float humidity, float windSpeed)
    {
        _temperature = temperature;
        _humidity = humidity;
        _windSpeed = windSpeed;
        MeasurementsChanged();
    }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    /// <summary>
    /// Gets the current temperature.
    /// </summary>
    public float Temperature => _temperature;

    /// <summary>
    /// Gets the current humidity.
    /// </summary>
    public float Humidity => _humidity;

    /// <summary>
    /// Gets the current wind speed.
    /// </summary>
    public float WindSpeed => _windSpeed;
}
