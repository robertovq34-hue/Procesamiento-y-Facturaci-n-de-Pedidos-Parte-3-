
---

## 📌 🧠 **Diagrama del proyecto (UML simple)**

```text
                    +----------------------+
                    |     IObserver        |
                    |----------------------|
                    | + Actualizar()       |
                    +----------+-----------+
                               ^
                               |
     +-------------------------+------------------------------+
     |                         |                              |
+------------+        +----------------+           +------------------+
| Cliente    |        | Inventario     |           | LogEventos       |
| Observer   |        | Observer       |           | Observer         |
+------------+        +----------------+           +------------------+

                        (observadores)

                                ▲
                                |
                     +--------------------+
                     |    Notificador     |
                     |--------------------|
                     | + Registrar()      |
                     | + Notificar()      |
                     +---------+----------+

                   (subject que notifica)

                                ▲
                                |
                 +------------------------------+
                 |           Managers           |
                 |------------------------------|
                 | PedidoManager                |
                 | FacturaManager               |
                 +------------------------------+

                                ▲
                                |
                     +-------------------+
                     |    Program.cs     |
                     |-------------------|
                     | Hilo 1: Pedidos   |
                     | Hilo 2: Facturas  |
                     | Hilo 3: Notifica  |
                     +-------------------+
