using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio5
    {
        public static void Ejecutar()
        {
            int[] arreglo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0;i < arreglo.Length; i++)
            {
                if (arreglo[i] % 2 == 0)
                {
                    Console.WriteLine("Los numeros pares son: " + arreglo[i]);
                }
            }
        }
    }
}
