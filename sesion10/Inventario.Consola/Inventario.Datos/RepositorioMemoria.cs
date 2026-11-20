using Inventario.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Datos
{
    public class RepositorioMemoria : IRepositorioProductos
    {
        private List<Producto> _productos = new();

        public List<Producto> Cargar()
        {
            return _productos.Select(p => new Producto(p.Codigo, p.Nombre, p.Precio, p.Cantidad)).ToList();
        }

        public void Guardar(List<Producto> productos)
        {
            // Copia, para no compartir las mismas referencias con el servicio.
            _productos = productos.Select(p => new Producto(p.Codigo, p.Nombre, p.Precio, p.Cantidad)).ToList();
        }
    }
}
