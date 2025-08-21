using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas  
{
    internal class Ejercicio14
    {
        public static void Ejecutar()
        {
            List<int> lista = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16 };
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    pares.Add(lista[i]);

                }
                else
                {
                    impares.Add(lista[i]);
                }
            }

            Console.WriteLine("Pares:");
            foreach (int par in pares)
            {
                Console.WriteLine(par);
            }

            Console.WriteLine("\nImpares:");
            foreach (int impar in impares)
            {
                Console.WriteLine(impar);
            }
        }
    }
}
