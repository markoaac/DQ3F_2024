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
    }
}
