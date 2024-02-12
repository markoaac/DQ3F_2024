using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_I
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnos = new List<Alumno>();
            Alumno a1 = new Alumno();
            a1.Nombre = "Hugo";
            a1.Carrera = "Sistemas";
            a1.NoControl = "20TE0001";
            a1.Inscrito = true;
            a1.Semestre = 4;
            Alumno a2 = new Alumno();
            a2.Nombre = "María";
            a2.Carrera = "Informática";
            a2.NoControl = "20TE0002";
            a2.Inscrito = bool.Parse("false");
            a2.Semestre = int.Parse("6");
            alumnos.Add(a1);
            alumnos.Add(a2);

            foreach(Alumno a in alumnos)
            {
                MessageBox.Show(a.Nombre);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = alumnos;
            
        }
    }
}
