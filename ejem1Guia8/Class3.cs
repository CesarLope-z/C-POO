using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_POO2.ejem1Guia8
{
    internal class PagoConEfectivo:IPago
    {
        public string ProcesarPago(decimal monto)
        {
            return $"pago con efectivo por ${monto}";
        }
    }
}
