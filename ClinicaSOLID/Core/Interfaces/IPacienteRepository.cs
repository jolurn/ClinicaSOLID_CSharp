using ClinicaSOLID.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Core.Interfaces
{
    // I - Interface Segregation: Interfaz pequeña dedicada solo a leer pacientes.
    public interface IPacienteRepository
    {
        Paciente ObtenerPorDni(string dni);
    }
}
