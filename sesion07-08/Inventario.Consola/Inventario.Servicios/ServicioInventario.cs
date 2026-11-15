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

        /// <summary>Registra un producto nuevo. Devuelve false si el código ya existe.</summary>
        public bool Agregar(Producto producto)
        {
            if (Buscar(producto.Codigo) is not null)
                return false;

            _productos.Add(producto);
            _repositorio.Guardar(_productos);
            return true;
        }

        /// <summary>Suma stock. Devuelve false si el producto no existe.</summary>
        public bool AgregarStock(string codigo, int unidades)
        {
            var producto = Buscar(codigo);
            if (producto is null)
                return false;

            producto.AgregarStock(unidades);
            _repositorio.Guardar(_productos);
            return true;
        }

        /// <summary>
        /// Vende unidades. Devuelve false si el producto no existe.
        /// Si no alcanza el stock, deja pasar StockInsuficienteException para que la consola la atrape.
        /// </summary>
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

        /// <summary>Productos cuyo nombre o código contengan el texto (sin importar mayúsculas).</summary>
        public List<Producto> BuscarPorTexto(string texto) =>
            _productos
                .Where(p => p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase)
                         || p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();

        /// <summary>Elimina el producto con ese código y guarda. Si no existe, no hace nada.</summary>
        public void Eliminar(string codigo)
        {
            var producto = Buscar(codigo);
            if (producto is null)
                return;

            _productos.Remove(producto);
            _repositorio.Guardar(_productos);
        }
    }


}
