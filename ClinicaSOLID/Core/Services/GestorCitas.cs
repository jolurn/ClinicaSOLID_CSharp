using ClinicaSOLID.Core.Interfaces;
using ClinicaSOLID.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Core.Services
{
    // D - Dependency Inversion: Depende de las interfaces, no de las clases reales.
    internal class GestorCitas
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly INotificacionService _notificacionService;
        private readonly IOutput _output;

        public GestorCitas(
            IPacienteRepository pacienteRepository,
            INotificacionService notificacionService,
            IOutput output)
        {
            _pacienteRepository = pacienteRepository;
            _notificacionService = notificacionService;
            _output = output;
        }

        public void AgendarCita(string dniPaciente, string especialidad, decimal costo)
        {
            var paciente = _pacienteRepository.ObtenerPorDni(dniPaciente);

            if (paciente == null)
            {
                _output.Mostrar("Error: Paciente no encontrado.");
                return;
            }

            var nuevaCita = new Cita
            {
                Paciente = paciente,
                Especialidad = especialidad,
                Fecha = DateTime.Now.AddDays(3),
                Costo = costo
            };

            _output.Mostrar($"--- Cita agendada ---");
            _output.Mostrar($"Paciente: {paciente.Nombre}");
            _output.Mostrar($"Especialidad: {especialidad}");
            _output.Mostrar($"Costo: {costo:C}");

            _notificacionService.EnviarConfirmacion(paciente, nuevaCita);
        }
    }
}
