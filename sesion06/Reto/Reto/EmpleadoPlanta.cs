using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    internal class EmpleadoPlanta : Empleado
    {
        public decimal SalarioMensual { get; set; }
        public int AniosAntiguedad { get; set; }

        public EmpleadoPlanta(string nombre, string documento, decimal salarioMensual, int aniosAntiguedad)
            : base(nombre, documento)
        {
            SalarioMensual = salarioMensual;
            AniosAntiguedad = aniosAntiguedad;
        }

        public override decimal CalcularSalario()
        {
            if (AniosAntiguedad >= 5)
            {
                return SalarioMensual * 1.05m; // Salario + 5% de bonificación
            }
            return SalarioMensual;
        }
    }
}
