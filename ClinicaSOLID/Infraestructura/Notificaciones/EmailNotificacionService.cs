using ClinicaSOLID.Core.Interfaces;
using ClinicaSOLID.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Infraestructura.Notificaciones
{
    public class EmailNotificacionService : INotificacionService
    {
        public void EnviarConfirmacion(Paciente paciente, Cita cita)
        {
            Console.WriteLine($"[EMAIL ENVIADO] A {paciente.Nombre} por su cita de {cita.Especialidad} el {cita.Fecha.ToShortDateString()}");
        }
    }
}
