namespace Unidad_II_Formularios
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtEspecie = new TextBox();
            label2 = new Label();
            button1 = new Button();
            contenedor = new FlowLayoutPanel();
            ofdBuscar = new OpenFileDialog();
            button2 = new Button();
            txtMascotas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNombre.Location = new Point(22, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtEspecie
            // 
            txtEspecie.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtEspecie.Location = new Point(22, 127);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(196, 34);
            txtEspecie.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(22, 96);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 2;
            label2.Text = "Especie";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(50, 180);
            button1.Name = "button1";
            button1.Size = new Size(118, 42);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contenedor
            // 
            contenedor.AutoScroll = true;
            contenedor.BackColor = Color.Gainsboro;
            contenedor.BorderStyle = BorderStyle.Fixed3D;
            contenedor.Location = new Point(236, 9);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(616, 437);
            contenedor.TabIndex = 5;
            // 
            // ofdBuscar
            // 
            ofdBuscar.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(50, 245);
            button2.Name = "button2";
            button2.Size = new Size(118, 42);
            button2.TabIndex = 6;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMascotas
            // 
            txtMascotas.Location = new Point(12, 301);
            txtMascotas.Multiline = true;
            txtMascotas.Name = "txtMascotas";
            txtMascotas.ReadOnly = true;
            txtMascotas.Size = new Size(214, 134);
            txtMascotas.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 458);
            Controls.Add(txtMascotas);
            Controls.Add(button2);
            Controls.Add(contenedor);
            Controls.Add(button1);
            Controls.Add(txtEspecie);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtEspecie;
        private Label label2;
        private Button button1;
        private FlowLayoutPanel contenedor;
        private OpenFileDialog ofdBuscar;
        private Button button2;
        private TextBox txtMascotas;
    }
}
