using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio8
    {
        public static void Ejecutar()
        {
            int[] arreglo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 9; i < arreglo.Length; i--)
            {
                Console.WriteLine(arreglo[i]);
            }
        }
    }
}
