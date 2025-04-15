using System.Security.Cryptography;

namespace Ejercicios_Hamming__Collatz_Conjecture_y_Difference_of_Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] variantes = { 'C', 'A', 'G', 'T' };
            char[] adn = new char[7];
            char[] comparacion = new char[7];
            Random random = new Random();
            int distancia = 0;

            for (int i = 0; i < adn.Length; i++)
            {
                adn[i] = variantes[random.Next(variantes.Length)];
            }

            for (int i = 0; i < comparacion.Length; i++)
            {
                comparacion[i] = variantes[random.Next(variantes.Length)];
            }

            Console.WriteLine("El primer arreglo es: " + new string(adn));
            Console.WriteLine("El primer arreglo es: " + new string(comparacion));

            for (int i = 0; i < 7; i++)
            {
                if (adn[i] != comparacion[i])
                {
                    distancia++;
                }
            }
            Console.WriteLine("La distancia hamming entre los 2 arreglos es: " + distancia);
        }
    }
}
