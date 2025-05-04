using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Array3
    {
        public static void Ejecutar()
        {
            int[] numeros = { -7, 3, 0, -2, 5, 0, -10, 8, -1, 10 };
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    ceros++;
                }
                else if (numeros[i] > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }

            Console.WriteLine($"En el arreglo hay {positivos} positivos, {negativos} negativos y {ceros} ceros.");
        }
    }
}
