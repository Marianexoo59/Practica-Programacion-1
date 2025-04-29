using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio11
    {
        public static void Ejecutar()
        {
            List<string> nombres = new List<string>();
            List<List<double>> todasLasNotas = new List<List<double>>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre del estudiante {i + 1}: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre); // Línea añadida

                List<double> notas = new List<double>();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese la nota N {j + 1}");
                    double nota = double.Parse(Console.ReadLine());
                    notas.Add(nota);
                }
                todasLasNotas.Add(notas);
            }

            Console.WriteLine("Promedios: ");

            for (int i = 0; i < nombres.Count; i++)
            {
                double promedio = todasLasNotas[i].Average();
                Console.WriteLine($"{nombres[i]} el promedio es: {promedio}"); // Línea corregida
            }
        }
    }
}


