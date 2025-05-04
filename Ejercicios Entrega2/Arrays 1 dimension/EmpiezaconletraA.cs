using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Array2
    {
        public static void Ejecutar()
        {
            string[] nombres = new string[8];
            int contadorA = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre: {i + 1} ");
                nombres[i] = Console.ReadLine();

                if ((nombres[i][0] == 'A' || nombres[i][0] == 'a'))
                {
                    contadorA++;
                }
            }

            Console.WriteLine($"La cantidad de nombres que empiezan con la letra A o a son: {contadorA}");
        }
    }
}
