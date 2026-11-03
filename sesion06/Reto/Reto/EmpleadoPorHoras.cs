using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    internal class EmpleadoPorHoras : Empleado
    {

        public int Horas { get; set; }
        public decimal ValorHora { get; set; }

        public EmpleadoPorHoras(string nombre, string documento, int horas, decimal valorHora)
            : base(nombre, documento)
        {
            Horas = horas;
            ValorHora = valorHora;
        }

        public override decimal CalcularSalario()
        {
            if (Horas > 160)
            {
                int horasNormales = 160;
                int horasExtras = Horas - 160;
                return (horasNormales * ValorHora) + (horasExtras * ValorHora * 1.5m);
            }
            return Horas * ValorHora;
        }
    }
}
