using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_POO2.E2G8_Interfaces
{
    internal class Bus:IVehiculo
    {
        public string MostrarInformacion()
        {
            return $"Capacidad de bus 20 pasajeros";
        }
    }
}
