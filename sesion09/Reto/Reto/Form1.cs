namespace Reto
{
    public partial class Form1 : Form
    {

        private CuentaBancaria miCuenta = new CuentaBancaria("Andres", "001-123", 500000m);
        private CuentaBancaria cuentaDestino = new CuentaBancaria("Destino", "002-456", 0m);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarInterfaz();
        }
        private void ActualizarInterfaz()
        {

            lblInfoCuenta.Text = $"Titular: {miCuenta.Titular}  |  Saldo Actual: ${miCuenta.Saldo:N0}";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            try
            {

                miCuenta.Depositar(monto);


                string movimiento = $"{DateTime.Now:HH:mm:ss} - Depósito: +${monto:N0}";
                lstMovimientos.Items.Insert(0, movimiento);

                ActualizarInterfaz();
                nudMonto.Value = 0;
            }
            catch (Exception ex)
            {
                // Mostramos el MessageBox si ocurre un error (ej. múltiplo de $10.000)
                MessageBox.Show(ex.Message, "Error en depósito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            try
            {
                // Llamamos al método de retiro de tu clase
                miCuenta.Retirar(monto);

                // Agregamos al ListBox el movimiento arriba del todo
                string movimiento = $"{DateTime.Now:HH:mm:ss} - Retiro: -${monto:N0}";
                lstMovimientos.Items.Insert(0, movimiento);

                ActualizarInterfaz();
                nudMonto.Value = 0;
            }
            catch (Exception ex)
            {
                // Muestra el MessageBox si hay saldo insuficiente o no cumple las reglas
                MessageBox.Show(ex.Message, "Error en retiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            try
            {
                miCuenta.Transferir(cuentaDestino, monto);

                string movimiento = $"{DateTime.Now:HH:mm:ss} - Transferencia: -${monto:N0}";
                lstMovimientos.Items.Insert(0, movimiento);

                ActualizarInterfaz();
                nudMonto.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en transferencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
