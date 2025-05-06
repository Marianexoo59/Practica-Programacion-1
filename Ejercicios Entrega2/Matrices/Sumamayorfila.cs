using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    internal class Matriz2
    {
        public static void Ejecutar()
        {
            int[,] matriz = new int[3,3];
            {
                Console.WriteLine("Ingresa los valores para la matriz 3x3");

                for(int filas = 0; filas < 3; filas++)
                {
                    for(int columnas= 0; columnas < 3; columnas++)
                    {
                        Console.Write($"Elemento [{filas + 1},{columnas + 1}]: ");
                        matriz[filas, columnas] = int.Parse(Console.ReadLine());
                    }
                }

                int filaMayorSuma = 0;
                int mayorSuma = 0;

                for(int filas = 0; filas < 3;filas++)
                {
                    int suma = 0;
                    for( int columnas = 0; columnas < 3; columnas++)
                    {
                        suma += matriz[filas, columnas];
                    }

                    if (suma > mayorSuma)
                    {
                        mayorSuma = suma;
                        filaMayorSuma = filas;
                    }

                }

                Console.WriteLine($"\nLa fila con mayor suma es la fila {filaMayorSuma + 1} (suma = {mayorSuma}):");

                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matriz[filaMayorSuma, col] + " ");
                }

            }
        }
    }
}
