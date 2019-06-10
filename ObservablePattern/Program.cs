using System;

namespace ObservablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisaply = new CurrentConditionsDisplay(weatherData);

            weatherData.NotifyObservers();
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.NotifyObservers();
        }
    }
}
