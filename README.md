# 🧾 Sistema de Procesamiento y Facturación (Observer + Threads)

Este proyecto implementa un sistema básico de **procesamiento de pedidos y facturación**, aplicando:

- El **patrón de diseño Observer**
- **Múltiples hilos (threads)** trabajando en paralelo
- Notificaciones automáticas a los observadores cuando se genera un pedido o una factura

---

## 🎯 Objetivo del proyecto

Simular un sistema donde:
- Se procesan pedidos
- Se generan facturas
- Los observadores (cliente, inventario, log) reciben notificaciones automáticas
- Todo funciona usando varios hilos ejecutándose al mismo tiempo

Esto permite ver cómo funciona la concurrencia y los patrones de diseño en C#.

---

## 🧩 Tecnologías utilizadas

- C#
- .NET 8
- Programación orientada a objetos  
- Patrones de diseño (Observer)
- Programación concurrente (Threads)

---

## 📁 **Estructura del Proyecto**

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


