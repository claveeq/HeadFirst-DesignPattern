using System;

namespace ObservablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Observer pattern defines a one-to-many depedency between objects so that when one object change state, 
                all its dependents are notified and updated automotically. 
            */
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisaply = new CurrentConditionsDisplay(weatherData);

            weatherData.NotifyObservers();
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.NotifyObservers();
        }
    }
}
