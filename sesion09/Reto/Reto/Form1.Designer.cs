namespace Reto
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
            lblInfoCuenta = new Label();
            nudMonto = new NumericUpDown();
            btnDepositar = new Button();
            btnRetirar = new Button();
            lstMovimientos = new ListBox();
            btnTransferir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // lblInfoCuenta
            // 
            lblInfoCuenta.AutoSize = true;
            lblInfoCuenta.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfoCuenta.Location = new Point(36, 20);
            lblInfoCuenta.Name = "lblInfoCuenta";
            lblInfoCuenta.Size = new Size(431, 39);
            lblInfoCuenta.TabIndex = 0;
            lblInfoCuenta.Text = "Andres, Saldo Inicial: 500000";
            // 
            // nudMonto
            // 
            nudMonto.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Location = new Point(48, 105);
            nudMonto.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(150, 27);
            nudMonto.TabIndex = 1;
            nudMonto.ThousandsSeparator = true;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(48, 165);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 2;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(48, 242);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(94, 29);
            btnRetirar.TabIndex = 3;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // lstMovimientos
            // 
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(281, 107);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(299, 244);
            lstMovimientos.TabIndex = 4;
            lstMovimientos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(48, 323);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(94, 29);
            btnTransferir.TabIndex = 5;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(975, 600);
            Controls.Add(btnTransferir);
            Controls.Add(lstMovimientos);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Controls.Add(nudMonto);
            Controls.Add(lblInfoCuenta);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoCuenta;
        private NumericUpDown nudMonto;
        private Button btnDepositar;
        private Button btnRetirar;
        private ListBox lstMovimientos;
        private Button btnTransferir;
    }
}
