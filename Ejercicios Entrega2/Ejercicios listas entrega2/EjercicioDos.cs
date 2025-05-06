using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_listas_entrega2
{
    internal class EjercicioDos
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int>(7);

            Console.WriteLine("Ingrese que numeros quiere en la lista: ");

            for(int i = 0; i < 7; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                numeros.Add(nums);
            }

            Console.WriteLine("Ingrese el número a buscar:");
            int buscado = int.Parse(Console.ReadLine());

            if (numeros.Contains(buscado))
            {
                Console.WriteLine("El número está dentro de la lista");
            }
            else
            {
                Console.WriteLine("El número ingresado no está dentro de la lista");
            }
        }
    }
}
