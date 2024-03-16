using Unidad_II_dll;
namespace Unidad_II_Control
{
    public partial class ucMascota : UserControl
    {
        public Mascota Mascota { get; set; }

        public ucMascota()
        {
            InitializeComponent();
        }

        public void setInfoMascota()
        {
            pbMascota.Image = Image.FromFile(Mascota.Foto);
            lblNombre.Text = Mascota.Nombre;
            lblTipo.Text = Mascota.Tipo;
            pbMascota.Click += PbMascota_Click;
        }

        private void PbMascota_Click(object? sender, EventArgs e)
        {
            if(ofdCambiar.ShowDialog() == DialogResult.OK)
            {
                pbMascota.Image = 
                        Image.FromFile(ofdCambiar.FileName);
                Mascota.Foto = ofdCambiar.FileName;
            }
        }
    }
}
