using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio1
    {
        public static void Ejecutar()
        {
            int[] arreglo = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma = suma + arreglo[i];
            }
            Console.WriteLine("La suma de los numeros es: " + suma);
        }
    }
}
