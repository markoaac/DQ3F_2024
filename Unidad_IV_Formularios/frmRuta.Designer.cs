namespace Unidad_IV_Formularios
{
    partial class frmRuta
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
            txtRepartidor = new TextBox();
            label1 = new Label();
            dgvPaquetes = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            SuspendLayout();
            // 
            // txtRepartidor
            // 
            txtRepartidor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtRepartidor.Location = new Point(40, 72);
            txtRepartidor.Name = "txtRepartidor";
            txtRepartidor.Size = new Size(503, 38);
            txtRepartidor.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Repartidor";
            // 
            // dgvPaquetes
            // 
            dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaquetes.Location = new Point(40, 147);
            dgvPaquetes.Name = "dgvPaquetes";
            dgvPaquetes.RowHeadersWidth = 51;
            dgvPaquetes.Size = new Size(503, 251);
            dgvPaquetes.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(200, 414);
            button2.Name = "button2";
            button2.Size = new Size(161, 40);
            button2.TabIndex = 17;
            button2.Text = "Guardar ruta";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmRuta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 479);
            Controls.Add(button2);
            Controls.Add(dgvPaquetes);
            Controls.Add(txtRepartidor);
            Controls.Add(label1);
            Name = "frmRuta";
            Text = "frmRuta";
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRepartidor;
        private Label label1;
        private DataGridView dgvPaquetes;
        private Button button2;
    }
}