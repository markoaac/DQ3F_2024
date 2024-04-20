namespace Unidad_IV_Formularios
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
            txtDireccion = new TextBox();
            txtComprador = new TextBox();
            label2 = new Label();
            txtPeso = new TextBox();
            label3 = new Label();
            txtVendedor = new TextBox();
            label4 = new Label();
            txtPrioridad = new TextBox();
            label5 = new Label();
            btnGuardar = new Button();
            dgvPaquetes = new DataGridView();
            btnActualizar = new Button();
            btnEliminar = new Button();
            menuStrip1 = new MenuStrip();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(10, 63);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 0;
            label1.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtDireccion.Location = new Point(10, 97);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(337, 38);
            txtDireccion.TabIndex = 1;
            // 
            // txtComprador
            // 
            txtComprador.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtComprador.Location = new Point(10, 181);
            txtComprador.Name = "txtComprador";
            txtComprador.Size = new Size(337, 38);
            txtComprador.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(10, 147);
            label2.Name = "label2";
            label2.Size = new Size(135, 31);
            label2.TabIndex = 2;
            label2.Text = "Comprador";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPeso.Location = new Point(10, 272);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(337, 38);
            txtPeso.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(10, 238);
            label3.Name = "label3";
            label3.Size = new Size(63, 31);
            label3.TabIndex = 4;
            label3.Text = "Peso";
            // 
            // txtVendedor
            // 
            txtVendedor.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtVendedor.Location = new Point(10, 360);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(337, 38);
            txtVendedor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(10, 326);
            label4.Name = "label4";
            label4.Size = new Size(117, 31);
            label4.TabIndex = 6;
            label4.Text = "Vendedor";
            // 
            // txtPrioridad
            // 
            txtPrioridad.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPrioridad.Location = new Point(10, 436);
            txtPrioridad.Name = "txtPrioridad";
            txtPrioridad.Size = new Size(337, 38);
            txtPrioridad.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(10, 402);
            label5.Name = "label5";
            label5.Size = new Size(114, 31);
            label5.TabIndex = 8;
            label5.Text = "Prioridad";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(78, 480);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 40);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // dgvPaquetes
            // 
            dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaquetes.Location = new Point(426, 45);
            dgvPaquetes.Name = "dgvPaquetes";
            dgvPaquetes.RowHeadersWidth = 51;
            dgvPaquetes.Size = new Size(715, 436);
            dgvPaquetes.TabIndex = 11;
            dgvPaquetes.Click += dgvPaquetes_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(10, 528);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(161, 40);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(186, 528);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 40);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1166, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { limpiarToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(82, 24);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.L;
            limpiarToolStripMenuItem.Size = new Size(276, 26);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(548, 506);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 15;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(781, 506);
            button2.Name = "button2";
            button2.Size = new Size(161, 40);
            button2.TabIndex = 16;
            button2.Text = "Generar ruta";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 580);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvPaquetes);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrioridad);
            Controls.Add(label5);
            Controls.Add(txtVendedor);
            Controls.Add(label4);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(txtComprador);
            Controls.Add(label2);
            Controls.Add(txtDireccion);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDireccion;
        private TextBox txtComprador;
        private Label label2;
        private TextBox txtPeso;
        private Label label3;
        private TextBox txtVendedor;
        private Label label4;
        private TextBox txtPrioridad;
        private Label label5;
        private Button btnGuardar;
        private DataGridView dgvPaquetes;
        private Button btnActualizar;
        private Button btnEliminar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}
