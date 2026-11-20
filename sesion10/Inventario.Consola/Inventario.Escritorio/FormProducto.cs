using Inventario.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventario.Escritorio
{
    public partial class FormProducto : Form
    {
        private readonly bool _esEdicion;
        public Producto? ProductoCreado { get; private set; }
        public string NombreEditado => txtNombre.Text;
        public decimal PrecioEditado => nudPrecio.Value;

        public FormProducto()
        {
            InitializeComponent();
        }
        public FormProducto(Producto productoExistente) : this()
        {
            _esEdicion = true;
            Text = "Editar producto";
            
            txtCodigo.Text = productoExistente.Codigo;
            txtCodigo.Enabled = false; // deshabilitado al editar

            txtNombre.Text = productoExistente.Nombre;
            nudPrecio.Value = productoExistente.Precio;

            nudStock.Value = productoExistente.Cantidad;
            nudStock.Enabled = false; // el stock no se edita aquí
        }
        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (_esEdicion)
                {
                    if (string.IsNullOrWhiteSpace(txtNombre.Text))
                        throw new ArgumentException("El nombre es obligatorio.");

                    if (nudPrecio.Value <= 0)
                        throw new ArgumentException("El precio debe ser mayor que cero.");

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    ProductoCreado = new Producto(txtCodigo.Text, txtNombre.Text, nudPrecio.Value, (int)nudStock.Value);
                    DialogResult = DialogResult.OK; // cierra la ventanilla: ¡aprobado!
                }
            }
            catch (ArgumentException ex)
            {
                errorProvider1.SetError(btnGuardar, ex.Message);
            }

        }



        private void nudStock_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
