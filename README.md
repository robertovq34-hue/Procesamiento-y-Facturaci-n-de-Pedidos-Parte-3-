```mermaid
classDiagram
    class IObserver {
        <<interface>>
        +Actualizar(evento : string)
    }

    class ClienteObserver {
        +Actualizar(evento : string)
    }
    class InventarioObserver {
        +Actualizar(evento : string)
    }
    class LogObserver {
        +Actualizar(evento : string)
    }

    class Notificador {
        -List~IObserver~ observadores
        +Registrar(obs : IObserver)
        +Notificar(evento : string)
    }

    class PedidoManager {
        +ProcesarPedido()
    }

    class FacturaManager {
        +GenerarFactura()
    }

    class Program {
        +Main()
        +ThreadPedidos()
        +ThreadFacturas()
        +ThreadNotificaciones()
    }

    IObserver <|.. ClienteObserver
    IObserver <|.. InventarioObserver
    IObserver <|.. LogObserver

    Notificador --> IObserver : notifica
    PedidoManager --> Notificador : usa
    FacturaManager --> Notificador : usa

    Program --> PedidoManager : ejecuta en hilo
    Program --> FacturaManager : ejecuta en hilo
