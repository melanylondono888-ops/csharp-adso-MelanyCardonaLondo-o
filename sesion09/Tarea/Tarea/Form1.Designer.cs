namespace Tarea
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
            txtValor = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            lblValorConvetir = new Label();
            lblValorInicial = new Label();
            lblConvertirA = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 60);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 0;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "°C", "°F", "K" });
            cmbOrigen.Location = new Point(12, 159);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(151, 28);
            cmbOrigen.TabIndex = 1;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "°C", "°F", "K" });
            cmbDestino.Location = new Point(12, 255);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(151, 28);
            cmbDestino.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(251, 58);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 29);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(251, 144);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblValorConvetir
            // 
            lblValorConvetir.AutoSize = true;
            lblValorConvetir.Location = new Point(12, 19);
            lblValorConvetir.Name = "lblValorConvetir";
            lblValorConvetir.Size = new Size(119, 20);
            lblValorConvetir.TabIndex = 5;
            lblValorConvetir.Text = "Valor a Convertir";
            // 
            // lblValorInicial
            // 
            lblValorInicial.AutoSize = true;
            lblValorInicial.Location = new Point(14, 128);
            lblValorInicial.Name = "lblValorInicial";
            lblValorInicial.Size = new Size(86, 20);
            lblValorInicial.TabIndex = 6;
            lblValorInicial.Text = "Valor inicial";
            // 
            // lblConvertirA
            // 
            lblConvertirA.AutoSize = true;
            lblConvertirA.Location = new Point(13, 229);
            lblConvertirA.Name = "lblConvertirA";
            lblConvertirA.Size = new Size(88, 20);
            lblConvertirA.TabIndex = 7;
            lblConvertirA.Text = "Convertir a: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConvertirA);
            Controls.Add(lblValorInicial);
            Controls.Add(lblValorConvetir);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
        private Button btnConvertir;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
        private Label lblValorConvetir;
        private Label lblConvertirA;
        private Label lblValorInicial;
    }
}
