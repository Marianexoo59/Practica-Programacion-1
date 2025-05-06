using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_listas_entrega2
{
    internal class EjercicioUno
    {
        public static void Ejecutar()
        {
            List<int>[] numeros = new List<int>[5];
            int suma = 0;
            Console.WriteLine("Ingrese los numeros a sumar: ");

            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = new List<int>();
                int nums = int.Parse(Console.ReadLine());
                numeros[i].Add(nums);
            }

            for(int i = 0;i < numeros.Length; i++)
            {
                suma += numeros[i][0];
            }

            Console.WriteLine($"La suma de los elementos de la lista es: {suma}");
        }
    }
}
