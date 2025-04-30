using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio18
    {
        public static void Ejecutar()
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

            for (int i = lista.Count -1 ; i >= 0; i--)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
