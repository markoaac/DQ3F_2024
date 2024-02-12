using Unidad_II_dll;
namespace Unidad_II_Proyecto
{
    public partial class Form1 : Form
    {
        Contenedor contenedor;
        int index;
        public Form1()
        {
            InitializeComponent();
            contenedor = new Contenedor();
            index = -1;
        }

        private void setMascotasGrid()
        {
            this.dgvMascotas.DataSource = null;
            this.dgvMascotas.DataSource =
                contenedor.getMascotas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mascota m = new Mascota();
            m.Nombre = txtNombre.Text;
            m.Tipo = txtTipo.Text;
            contenedor.Agregar(m);
            setMascotasGrid();
            MessageBox.Show("Mascota agregada");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(index == -1)
            {
                MessageBox.Show("No hay selección");
            }
            else
            {
                Mascota m = contenedor.Eliminar(index);
                MessageBox.Show("Mascota: " + m.Nombre);
                setMascotasGrid();
                index = -1;
            }
        }

        private void dgvMascotas_Click(object sender, EventArgs e)
        {
            index = dgvMascotas.CurrentCell.RowIndex;
        }
    }
}
