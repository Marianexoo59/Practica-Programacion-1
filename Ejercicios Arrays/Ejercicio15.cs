using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio15
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el numero: ");
                int numero = int.Parse(Console.ReadLine());

                while (numero < 1 || numero > 100)
                {
                    Console.WriteLine("Numero invalido, ingrese nuevamente: ");
                    numero = int.Parse(Console.ReadLine());
                }

            }
        }
    }
}
