using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio10
    {
        public static void Ejecutar()
        {
            List<int> list = new List<int> {1, -2, 3, -4, 5, -6, 7, -8, 9, -10};

            for (int i = list.Count - 1; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                }
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
