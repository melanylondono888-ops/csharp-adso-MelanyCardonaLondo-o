using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Dominio
{
    public interface IRepositorioProductos
    {
        List<Producto> Cargar();
        void Guardar(List<Producto> productos);
    }
}
