public interface IObserver
{
    void Update(string mensaje);
}

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string mensaje);
}
