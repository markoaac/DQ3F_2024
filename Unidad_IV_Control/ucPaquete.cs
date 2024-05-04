using Unidad_II_dll;
namespace Unidad_IV_Control
{
    public partial class ucPaquete : UserControl
    {
        public Paquete PaqueteControl { get; set; }
        public ucPaquete()
        {
            InitializeComponent();
        }

        public void ActualizarInfo()
        {
            lblComprador.Text = PaqueteControl.Comprador;
            lblDireccion.Text = PaqueteControl.Direccion;
            lblEstatus.Text = PaqueteControl.Estatus;
            lblId.Text = PaqueteControl.Id;
            lblIdPaquete.Text = PaqueteControl.IdPaquete.ToString();
            lblPeso.Text = PaqueteControl.Peso.ToString();
            lblPrioridad.Text = PaqueteControl.Prioridad;
            lblVendedor.Text = PaqueteControl.Vendedor;
        }
    }
}
