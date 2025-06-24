using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Matriz1
    {
        public static void Ejecutar()
        {
            int[,] matriz = new int[3, 3];

            Console.WriteLine("Ingresa los valores de la matriz 3x3:");

            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"Elemento [{fila + 1},{col + 1}]: ");
                    matriz[fila, col] = int.Parse(Console.ReadLine());
                }
            }

            // Calcular y mostrar la suma de cada fila
            Console.WriteLine("\nSuma de cada fila:");
            for (int fila = 0; fila < 3; fila++)
            {
                int sumaFila = 0;
                for (int col = 0; col < 3; col++)
                {
                    sumaFila += matriz[fila, col];
                }
                Console.WriteLine($"Fila {fila + 1}: {sumaFila}");
            }
        }
    }
}
