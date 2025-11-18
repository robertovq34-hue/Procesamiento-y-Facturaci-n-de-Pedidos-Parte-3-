using System;
using System.Threading;

public class PedidoManager
{
    private readonly Notificador notificador;
    private int contador = 1;

    public PedidoManager(Notificador notificador)
    {
        this.notificador = notificador;
    }

    public void ProcesarPedidos()
    {
        while (true)
        {
            Thread.Sleep(2000);
            string pedido = $"Pedido #{contador++} procesado";
            Console.WriteLine($"(Hilo Pedidos) {pedido}");
            notificador.Notify(pedido);
        }
    }
}

public class FacturaManager
{
    private readonly Notificador notificador;
    private int contador = 1;

    public FacturaManager(Notificador notificador)
    {
        this.notificador = notificador;
    }

    public void GenerarFacturas()
    {
        while (true)
        {
            Thread.Sleep(3000);
            string factura = $"Factura #{contador++} generada";
            Console.WriteLine($"(Hilo Facturas) {factura}");
            notificador.Notify(factura);
        }
    }
}
