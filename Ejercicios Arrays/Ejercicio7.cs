using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio7
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingresar nombres");
            List <string> nombres = new List <string> ();
            nombres.Add(Console.ReadLine());
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine("Ingrese el nombre a agregar o fin si no quiere agregar mas nombres:");
                string palabra = Console.ReadLine ();

                if (palabra == "fin")
                {
                    break;
                }
                nombres.Add(palabra);
            }
        }

    }
}
