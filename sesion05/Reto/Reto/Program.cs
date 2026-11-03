using System;
using System.Collections.Generic;
using System.Linq;

namespace Reto
{
    public record LineaVenta(string Codigo, string Nombre, int Cantidad, decimal Subtotal);

    public record Factura(int Numero, DateTime Fecha, List<LineaVenta> Lineas, decimal Total);
    internal class Program
    {
        static List<Producto> inventario = new List<Producto>
        {
            new Producto("1", "teclado", 10000m, 10),
            new Producto("P02", "Mouse Gamer", 80000m, 15),
            new Producto("P03", "Monitor 24 pulgadas", 600000m, 5)
        };

        static List<lineaVenta> carrito =  new List<lineaVenta>
        {

        }

    } 
    
}
