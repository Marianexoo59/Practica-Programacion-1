using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_arreglos_y_listas
{
    internal class Ejercicio17
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int> { 1, 1, 2, 2, 3, 3, 3,4,4,4,4 };
            int repeticiones = 0;
            int mas_repetido = 0;

            for (int i = 0; i < numeros.Count; i++)
            {
                repeticiones = 0;  // Reiniciar el contador de repeticiones para cada número

                for (int j = 0; j < numeros.Count; j++)
                {
                    if (numeros[i] == numeros[j])
                        repeticiones++;
                }

                if (repeticiones > mas_repetido)  // Se compara entre el numero que se repitio y el supuesto mas repetido que en la primera iteracion es 0
                {
                    mas_repetido = numeros[i];  // El valor mas repetido se asigna a un elemento de la lista numeros
                }
            }

            Console.WriteLine($"El número que más se repite es el: {mas_repetido}");
        }
    }
}
