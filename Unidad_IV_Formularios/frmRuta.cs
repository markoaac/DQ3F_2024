using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_II_dll;

namespace Unidad_IV_Formularios
{
    public partial class frmRuta : Form
    {
        MongoClient cliente; // información del servidor
        IMongoDatabase db; //Base de datos
        IMongoCollection<Paquete> paquetes; //Colección llamada paquetes
        IMongoCollection<Ruta> rutas;
        List<Paquete> lista_paquete;

        public frmRuta(List<Paquete> lista_paquete)
        {
            InitializeComponent();
            this.lista_paquete = lista_paquete;
            cliente = new MongoClient("mongodb://localhost:27017");
            db = cliente.GetDatabase("BDMensajeria");
            paquetes = db.GetCollection<Paquete>("Paquetes");
            rutas = db.GetCollection<Ruta>("Rutas");
            dgvPaquetes.DataSource = lista_paquete;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ruta r = new Ruta();
            string fecha = DateTime.Now.ToLongDateString();
            string hora = DateTime.Now.ToLongTimeString();  
            r.Repartidor = txtRepartidor.Text;
            r.Fecha = fecha + " -- " + hora;
            r.Paquetes = lista_paquete;
            rutas.InsertOne(r);
            foreach(Paquete pt in lista_paquete)
            {
                pt.Estatus = "Entregado";
                paquetes.ReplaceOne(paquete => paquete.Id == pt.Id, pt);
            }
            Dispose();
        }
    }
}
