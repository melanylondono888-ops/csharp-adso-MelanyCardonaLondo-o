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
        public Producto? ProductoCreado { get; private set; }

        public FormProducto()
        {
            InitializeComponent();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                ProductoCreado = new Producto(txtCodigo.Text, txtNombre.Text, nudPrecio.Value, (int)nudStock.Value);
                DialogResult = DialogResult.OK;   // cierra la ventanilla: ¡aprobado!
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
