using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio4
    {
        public static void Ejecutar()
        {
            List<int>  numeros = new List<int>();
            int limite = 5;

            for (int i = 0; i < limite; i++)
            {
                Console.WriteLine("Ingrese el numero: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
