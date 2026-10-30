using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    internal class Producto
    {
        private string _nombre;
        private decimal _precio;

        
        public string Codigo { get; private set; }

        
        public string Nombre
        {
            get => _nombre;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        // Propiedad Precio (mayor que cero)
        public decimal Precio
        {
            get => _precio;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que cero.");
                _precio = value;
            }
        }

        // Propiedad Stock (solo cambia mediante métodos)
        public int Stock { get; private set; }

        // Único constructor
        public Producto(string codigo, string nombre, decimal precio, int stock)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código es obligatorio.");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            Codigo = codigo.ToUpper(); // Convertimos a mayúsculas
            Nombre = nombre;           // Activa la validación de la propiedad
            Precio = precio;           // Activa la validación de la propiedad
            Stock = stock;
        }

        // Método para agregar stock
        public void AgregarStock(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad a agregar debe ser mayor a 0.");

            Stock += cantidad;
        }

        // Método para vender (descuenta stock si hay suficiente)
        public bool Vender(int cantidad)
        {
            if (cantidad <= 0 || cantidad > Stock)
                return false;

            Stock -= cantidad;
            return true;
        }

        public override string ToString() =>
            $"[{Codigo}] {Nombre} - Precio: ${Precio:N2} | Stock: {Stock}";


    }
}
