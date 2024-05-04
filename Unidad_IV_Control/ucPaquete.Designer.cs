namespace Unidad_IV_Control
{
    partial class ucPaquete
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
            lblId = new Label();
            lblIdPaquete = new Label();
            lblDireccion = new Label();
            lblComprador = new Label();
            lblPeso = new Label();
            lblVendedor = new Label();
            lblPrioridad = new Label();
            lblEstatus = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(52, 28);
            lblId.TabIndex = 0;
            lblId.Text = "lblId";
            // 
            // lblIdPaquete
            // 
            lblIdPaquete.AutoSize = true;
            lblIdPaquete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdPaquete.Location = new Point(3, 28);
            lblIdPaquete.Name = "lblIdPaquete";
            lblIdPaquete.Size = new Size(126, 28);
            lblIdPaquete.TabIndex = 1;
            lblIdPaquete.Text = "lblIdPaquete";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(3, 56);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(118, 28);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "lblDireccion";
            // 
            // lblComprador
            // 
            lblComprador.AutoSize = true;
            lblComprador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComprador.Location = new Point(3, 84);
            lblComprador.Name = "lblComprador";
            lblComprador.Size = new Size(136, 28);
            lblComprador.TabIndex = 3;
            lblComprador.Text = "lblComprador";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeso.Location = new Point(3, 112);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(77, 28);
            lblPeso.TabIndex = 4;
            lblPeso.Text = "lblPeso";
            // 
            // lblVendedor
            // 
            lblVendedor.AutoSize = true;
            lblVendedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendedor.Location = new Point(3, 140);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(123, 28);
            lblVendedor.TabIndex = 5;
            lblVendedor.Text = "lblVendedor";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrioridad.Location = new Point(3, 168);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(116, 28);
            lblPrioridad.TabIndex = 6;
            lblPrioridad.Text = "lblPrioridad";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(3, 196);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(98, 28);
            lblEstatus.TabIndex = 7;
            lblEstatus.Text = "lblEstatus";
            // 
            // ucPaquete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEstatus);
            Controls.Add(lblPrioridad);
            Controls.Add(lblVendedor);
            Controls.Add(lblPeso);
            Controls.Add(lblComprador);
            Controls.Add(lblDireccion);
            Controls.Add(lblIdPaquete);
            Controls.Add(lblId);
            Name = "ucPaquete";
            Size = new Size(536, 227);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblIdPaquete;
        private Label lblDireccion;
        private Label lblComprador;
        private Label lblPeso;
        private Label lblVendedor;
        private Label lblPrioridad;
        private Label lblEstatus;
    }
}
