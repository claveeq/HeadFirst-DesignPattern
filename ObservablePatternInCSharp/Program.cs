using System;
using ObservablePattern;

namespace ObservablePatternInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
            currentDisplay.Subscribe(weatherData);

            weatherData.SetMeasurements(new Data());

            weatherData.SetMeasurements(new Data { Temperature = 80, Humidity = 65, Pressure = 40.4f });

            weatherData.NotifyObservers();
        }
    }
}
