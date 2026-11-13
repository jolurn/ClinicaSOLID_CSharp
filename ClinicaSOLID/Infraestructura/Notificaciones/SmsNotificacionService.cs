using ClinicaSOLID.Core.Interfaces;
using ClinicaSOLID.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Infraestructura.Notificaciones
{
    // L - Liskov Substitution: Puede reemplazar a EmailNotificacionService sin problemas.
    public class SmsNotificacionService : INotificacionService
    {
        public void EnviarConfirmacion(Paciente paciente, Cita cita)
        {
            Console.WriteLine($"[SMS ENVIADO] A {paciente.Nombre}: Cita confirmada para {cita.Especialidad}");
        }
    }
}
