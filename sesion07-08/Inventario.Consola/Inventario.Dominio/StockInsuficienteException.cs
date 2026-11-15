using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Dominio
{
    public class StockInsuficienteException : Exception
    {
        public string Codigo { get; }
        public int Disponible { get; }
        public int Solicitado { get; }

        public StockInsuficienteException(string codigo, int disponible, int solicitado)
            : base($"Stock insuficiente para '{codigo}': hay {disponible} unidad(es) y pediste {solicitado}.")
        {
            Codigo = codigo;
            Disponible = disponible;
            Solicitado = solicitado;
        }
    }
}
