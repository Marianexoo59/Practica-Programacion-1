using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio2
    {
        public static void Ejecutar()
        {
            int[] calificaciones = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int suma = 0;
            double promedio = 0;
            for (int  i = 0; i < calificaciones.Length; i++)
            {
                suma += calificaciones[i];
            }
            promedio = suma / calificaciones.Length;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
