using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    internal class PagoEfectivo : IMetodoPago
    {

        public string Nombre => "Efectivo";

        public decimal CalcularComision(decimal monto)
        {
            return 0m; // 0% de comisión
        }

        public bool Validar(decimal monto)
        {
            return true; // Siempre válido
        }
    }
}
