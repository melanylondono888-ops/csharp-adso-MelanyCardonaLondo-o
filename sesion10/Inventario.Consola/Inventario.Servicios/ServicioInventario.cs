using Inventario.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Servicios
{
    public class ServicioInventario
    {
        public const int LimiteStockBajo = 5;

        private readonly IRepositorioProductos _repositorio;
        private readonly List<Producto> _productos;

        public ServicioInventario(IRepositorioProductos repositorio)
        {
            _repositorio = repositorio;
            _productos = _repositorio.Cargar();
        }

        public IReadOnlyList<Producto> Listar() => _productos;

        public Producto? Buscar(string codigo) =>
            _productos.FirstOrDefault(p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase));

     
        public bool Agregar(Producto producto)
        {
            if (Buscar(producto.Codigo) is not null)
                return false;

            _productos.Add(producto);
            _repositorio.Guardar(_productos);
            return true;
        }

        public bool AgregarStock(string codigo, int unidades)
        {
            var producto = Buscar(codigo);
            if (producto is null)
                return false;

            producto.AgregarStock(unidades);
            _repositorio.Guardar(_productos);
            return true;
        }

       
        public bool Vender(string codigo, int unidades)
        {
            var producto = Buscar(codigo);
            if (producto is null)
                return false;

            producto.Vender(unidades);
            _repositorio.Guardar(_productos);
            return true;
        }

        public List<Producto> StockBajo() =>
            _productos.Where(p => p.Cantidad < LimiteStockBajo).ToList();

       
        public decimal ValorInventario() =>
            _productos.Sum(p => p.Precio * p.Cantidad);


        public List<Producto> BuscarPorTexto(string texto) =>
            _productos
                .Where(p => p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase)
                         || p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();


        public void Eliminar(string codigo)
        {
            var producto = Buscar(codigo);
            if (producto is null)
                return;

            _productos.Remove(producto);
            _repositorio.Guardar(_productos);
        }
        public bool Actualizar(string codigo, string nuevoNombre, decimal nuevoPrecio)
        {
            var producto = Buscar(codigo);
            if (producto is null)
                return false;

            if (string.IsNullOrWhiteSpace(nuevoNombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (nuevoPrecio <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");

            producto.Nombre = nuevoNombre.Trim();
            producto.Precio = nuevoPrecio;
            _repositorio.Guardar(_productos);
            return true;
        }
    }


}
