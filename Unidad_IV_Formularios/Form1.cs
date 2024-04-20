using MongoDB.Driver;
namespace Unidad_IV_Formularios
{
    public partial class Form1 : Form
    {
        MongoClient cliente; // información del servidor
        IMongoDatabase db; //Base de datos
        IMongoCollection<Paquete> paquetes; //Colección llamada paquetes
        string _idpaquete;
        string _idmongo;
        public Form1()
        {
            InitializeComponent();
            cliente = new MongoClient("mongodb://localhost:27017");
            db = cliente.GetDatabase("BDMensajeria");
            paquetes = db.GetCollection<Paquete>("Paquetes");
            Consultar();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            _idpaquete = "";
            _idmongo = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete();
            p.IdPaquete = GenerarID();
            p.Peso = decimal.Parse(txtPeso.Text);
            p.Direccion = txtDireccion.Text;
            p.Comprador = txtComprador.Text;
            p.Vendedor = txtVendedor.Text;
            p.Prioridad = txtPrioridad.Text;
            paquetes.InsertOne(p);
            Consultar();
            Limpiar();
        }

        private void Consultar()
        {
            List<Paquete> lista = paquetes.Find(p => true).ToList();
            dgvPaquetes.DataSource = lista;
        }

        private string GenerarID()
        {
            string cadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random r = new Random();

            string res = "";
            for (int i = 0; i < 5; i++)
            {
                int numeroAleatorio = r.Next(0, cadena.Length - 1);
                res += cadena[numeroAleatorio];
            }
            return res;
        }

        private void Limpiar()
        {
            txtComprador.Clear();
            txtDireccion.Clear();
            txtPeso.Clear();
            txtPrioridad.Clear();
            txtVendedor.Clear();
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void dgvPaquetes_Click(object sender, EventArgs e)
        {
            string? oid = dgvPaquetes[0,
                dgvPaquetes.CurrentCell.RowIndex].Value.ToString();
            Paquete p = paquetes.Find(p => p.Id == oid).FirstOrDefault();
            if (p != null)
            {
                txtComprador.Text = p.Comprador;
                txtDireccion.Text = p.Direccion;
                txtPeso.Text = p.Peso.ToString();
                txtPrioridad.Text = p.Prioridad;
                txtVendedor.Text = p.Vendedor;
                _idmongo = p.Id;
                _idpaquete = p.IdPaquete;
                btnGuardar.Enabled = false;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Paquete no encontrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Seguro que desea eliminar {_idpaquete}?",
                "Confirme", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                paquetes.DeleteOne(p => p.Id == _idmongo);
                Limpiar();
                Consultar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete();
            p.Id = _idmongo;
            p.IdPaquete = _idpaquete;
            p.Prioridad = txtPrioridad.Text;
            p.Comprador = txtComprador.Text;
            p.Peso = decimal.Parse(txtPeso.Text);
            p.Vendedor = txtVendedor.Text;
            p.Direccion = txtDireccion.Text;
            paquetes.ReplaceOne(x => x.Id == _idmongo, p);
            Consultar();
            Limpiar();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            Consultar();
        }
    }
}
