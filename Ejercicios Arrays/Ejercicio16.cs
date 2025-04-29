using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio16
    {
        public static void Ejecutar()
        {
            int[] numeros = new int[]{ 1, 2, 3, 4, 5, 6, 7, 9, 10,11 };
            int multiplicacion = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"La tabla del {i+2} es: ");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(numeros[i] *j);
                }
            }
        }
    }
}
