namespace Unidad_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            MessageBox.Show(nombre);
        }

        private void btnAgregarBotones_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "0";
            btn.Tag = 0;
            btn.Size = new Size(100, 50);
            btn.Click += b_click;
            contenedorBotones.Controls.Add(btn);

        }

        private void btnAgregarImagenes_Click(object sender, EventArgs e)
        {
            
            PictureBox pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.Image = Image.FromFile("C:\\Pruebas\\mouse.png");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Click += pb_click;
            contenedorImagenes.Controls.Add(pb);
        }

        private void b_click(object s, EventArgs e)
        {
            //MessageBox.Show("Hola");
            Button b1 = (Button)s;
            int aux = Convert.ToInt32(b1.Tag);
            aux++;
            b1.Text = aux.ToString();
            b1.Tag = aux;
        }

        private void pb_click(object s, EventArgs e)
        {
            MessageBox.Show("Soy un Picture Box");
        }
    }
}
