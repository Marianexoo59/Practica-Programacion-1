using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_listas_entrega2
{
    internal class EjercicioTres
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int>(10);
            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                int aleatorio = random.Next(1, 101);
                numeros.Add(aleatorio);
            }

            Console.WriteLine("Ingrese un valor limite: ");
            int limite = int.Parse(Console.ReadLine());
            for(int i = 0;i < numeros.Count; i++)
            {
                numeros.RemoveAll(num => num < limite);
            }
            
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
    }
}
