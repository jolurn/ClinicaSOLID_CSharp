using ClinicaSOLID.Core.Interfaces;
using ClinicaSOLID.Core.Services;
using ClinicaSOLID.Infraestructura.Notificaciones;
using ClinicaSOLID.Infraestructura.Repositorios;
using ClinicaSOLID.Infraestructura.Visualizacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Instanciamos las implementaciones (Infraestructura)
            IOutput consola = new ConsolaOutput();
            IPacienteRepository repositorio = new MemoriaPacienteRepository();

            // 2. Elegimos la estrategia de notificación (O - Open/Closed)
            // Cambia "EmailNotificacionService" por "SmsNotificacionService" para ver la magia.
            INotificacionService notificacion = new EmailNotificacionService();

            // 3. Inyectamos las dependencias en el Core
            var gestor = new GestorCitas(repositorio, notificacion, consola);

            // 4. Ejecutamos la lógica de negocio
            gestor.AgendarCita("12345678", "Cardiología", 150.00m);
            gestor.AgendarCita("99999999", "Pediatría", 100.00m); // Este no existe, probará el error.

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
