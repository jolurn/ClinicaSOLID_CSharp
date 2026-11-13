# 🏥 Sistema de Clínica - SOLID y Clean Architecture (C#)

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SOLID](https://img.shields.io/badge/SOLID-Principles-blue?style=for-the-badge)
![Clean Architecture](https://img.shields.io/badge/Clean-Architecture-green?style=for-the-badge)

Este es un proyecto de consola desarrollado en **C#** que simula el módulo de agendamiento de citas de una clínica. Su propósito principal es demostrar la implementación práctica de los **5 Principios SOLID** y la separación de responsabilidades siguiendo los lineamientos de la **Clean Architecture**.

## 🎯 Objetivo del Proyecto

El objetivo es demostrar cómo aislar la lógica de negocio (Core) de los detalles de infraestructura (Base de datos, consola, servicios de correo) para crear un software mantenible, testeable y escalable.

## 🏗️ Estructura del Proyecto (Clean Architecture)

El proyecto está dividido lógicamente en capas usando `namespaces` y carpetas:

*   📁 **`Core`**: El corazón del negocio. No depende de nada externo (ni SQL Server, ni consola).
    *   `Models`: Entidades puras (`Paciente`, `Cita`).
    *   `Interfaces`: Contratos/Abstracciones (`IPacienteRepository`, `INotificacionService`, `IOutput`).
    *   `Services`: Lógica de negocio (`GestorCitas`).
*   📁 **`Infraestructura`**: Las herramientas externas. Depende del Core.
    *   `Repositorios`: Implementación de acceso a datos (`MemoriaPacienteRepository`).
    *   `Notificaciones`: Implementación de envíos (`EmailNotificacionService`, `SmsNotificacionService`).
    *   `Visualizacion`: Implementación de interfaz (`ConsolaOutput`).
*   📄 **`Program.cs`**: El punto de entrada. Aquí se aplica la **Inyección de Dependencias** manual.

## 🛠️ Principios SOLID Aplicados

El código está comentado detalladamente explicando dónde se aplica cada principio:

*   **S - Single Responsibility (Responsabilidad Única):** Cada clase tiene una sola razón para cambiar. `Paciente` solo guarda datos, `ConsolaOutput` solo imprime, `GestorCitas` solo procesa la lógica.
*   **O - Open/Closed (Abierto/Cerrado):** El sistema está abierto a extensión pero cerrado a modificación. Si se requiere enviar notificaciones por WhatsApp, solo se crea una nueva clase sin tocar el `GestorCitas`.
*   **L - Liskov Substitution (Sustitución de Liskov):** Las clases de notificación (`Email`, `SMS`) pueden sustituirse entre sí sin romper el programa.
*   **I - Interface Segregation (Segregación de Interfaces):** Se usan interfaces pequeñas y específicas en lugar de una interfaz "Dios" gigante.
*   **D - Dependency Inversion (Inversión de Dependencia):** `GestorCitas` no depende de implementaciones concretas, sino de las interfaces (`INotificacionService`).

## 🚀 Cómo ejecutar el proyecto

1. Clona este repositorio.
2. Abre la solución (`.sln`) en **Visual Studio**.
3. Presiona `F5` o el botón verde de **Iniciar**.
4. Verás en la consola cómo el sistema procesa una cita y envía una notificación.

**💡 La Magia del Principio Open/Closed:**
Abre el archivo `Program.cs`, busca la línea `INotificacionService notificacion = new EmailNotificacionService();` y cámbiala por `new SmsNotificacionService();`. Vuelve a ejecutar el proyecto y verás cómo el sistema envía un SMS sin haber modificado ni una sola línea de la lógica del Core.

---
*Desarrollado como ejercicio de arquitectura backend, aplicando Clean Architecture y Patrones de Diseño en C#.*
