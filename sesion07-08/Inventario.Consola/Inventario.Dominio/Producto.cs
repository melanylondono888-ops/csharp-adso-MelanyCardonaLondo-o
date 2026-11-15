using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Dominio
{
    public class Producto
    {
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        // Constructor vacío: lo necesita System.Text.Json para deserializar.
        public Producto() { }

        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void AgregarStock(int unidades)
        {
            Cantidad += unidades;
        }

        /// <summary>Descuenta unidades. Lanza StockInsuficienteException si no alcanza.</summary>
        public void Vender(int unidades)
        {
            if (unidades > Cantidad)
                throw new StockInsuficienteException(Codigo, Cantidad, unidades);

            Cantidad -= unidades;
        }
    }
}
