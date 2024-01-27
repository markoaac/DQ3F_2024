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
            btn.Text = "Botón";
            btn.Size = new Size(100, 50);
            //btn.Click =
            contenedorBotones.Controls.Add(btn);

        }

        private void btnAgregarImagenes_Click(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.Image = Image.FromFile("C:\\Pruebas\\mouse.png");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            //pb.Click =
            contenedorImagenes.Controls.Add(pb);
        }
    }
}
