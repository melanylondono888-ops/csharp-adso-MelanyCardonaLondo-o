using System;
using System.Collections.Generic;
using System.Text;

namespace Reto;

internal abstract class Empleado  
{
    public string Nombre { get; set; }
    public string Documento { get; set; }

    protected Empleado(string nombre, string documento)
    {
        Nombre = nombre;
        Documento = documento;
    }

    public abstract decimal CalcularSalario();

    public override string ToString()
    {
        return $"{Nombre} (Doc: {Documento})";
    }
}
