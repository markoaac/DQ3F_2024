using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_IV_Formularios
{
    public partial class frmRuta : Form
    {
        List<Paquete> lista_paquete;
        public frmRuta(List<Paquete> lista_paquete)
        {
            InitializeComponent();
            this.lista_paquete = lista_paquete;
        }
    }
}
