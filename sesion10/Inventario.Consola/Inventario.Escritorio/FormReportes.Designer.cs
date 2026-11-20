namespace Inventario.Escritorio
{
    partial class FormReportes
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
            dgvMasValiosos = new DataGridView();
            dgvStockBajo = new DataGridView();
            lblMasValiosos = new Label();
            lblStockBajo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            SuspendLayout();
            // 
            // dgvMasValiosos
            // 
            dgvMasValiosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasValiosos.Location = new Point(12, 134);
            dgvMasValiosos.Name = "dgvMasValiosos";
            dgvMasValiosos.RowHeadersWidth = 51;
            dgvMasValiosos.Size = new Size(300, 188);
            dgvMasValiosos.TabIndex = 0;
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockBajo.Location = new Point(433, 134);
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.RowHeadersWidth = 51;
            dgvStockBajo.Size = new Size(300, 188);
            dgvStockBajo.TabIndex = 1;
            // 
            // lblMasValiosos
            // 
            lblMasValiosos.AutoSize = true;
            lblMasValiosos.Location = new Point(12, 85);
            lblMasValiosos.Name = "lblMasValiosos";
            lblMasValiosos.Size = new Size(94, 20);
            lblMasValiosos.TabIndex = 2;
            lblMasValiosos.Text = "Mas Valiosos";
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Location = new Point(433, 85);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(79, 20);
            lblStockBajo.TabIndex = 3;
            lblStockBajo.Text = "Stock Bajo";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStockBajo);
            Controls.Add(lblMasValiosos);
            Controls.Add(dgvStockBajo);
            Controls.Add(dgvMasValiosos);
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMasValiosos;
        private DataGridView dgvStockBajo;
        private Label lblMasValiosos;
        private Label lblStockBajo;
    }
}