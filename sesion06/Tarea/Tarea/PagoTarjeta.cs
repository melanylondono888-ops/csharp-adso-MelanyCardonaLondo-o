using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    internal class PagoTarjeta : IMetodoPago, IReembolsable
    {
        public string Nombre => "Tarjeta de Crédito";
        public string NumeroTarjeta { get; set; }

        public PagoTarjeta(string numeroTarjeta)
        {
            NumeroTarjeta = numeroTarjeta;
        }

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.03m; // 3% de comisión
        }

        public bool Validar(decimal monto)
        {
            // Valida que tenga exactamente 16 dígitos y no sea nulo/vacío
            return !string.IsNullOrEmpty(NumeroTarjeta) && NumeroTarjeta.Length == 16 && NumeroTarjeta.All(char.IsDigit);
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine($"[Reembolso] Se ha devuelto {monto:C0} a la tarjeta terminada en {NumeroTarjeta[^4..]}.");
        }
    }
}
