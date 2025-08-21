using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Array1
    {
        public static void Ejecutar()
        {
            int[] numeros = new int[100];
            Random random = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 101); 
            }

            int mayor = numeros.Max(); 
            int menor = numeros.Min();

            Console.WriteLine($"El número mayor es: {mayor}, y el número menor es: {menor}");

        }
    }
}
