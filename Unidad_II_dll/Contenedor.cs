using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_II_dll
{
    public class Contenedor
    {
        List<Mascota> mascotas;
        public Contenedor()
        {
            mascotas = new List<Mascota>();
        }

        public void Agregar(Mascota m)
        {
            mascotas.Add(m);
        }

        public object Agregar2(Mascota m)
        {
            try
            {
                mascotas.Add(m);
                //return true;
                return "Mascota agregada";
            }
            catch (Exception)
            {
                //return false;
                return "Error al guardar mascota";
            }
        }

        public List<Mascota> getMascotas()
        {
            return mascotas;
        }

        public Mascota Eliminar(int index)
        {
            Mascota mascota = mascotas[index];
            mascotas.RemoveAt(index);
            return mascota;
        }
    }
}
