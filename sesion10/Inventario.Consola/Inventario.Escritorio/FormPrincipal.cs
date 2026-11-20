using Inventario.Datos;
using Inventario.Dominio;
using Inventario.Servicios;

namespace Inventario.Escritorio
{
    public partial class FormPrincipal : Form
    {
        private readonly ServicioInventario _servicio = new(new RepositorioJson("inventario.json"));
        public FormPrincipal()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos(List<Producto>? productos = null)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos ?? _servicio.Listar();
            lblValor.Text = $"Valor del inventario: {_servicio.ValorInventario():C0}";

        }

        private Producto? Seleccionado() => dgvProductos.CurrentRow?.DataBoundItem as Producto;

        private void txtBuscar_TextChanged(object sender, EventArgs e) => CargarProductos(_servicio.BuscarPorTexto(txtBuscar.Text));

        private void dgvProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvProductos.Columns["Precio"] is DataGridViewColumn precio)
                precio.DefaultCellStyle.Format = "C0";

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.DataBoundItem is Producto { Cantidad: < ServicioInventario.LimiteStockBajo })
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;   // rosado suave
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using var form = new FormProducto();
            if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null) return;
            try
            {
                _servicio.Agregar(form.ProductoCreado);
                CargarProductos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto) return;
            var respuesta = MessageBox.Show($"¿Eliminar {producto.Nombre}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                _servicio.Eliminar(producto.Codigo);
                CargarProductos();
            }

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show(
                    "Selecciona un producto de la tabla primero.",
                    "Sin selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            try
            {
                bool vendido = _servicio.Vender(producto.Codigo, cantidad);
                if (!vendido)
                {
                    MessageBox.Show(
                        "No se encontró el producto seleccionado.",
                        "Producto no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                RefrescarTabla();
            }
            catch (StockInsuficienteException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Cantidad no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show(
                    "Selecciona un producto de la tabla primero.",
                    "Sin selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            try
            {
                bool agregado = _servicio.AgregarStock(producto.Codigo, cantidad);
                if (!agregado)
                {
                    MessageBox.Show(
                        "No se encontró el producto seleccionado.",
                        "Producto no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                RefrescarTabla();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Cantidad no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }

        private void RefrescarTabla()
        {
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
                CargarProductos(_servicio.BuscarPorTexto(txtBuscar.Text));
            else
                CargarProductos();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // evita clics en el encabezado

            if (dgvProductos.Rows[e.RowIndex].DataBoundItem is not Producto producto)
                return;

            using var form = new FormProducto(producto);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            try
            {

                string nuevoNombre = form.NombreEditado;
                decimal nuevoPrecio = form.PrecioEditado;

                bool actualizado = _servicio.Actualizar(producto.Codigo, nuevoNombre, nuevoPrecio);
                if (actualizado)
                    RefrescarTabla();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            using var formReportes = new FormReportes(_servicio);
            formReportes.ShowDialog();
        }
    }
}
