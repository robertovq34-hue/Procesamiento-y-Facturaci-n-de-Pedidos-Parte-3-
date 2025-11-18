using System.Collections.Generic;

public class Notificador : ISubject
{
    private readonly List<IObserver> observers = new List<IObserver>();
    private readonly object locker = new object();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string mensaje)
    {
        lock (locker)
        {
            foreach (var obs in observers)
                obs.Update(mensaje);
        }
    }
}
