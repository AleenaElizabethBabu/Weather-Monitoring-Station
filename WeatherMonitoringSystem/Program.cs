// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of WeatherData to ensure it's initialized
        var dummyInstance = WeatherData.Instance;

        WeatherStation station = new WeatherStation();

        // Create displays
        IDisplay currentDisplay = station.CreateDisplay("current");
        IDisplay statisticsDisplay = station.CreateDisplay("statistics");
        IDisplay forecastDisplay = station.CreateDisplay("forecast");

        // Simulate weather data changes
        WeatherData.Instance.SetMeasurements(20.0f, 10.0f, 30.0f);
        WeatherData.Instance.SetMeasurements(25.0f, 15.0f, 35.0f);
        WeatherData.Instance.SetMeasurements(18.0f, 12.0f, 25.0f);

        // Additional data to display
        WeatherData.Instance.SetMeasurements(22.5f, 11.0f, 28.0f);
        WeatherData.Instance.SetMeasurements(24.0f, 16.0f, 32.0f);
        WeatherData.Instance.SetMeasurements(19.5f, 14.0f, 20.0f);
    }
}
