namespace Unidad_I
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnNombre = new Button();
            btnAgregarBotones = new Button();
            btnAgregarImagenes = new Button();
            contenedorBotones = new FlowLayoutPanel();
            contenedorImagenes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(131, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese su nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(188, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(427, 24);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(94, 29);
            btnNombre.TabIndex = 2;
            btnNombre.Text = "Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnAgregarBotones
            // 
            btnAgregarBotones.Location = new Point(200, 105);
            btnAgregarBotones.Name = "btnAgregarBotones";
            btnAgregarBotones.Size = new Size(186, 50);
            btnAgregarBotones.TabIndex = 3;
            btnAgregarBotones.Text = "Agregar botones";
            btnAgregarBotones.UseVisualStyleBackColor = true;
            btnAgregarBotones.Click += btnAgregarBotones_Click;
            // 
            // btnAgregarImagenes
            // 
            btnAgregarImagenes.Location = new Point(775, 105);
            btnAgregarImagenes.Name = "btnAgregarImagenes";
            btnAgregarImagenes.Size = new Size(186, 50);
            btnAgregarImagenes.TabIndex = 4;
            btnAgregarImagenes.Text = "Agregar imágenes";
            btnAgregarImagenes.UseVisualStyleBackColor = true;
            btnAgregarImagenes.Click += btnAgregarImagenes_Click;
            // 
            // contenedorBotones
            // 
            contenedorBotones.BorderStyle = BorderStyle.Fixed3D;
            contenedorBotones.Location = new Point(34, 171);
            contenedorBotones.Name = "contenedorBotones";
            contenedorBotones.Size = new Size(499, 417);
            contenedorBotones.TabIndex = 5;
            // 
            // contenedorImagenes
            // 
            contenedorImagenes.BorderStyle = BorderStyle.Fixed3D;
            contenedorImagenes.Location = new Point(580, 171);
            contenedorImagenes.Name = "contenedorImagenes";
            contenedorImagenes.Size = new Size(531, 417);
            contenedorImagenes.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 616);
            Controls.Add(contenedorImagenes);
            Controls.Add(contenedorBotones);
            Controls.Add(btnAgregarImagenes);
            Controls.Add(btnAgregarBotones);
            Controls.Add(btnNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnNombre;
        private Button btnAgregarBotones;
        private Button btnAgregarImagenes;
        private FlowLayoutPanel contenedorBotones;
        private FlowLayoutPanel contenedorImagenes;
    }
}
