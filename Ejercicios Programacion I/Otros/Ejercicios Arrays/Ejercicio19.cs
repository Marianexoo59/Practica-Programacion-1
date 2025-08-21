using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio19
    {
        public static void Ejecutar()
        {
            List<string> lista = new List<string> { "Ana", "Sara", "Luz", "Olivia", "Yair", "Jamal", "Ester" };
            List<string> vocales = new List<string> { "A", "E", "I", "O", "U" };

            for (int i = 0; i < lista.Count; i++)
            {
                if (vocales.Contains(lista[i][0].ToString()))  // Comparar el primer carácter
                {
                    Console.WriteLine(lista[i] + " empieza con una vocal.");
                }
            }
        }
    }
}
