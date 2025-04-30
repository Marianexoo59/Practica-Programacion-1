using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio20
    {
        public static void Ejecutar()
        {
            List<string> lista = new List<string> { "Mariano", "Juani", "Franco" };
            int voto1 = 0;
            int voto2 = 0;
            int voto3 = 0;
            int votos = 0;

            while (votos < 1)
            {
                Console.WriteLine("Candidatos:");
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {lista[i]}");
                }

                Console.Write("\nIngrese su primer voto (1, 2 o 3): ");
                voto1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese su segundo voto (1, 2 o 3): ");
                voto2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese su tercer voto (1, 2 o 3): ");
                voto3 = int.Parse(Console.ReadLine());

                if (voto1 == 0)
                {
                    Console.WriteLine("Ese candidato no existe");
                    break;
                }
            }
            Console.WriteLine($"Primer voto: {lista[voto1 - 1]}");
            Console.WriteLine($"Segundo voto: {lista[voto2 - 1]}");
            Console.WriteLine($"Tercer voto: {lista[voto3 - 1]}");
        }
    }
}
