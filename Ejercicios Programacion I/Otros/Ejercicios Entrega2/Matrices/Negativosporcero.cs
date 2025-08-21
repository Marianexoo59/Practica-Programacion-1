using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Matriz3
    {
        public static void Ejecutar()
        {
            // Definir la matriz 3x3
            int[,] matriz = new int[3, 3]
            {
            { -1, 2, -3 },
            { 4, -5, 6 },
            { -7, 8, -9 }
            };

            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz.GetLength(1); columnas++)
                {
                    if (matriz[filas, columnas] < 0)
                    {
                        matriz[filas, columnas] = 0;
                    }
                }
            }


            Console.WriteLine("La nueva matriz es:");
            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < matriz.GetLength(1); columnas++)
                {
                    Console.Write(matriz[filas, columnas] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
