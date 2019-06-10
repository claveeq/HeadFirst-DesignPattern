using System;
using System.Collections.Generic;

namespace ObservablePatternInCSharp
{
    public class WeatherData : IObservable<Data>
    {
        private readonly List<IObserver<Data>> observers;

        private Data data;

        public WeatherData()
        {
            observers = new List<IObserver<Data>>();
        }

        public IDisposable Subscribe(IObserver<Data> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<Data>> _observers;
            private readonly IObserver<Data> _observer;

            public Unsubscriber(List<IObserver<Data>> observers, IObserver<Data> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void NotifyObservers()
        {
            observers.ForEach((obj) => obj.OnNext(data));
        }

        public void MeasurementChange()
        {
            NotifyObservers();
        }

        public void SetMeasurements(Data data)
        {
            this.data = data;
            MeasurementChange();
        }


    }
}
