using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio9
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            int max = 0;
            int min = numeros[0];
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] < min)
                {
                    min = numeros[i];
                }
            }
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > max)
                {
                    {
                        max = numeros[i];
                    }

                }
            }
            Console.WriteLine($"El numero maximo es: {max}, el numero minimo es: {min}");
        }
    }
}