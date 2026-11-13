namespace practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                errorProvider1.SetError(txtNombreCompleto, "Escribe el nombre.");
                valido = false;
            }
            if (cmbPrograma.SelectedItem is null)
            {
                errorProvider1.SetError(cmbPrograma, "Elige un programa.");
                valido = false;
            }
            if (!chkTerminos.Checked)
            {
                errorProvider1.SetError(chkTerminos, "Debes aceptar los términos.");
                valido = false;
            }
            if (!valido) return;

            string jornada = rbdManana.Checked ? "Mañana" : "Tarde";
            lstInscritos.Items.Add($"{txtNombreCompleto.Text} · {nudEdad.Value} años · {cmbPrograma.SelectedItem} · {jornada}");
            txtNombreCompleto.Clear();
            txtNombreCompleto.Clear();
            nudEdad.Value = 14; // O el valor por defecto que prefieras
            cmbPrograma.SelectedIndex = -1; // Deselecciona cualquier elemento del ComboBox
            rbdManana.Checked = true; // Opcional: dejar marcado uno por defecto
            chkTerminos.Checked = false; // Desmarcar los términos

            // Volver a poner el cursor en el campo de texto principal
            txtNombreCompleto.Focus();
        }

        private void lstInscritos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
