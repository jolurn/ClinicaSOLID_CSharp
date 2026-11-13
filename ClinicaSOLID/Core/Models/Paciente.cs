using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Core.Models
{
    // S - Single Responsibility: Esta clase solo representa los datos del paciente.
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
    }
}
