namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly ConversorTemperatura _conversor = new ConversorTemperatura();
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            
            if (!double.TryParse(txtValor.Text, out double valorIngresado))
            {
                errorProvider1.SetError(txtValor, "Por favor ingresa un valor numérico válido.");
                return;
            }

            
            if (cmbOrigen.SelectedItem == null)
            {
                errorProvider1.SetError(cmbOrigen, "Selecciona una unidad de origen.");
                return;
            }

            if (cmbDestino.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDestino, "Selecciona una unidad de destino.");
                return;
            }

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            try
            {
                // Llamar a la clase externa para calcular
                double resultado = _conversor.Convertir(valorIngresado, origen, destino);

                // Mostrar el resultado en el Label
                lblResultado.Text = $"Resultado: {resultado:F2} {destino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error de cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
