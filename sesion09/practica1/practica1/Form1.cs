namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int ObtenerNumero(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new ArgumentException($"El campo {nombreCampo} no puede estar vacío.", nombreCampo);

            if (!int.TryParse(texto, out int numero))
                throw new ArgumentException($"El campo {nombreCampo} debe ser un número entero válido.", nombreCampo);

            return numero;
        }

        // Realiza la división y lanza ArgumentException si el divisor es cero
        private int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("No se puede dividir entre cero (0).", nameof(divisor));

            return dividendo / divisor;
        }

        private void MostrarError(ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Hola, {txtNombre.Text} bienvenido/a a mi programa de calculadora";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 + n2);
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 * n2);
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 - n2);
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(Dividir(n1, n2));
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }
    }
}
