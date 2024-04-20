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
    public partial class frmPingPong : Form
    {
        bool movimiento;
        Thread hilo_movimiento;
        public frmPingPong()
        {
            InitializeComponent();
            movimiento = true;
            hilo_movimiento = new Thread(mover_bolita);
            hilo_movimiento.Start();
        }

        //Paso 1. Declaración del delegado
        private delegate void delegado_mover(int x, int y);

        //Paso 2. Instanciar delegado
        private void metodo_mover(int x, int y)
        {
            if (InvokeRequired)
            {
                delegado_mover dm =
                    new delegado_mover(metodo_mover);
                object[] p = new object[] { x, y };
                Invoke(dm, p);
            }
            else
            {
                bolita.Location = new Point(x, y);
            }
        }
        //Paso 3. Realizar acciones
        private void mover_bolita()
        {
            int x = bolita.Location.X;
            int y = bolita.Location.Y;
            Random r = new Random();
            int rx = r.Next(40, 50);
            int ry = r.Next(40, 50);
            bool derecha = true;
            bool subiendo = true;
            while (movimiento)
            {
                if (derecha)
                {
                    x += rx;
                }
                else
                {
                    x -= rx;
                }
                if (subiendo)
                {
                    y -= ry;
                }
                else
                {
                    y += ry;
                }
                metodo_mover(x, y);
                Thread.Sleep(200);

                if (x + bolita.Width > Width)
                {
                    derecha = false;
                    rx = r.Next(40, 50);
                }
                if (x < 0)
                {
                    derecha = true;
                    rx = r.Next(40, 50);
                }

                if (y + bolita.Height > Height)
                {
                    subiendo = true;
                    ry = r.Next(40, 50);
                }
                if (y < 0)
                {
                    subiendo = false;
                    ry = r.Next(40, 50);
                }
            }
        }

        private void frmPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) {
            
                if(barra.Location.X + barra.Width < Width)
                {
                    barra.Location = new Point(
                        barra.Location.X + 30,
                        barra.Location.Y
                        );
                }
            }
            if(e.KeyCode == Keys.Left)
            {
                if(barra.Location.X > 0)
                {
                    barra.Location = new Point(
                        barra.Location.X - 30,
                        barra.Location.Y
                        );
                }
            }
            
        }
    }
}
