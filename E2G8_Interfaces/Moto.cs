using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_POO2.E2G8_Interfaces
{
    internal class Moto:IVehiculo
    {
        public string MostrarInformacion()
        {
            return $"Capacidad de motocicleta 1 pasajero";
        }
    }
}
