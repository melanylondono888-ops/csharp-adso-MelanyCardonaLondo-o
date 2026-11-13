namespace practica1
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
            lblPregunta = new Label();
            txtNombre = new TextBox();
            btnSaludar = new Button();
            lblSaludo = new Label();
            lblNumero1 = new Label();
            txtNumero1 = new TextBox();
            lblNumero2 = new Label();
            txtNumero2 = new TextBox();
            lblResultado = new Label();
            txtResultado = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(27, 9);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(194, 28);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "¿como te llamas?";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(27, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 32);
            txtNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaludar.Location = new Point(251, 62);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(94, 29);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(253, 15);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(0, 20);
            lblSaludo.TabIndex = 3;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(27, 148);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(72, 20);
            lblNumero1.TabIndex = 4;
            lblNumero1.Text = "número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(27, 180);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(132, 27);
            txtNumero1.TabIndex = 5;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(27, 243);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(72, 20);
            lblNumero2.TabIndex = 6;
            lblNumero2.Text = "número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(27, 266);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 7;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(27, 322);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(27, 371);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 9;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(293, 298);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(52, 44);
            btnSumar.TabIndex = 10;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(198, 300);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(52, 42);
            btnRestar.TabIndex = 11;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(293, 210);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(55, 47);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(198, 210);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(55, 44);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "Div";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1150, 450);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Controls.Add(lblSaludo);
            Controls.Add(btnSaludar);
            Controls.Add(txtNombre);
            Controls.Add(lblPregunta);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private TextBox txtNombre;
        private Button btnSaludar;
        private Label lblSaludo;
        private Label lblNumero1;
        private TextBox txtNumero1;
        private Label lblNumero2;
        private TextBox txtNumero2;
        private Label lblResultado;
        private TextBox txtResultado;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}
