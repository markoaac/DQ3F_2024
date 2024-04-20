namespace Unidad_III_EjemploFormularios
{
    partial class frmPingPong
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
            bolita = new PictureBox();
            barra = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)bolita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barra).BeginInit();
            SuspendLayout();
            // 
            // bolita
            // 
            bolita.BackColor = Color.Red;
            bolita.Location = new Point(73, 415);
            bolita.Name = "bolita";
            bolita.Size = new Size(41, 41);
            bolita.TabIndex = 0;
            bolita.TabStop = false;
            // 
            // barra
            // 
            barra.BackColor = Color.Green;
            barra.Location = new Point(4, 524);
            barra.Name = "barra";
            barra.Size = new Size(226, 41);
            barra.TabIndex = 1;
            barra.TabStop = false;
            // 
            // frmPingPong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 567);
            Controls.Add(barra);
            Controls.Add(bolita);
            Name = "frmPingPong";
            Text = "frmPingPong";
            KeyDown += frmPingPong_KeyDown;
            ((System.ComponentModel.ISupportInitialize)bolita).EndInit();
            ((System.ComponentModel.ISupportInitialize)barra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox bolita;
        private PictureBox barra;
    }
}