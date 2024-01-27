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
            txtNombre.Location = new Point(34, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 27);
            txtNombre.TabIndex = 1;
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(34, 89);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(94, 29);
            btnNombre.TabIndex = 2;
            btnNombre.Text = "Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 426);
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
    }
}
