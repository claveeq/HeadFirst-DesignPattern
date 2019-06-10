using System;
using ObservablePatternInCSharp;

namespace ObservablePattern
{
    public class CurrentConditionsDisplay: IObserver<Data>, IDisplayElement
    {
        private Data data;
        private IDisposable unsubscriber;

        public virtual void Subscribe(IObservable<Data> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + data.Temperature + "F degrees and " + data.Humidity + "% humidity");
            Console.WriteLine("Heat Index is " + computeHeatIndex(data.Temperature, data.Humidity));
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Data value)
        {
            data = value;
            Display();
        }

        private float computeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
                (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
