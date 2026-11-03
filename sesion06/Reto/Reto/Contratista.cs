using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    internal class Contratista : Empleado
    {
        public decimal ValorContrato { get; set; }

        public Contratista(string nombre, string documento, decimal valorContrato)
            : base(nombre, documento)
        {
            ValorContrato = valorContrato;
        }

        public override decimal CalcularSalario()
        {
            return ValorContrato * 0.90m; // Valor menos 10% de retención
        }
    }
}
