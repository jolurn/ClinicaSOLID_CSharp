using ClinicaSOLID.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Core.Interfaces
{
    // I - Interface Segregation: Interfaz dedicada solo a enviar notificaciones.
    public interface INotificacionService
    {
        void EnviarConfirmacion(Paciente paciente, Cita cita);
    }
}
