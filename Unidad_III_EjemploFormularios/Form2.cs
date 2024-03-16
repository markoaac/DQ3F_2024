using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_III_EjemploFormularios
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Paso 1. Declarar el delegado
        //NOTA: definir parámetros (1)
        //según el proceso
        private delegate void delegado_agregar(int n);

        //Paso 2. Llamar al delegado
        //Crear un método para instanciaar el delegado
        //NOTA: el siguiente método DEBE tener los mismos
        //parámetros que el delegado
        private void llamar_delegado_agregar(int w)
        {
            //La primera vez se solicita el recurso
            //sin éxito, lanzo el delegado
            if (InvokeRequired)
            {
                delegado_agregar da = new
                    delegado_agregar(llamar_delegado_agregar);
                //object[] p = new object[1];
                //p[0] = w;

                object[] p = new object[] { w };
                Invoke(da, p);
            }
            else
            {
                //ahora si ya tengo acceso
                barra.Value = w;
                if(barra.Value == 100)
                {
                    button1.Enabled = true;
                }
            }

        }

        //Paso 3. Utilizar el método agregado anteriormente
        //con el objetivo (llenar un progress bar) hasta 100
        //NOTA: el objetivo depende del proceso a ejecutar
        //NOTA 2: El subproceso (hilo) no accede al GUI
        //(Interfaz gráfica de Usuario), el que accede
        //es el método que tiene el delegado
        private void LlenarLista()
        {
            for (int i = 1; i <= 100; i++)
            {
                llamar_delegado_agregar(i);
                Thread.Sleep(100);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread hilo = new Thread(LlenarLista);
            hilo.Start();
        }
    }
}
