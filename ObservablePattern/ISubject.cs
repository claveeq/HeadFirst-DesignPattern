using System;
namespace ObservablePattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
    }
}
