using ClinicaSOLID.Core.Interfaces;
using ClinicaSOLID.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Infraestructura.Repositorios
{
    public class MemoriaPacienteRepository : IPacienteRepository
    {
        private readonly List<Paciente> _pacientes = new List<Paciente>
        {
            new Paciente { Id = 1, Nombre = "Juan Perez", Dni = "12345678" },
            new Paciente { Id = 2, Nombre = "Maria Lopez", Dni = "87654321" }
        };

        public Paciente ObtenerPorDni(string dni)
        {
            return _pacientes.FirstOrDefault(p => p.Dni == dni);
        }
    }
}
