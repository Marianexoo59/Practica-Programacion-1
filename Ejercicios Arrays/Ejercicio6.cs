using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio6
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese el numero a verificar si se repite: ");
            int verificacion = int.Parse(Console.ReadLine());
            List <int> numero = new List<int>{1, 2, 5, 7, 8, 9, 4, 5, 5};
            
            int contador = 0;
            for (int i = 0; i < numero.Count; i++)
            {
                if (numero[i] == verificacion)
                {
                    contador++;
                }
            }
            Console.WriteLine($"El numero {verificacion}, aparece {contador} veces");
        }
    }
}
