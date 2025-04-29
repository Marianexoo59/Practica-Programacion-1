using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese el numero: ");

            int numero = int.Parse(Console.ReadLine());

            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            for (int i = 0; i < arreglo.Length; i++)
            {
                if (numero == arreglo[i])
                {
                    Console.WriteLine("El numero esta en el arreglo");
                    return;
                }
                
            }
            Console.WriteLine("El numero no esta en el arreglo: ");
        }
    }
}
