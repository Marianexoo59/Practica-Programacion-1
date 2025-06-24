using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio13
    {
        public static void Ejecutar()
        {
            List<string> palabras = new List<string> { "perros", "gatos", "ortinotrrinco", "elefante", "auto" };

            for (int i = 0; i < palabras.Count; i++)
            {
                    if (palabras[i].Length > 5)
                    {
                        Console.WriteLine(palabras[i]);
                    }
                
            }
        }
    }
}
