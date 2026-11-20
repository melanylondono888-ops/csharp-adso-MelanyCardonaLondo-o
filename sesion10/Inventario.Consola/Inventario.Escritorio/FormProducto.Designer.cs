namespace Inventario.Escritorio
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            nudPrecio = new NumericUpDown();
            nudStock = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(43, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(43, 140);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Location = new Point(271, 59);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 3;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudStock
            // 
            nudStock.Location = new Point(271, 140);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(150, 27);
            nudStock.TabIndex = 4;
            nudStock.ValueChanged += nudStock_ValueChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(271, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(429, 244);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(43, 33);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 118);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(272, 30);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 115);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 10;
            label1.Text = "Stock";
            // 
            // FormProducto
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudStock);
            Controls.Add(nudPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Name = "FormProducto";
            Text = "FormProducto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudStock;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblCodigo;
        private Label label1;
    }
}