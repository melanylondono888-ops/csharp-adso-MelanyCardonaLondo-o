using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    internal interface IMetodoPago
    {
        string Nombre { get; }
        decimal CalcularComision(decimal monto);
        bool Validar(decimal monto);
    }
}
