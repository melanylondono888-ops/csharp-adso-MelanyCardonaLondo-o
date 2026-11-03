using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    internal class ProcesarPagos
    {
        public void Cobrar(IMetodoPago metodoPago, decimal monto)
        {
            Console.WriteLine($"\n--- Procesando pago con {metodoPago.Nombre} ---");

            if (!metodoPago.Validar(monto))
            {
                Console.WriteLine("❌ Error: El pago no pasó la validación (monto no permitido o datos incorrectos).");
                return;
            }

            decimal comision = metodoPago.CalcularComision(monto);
            decimal totalPagar = monto + comision;

            Console.WriteLine($"Monto base: {monto:C0}");
            Console.WriteLine($"Comisión: {comision:C0}");
            Console.WriteLine($"Total a pagar: {totalPagar:C0}");
            Console.WriteLine("✅ ¡Pago realizado con éxito!");
        }

        public void Devolver(IMetodoPago metodoPago, decimal monto)
        {
            Console.WriteLine($"\n--- Solicitando reembolso para {metodoPago.Nombre} ---");

            // Verifica si el método implementa la interfaz IReembolsable usando pattern matching
            if (metodoPago is IReembolsable reembolsable)
            {
                reembolsable.Reembolsar(monto);
            }
            else
            {
                Console.WriteLine($"❌ El método {metodoPago.Nombre} no permite reembolsos.");
            }
        }
    }
}
