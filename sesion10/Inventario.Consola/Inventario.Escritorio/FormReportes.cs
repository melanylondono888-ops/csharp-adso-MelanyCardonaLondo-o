using Inventario.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventario.Escritorio
{
    public partial class FormReportes : Form
    {
        public FormReportes(ServicioInventario servicio)
        {
            InitializeComponent();
            CargarReportes(servicio);
        }

        private void CargarReportes(ServicioInventario servicio)
        {
            var masValiosos = servicio.Listar()
                .OrderByDescending(p => p.Precio * p.Cantidad)
                .ToList();

            dgvMasValiosos.DataSource = null;
            dgvMasValiosos.DataSource = masValiosos;

            dgvStockBajo.DataSource = null;
            dgvStockBajo.DataSource = servicio.StockBajo();
        }
        private void FormReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
