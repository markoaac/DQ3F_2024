namespace Unidad_II_Control
{
    partial class ucMascota
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbMascota = new PictureBox();
            lblNombre = new Label();
            lblTipo = new Label();
            ofdCambiar = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbMascota).BeginInit();
            SuspendLayout();
            // 
            // pbMascota
            // 
            pbMascota.BorderStyle = BorderStyle.Fixed3D;
            pbMascota.Location = new Point(3, 3);
            pbMascota.Name = "pbMascota";
            pbMascota.Size = new Size(87, 96);
            pbMascota.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMascota.TabIndex = 0;
            pbMascota.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblNombre.Location = new Point(96, 3);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(40, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "----";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTipo.Location = new Point(96, 74);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 25);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "----";
            // 
            // ofdCambiar
            // 
            ofdCambiar.FileName = "openFileDialog1";
            // 
            // ucMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(pbMascota);
            Name = "ucMascota";
            Size = new Size(238, 104);
            ((System.ComponentModel.ISupportInitialize)pbMascota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMascota;
        private Label lblNombre;
        private Label lblTipo;
        private OpenFileDialog ofdCambiar;
    }
}
