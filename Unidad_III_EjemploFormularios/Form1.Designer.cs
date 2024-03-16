namespace Unidad_III_EjemploFormularios
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            txtResultado = new TextBox();
            pbTiempo = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            cuadro = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)cuadro).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 42);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Saludar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(313, 42);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Ciclo For";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(126, 87);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(231, 27);
            txtResultado.TabIndex = 2;
            // 
            // pbTiempo
            // 
            pbTiempo.Location = new Point(43, 140);
            pbTiempo.Name = "pbTiempo";
            pbTiempo.Size = new Size(730, 54);
            pbTiempo.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // cuadro
            // 
            cuadro.BackColor = Color.Yellow;
            cuadro.Location = new Point(43, 238);
            cuadro.Name = "cuadro";
            cuadro.Size = new Size(83, 89);
            cuadro.TabIndex = 4;
            cuadro.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(43, 333);
            button3.Name = "button3";
            button3.Size = new Size(83, 29);
            button3.TabIndex = 5;
            button3.Text = "Iniciar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(cuadro);
            Controls.Add(pbTiempo);
            Controls.Add(txtResultado);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cuadro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtResultado;
        private ProgressBar pbTiempo;
        private System.Windows.Forms.Timer timer1;
        private PictureBox cuadro;
        private Button button3;
    }
}
