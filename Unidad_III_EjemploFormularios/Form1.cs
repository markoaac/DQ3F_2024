using System.Threading;
namespace Unidad_III_EjemploFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola :D");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(cicloFor);
            hilo.Start();
        }

        private void cicloFor()
        {
            for (long i = 1; i <= 50000000; i++)
            {

            }
            //MessageBox.Show("Ciclo terminado");
            txtResultado.Text = "Ciclo terminado";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTiempo.Value += 1;
            if (pbTiempo.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void IncrementarPB()
        {
            int i = 1;
            while (i < pbTiempo.Maximum + 1)
            {
                pbTiempo.Value = i;
                i++;
                Thread.Sleep(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread hilo = new Thread(IncrementarPB);
            hilo.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(MoverCuadro);
            hilo.Start();
        }

        private void MoverCuadro()
        {
            int x = cuadro.Location.X;
            int y = cuadro.Location.Y;
            int z = x + 100;
            while (x < z)
            {
                cuadro.Location = new Point(x, y);
                x += 5;
                Thread.Sleep(200);
            }
        }
    }
}
