using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Core.Models
{
    // S - Single Responsibility: Esta clase solo representa la cita médica.
    public class Cita
    {
        public Paciente Paciente { get; set; }
        public string Especialidad { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Costo { get; set; }
    }
}
