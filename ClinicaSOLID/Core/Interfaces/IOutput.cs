using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSOLID.Core.Interfaces
{
    // I - Interface Segregation: Interfaz dedicada solo a mostrar mensajes.
    public interface IOutput
    {
        void Mostrar(string mensaje);
    }
}
