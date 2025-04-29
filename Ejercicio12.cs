using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio12
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int> {1,2,3,4,4,5,6,7,8,6,6,8,9};


            for(int i = 0; i < numeros.Count; i++)
            {
                for(int j = i+1; j < numeros.Count - 1; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        Console.WriteLine($"El numero duplicado es: {numeros[i]}");
                    }
                }
            }

            

        }
    }
}
