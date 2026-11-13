using ClinicaSOLID.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Infraestructura.Visualizacion
{
    public class ConsolaOutput : IOutput
    {
        public void Mostrar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
