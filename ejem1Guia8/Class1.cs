using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_POO2.ejem1Guia8
{
    internal class PagoConTarjeta:IPago
    {
        public string ProcesarPago(decimal monto)
        {
            return $"pago con tarjeta por ${monto}";
        }
    }
}
