using Unidad_II_Control;
using Unidad_II_dll;
namespace Unidad_II_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.BlueViolet;
            label1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdBuscar.ShowDialog() == DialogResult.OK)
            {
                Mascota m = new Mascota();
                m.Nombre = txtNombre.Text;
                m.Tipo = txtEspecie.Text;
                m.Foto = ofdBuscar.FileName;
                ucMascota control = new ucMascota();
                control.Mascota = m;
                control.setInfoMascota();
                contenedor.Controls.Add(control);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int cont = 0;
            //for(int i = 0; i < contenedor.Controls.Count; i++)
            //{
            //    ucMascota temp = (ucMascota)contenedor.Controls[i];
            //    MessageBox.Show(temp.Mascota.Nombre);
            //    cont++;
            //}
            //MessageBox.Show("Total de mascotas: " + cont);
            string mascotas = "";
            foreach(Control control in contenedor.Controls)
            {
                ucMascota temp = (ucMascota)control;
                mascotas += temp.Mascota.Nombre + Environment.NewLine;
            }
            txtMascotas.Text = mascotas;
        }
    }
}
