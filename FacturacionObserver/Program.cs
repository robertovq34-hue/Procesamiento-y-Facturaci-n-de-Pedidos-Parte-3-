xusing System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Notificador notificador = new Notificador();

        notificador.Attach(new ClienteObserver());
        notificador.Attach(new InventarioObserver());
        notificador.Attach(new LogObserver());

        PedidoManager pedidoManager = new PedidoManager(notificador);
        FacturaManager facturaManager = new FacturaManager(notificador);

        Thread hiloPedidos = new Thread(new ThreadStart(pedidoManager.ProcesarPedidos));
        Thread hiloFacturas = new Thread(new ThreadStart(facturaManager.GenerarFacturas));

        hiloPedidos.Start();
        hiloFacturas.Start();

        Console.WriteLine("Sistema iniciado...");
        Console.ReadLine();
    }
}
