namespace practica2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtNombreCompleto = new TextBox();
            lblNombreCompleto = new Label();
            nudEdad = new NumericUpDown();
            lblEdad = new Label();
            cmbPrograma = new ComboBox();
            rbdManana = new CheckBox();
            rdbTarde = new CheckBox();
            lblJornada = new Label();
            btnInscribir = new Button();
            lstInscritos = new ListBox();
            chkTerminos = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(26, 65);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(125, 27);
            txtNombreCompleto.TabIndex = 0;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(26, 31);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(134, 20);
            lblNombreCompleto.TabIndex = 1;
            lblNombreCompleto.Text = "Nombre Completo";
            lblNombreCompleto.Click += label1_Click;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(26, 164);
            nudEdad.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(150, 27);
            nudEdad.TabIndex = 2;
            nudEdad.Value = new decimal(new int[] { 14, 0, 0, 0 });
            nudEdad.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(26, 129);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // cmbPrograma
            // 
            cmbPrograma.FormattingEnabled = true;
            cmbPrograma.Items.AddRange(new object[] { "ADSO", "multimedia ", "contabilidad" });
            cmbPrograma.Location = new Point(26, 245);
            cmbPrograma.Name = "cmbPrograma";
            cmbPrograma.Size = new Size(188, 28);
            cmbPrograma.TabIndex = 4;
            cmbPrograma.Text = "selecciona tu programa ";
            // 
            // rbdManana
            // 
            rbdManana.AutoSize = true;
            rbdManana.Location = new Point(26, 351);
            rbdManana.Name = "rbdManana";
            rbdManana.Size = new Size(84, 24);
            rbdManana.TabIndex = 6;
            rbdManana.Text = "Mañana";
            rbdManana.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(26, 381);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(67, 24);
            rdbTarde.TabIndex = 7;
            rdbTarde.Text = "Tarde";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // lblJornada
            // 
            lblJornada.AutoSize = true;
            lblJornada.Location = new Point(26, 311);
            lblJornada.Name = "lblJornada";
            lblJornada.Size = new Size(140, 20);
            lblJornada.TabIndex = 8;
            lblJornada.Text = "¿cuál es tu jornada?";
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(266, 162);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(94, 29);
            btnInscribir.TabIndex = 12;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // lstInscritos
            // 
            lstInscritos.FormattingEnabled = true;
            lstInscritos.Location = new Point(266, 245);
            lstInscritos.Name = "lstInscritos";
            lstInscritos.Size = new Size(150, 104);
            lstInscritos.TabIndex = 13;
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Location = new Point(268, 69);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(147, 24);
            chkTerminos.TabIndex = 14;
            chkTerminos.Text = "Aceptar Terminos";
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1218, 590);
            Controls.Add(chkTerminos);
            Controls.Add(lstInscritos);
            Controls.Add(btnInscribir);
            Controls.Add(lblJornada);
            Controls.Add(rdbTarde);
            Controls.Add(rbdManana);
            Controls.Add(cmbPrograma);
            Controls.Add(lblEdad);
            Controls.Add(nudEdad);
            Controls.Add(lblNombreCompleto);
            Controls.Add(txtNombreCompleto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCompleto;
        private Label lblNombreCompleto;
        private NumericUpDown nudEdad;
        private Label lblEdad;
        private ComboBox cmbPrograma;
        private CheckBox rbdManana;
        private CheckBox rdbTarde;
        private Label lblJornada;
        private Button btnInscribir;
        private ListBox lstInscritos;
        private CheckBox chkTerminos;
        private ErrorProvider errorProvider1;
    }
}
