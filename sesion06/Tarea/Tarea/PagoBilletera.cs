using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    internal class PagoBilletera : IMetodoPago, IReembolsable
    {
        public string Nombre => "Billetera Digital";

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.01m; // 1% de comisión
        }

        public bool Validar(decimal monto)
        {
            // Máximo $2.000.000 permitidos
            return monto <= 2_000_000m;
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine($"[Reembolso] Se ha devuelto {monto:C0} a la billetera digital del usuario.");
        }
    }
}
