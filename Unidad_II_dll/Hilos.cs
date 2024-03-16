using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_II_dll
{
    public class Hilos
    {
        public void ImprimeX()
        {
            for (int i = 1; i < 1000; i++)
            {
                Console.Write("X");
            }
        }
        public void ImprimeY()
        {
            for(int i = 1; i < 1000;i++)
            {
                Console.Write("Y");
            }
        }
    }
}
