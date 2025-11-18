using System;

public class ClienteObserver : IObserver
{
    public void Update(string mensaje)
    {
        Console.WriteLine($"[Cliente] Notificación: {mensaje}");
    }
}

public class InventarioObserver : IObserver
{
    public void Update(string mensaje)
    {
        Console.WriteLine($"[Inventario] Actualizando por: {mensaje}");
    }
}

public class LogObserver : IObserver
{
    public void Update(string mensaje)
    {
        Console.WriteLine($"[Log] {mensaje}");
    }
}
