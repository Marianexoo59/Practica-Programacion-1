using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public interface IOperacion
    {
        public void Operaciones(int a, int b)
        {

        }
    }

    public class Suma : IOperacion
    {
        public void Operaciones(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine($"La suma de {a} y {b} es: {suma}");
        }
    }

    public class Resta : IOperacion
    {
        public void Operaciones(int a, int b)
        {
            int resta = a - b;
            Console.WriteLine($"La resta entre {a} y {b} es: {resta}");
        }
    }

    public class Multiplicacion : IOperacion
    {
        public void Operaciones(int a, int b)
        {
            int multi = a * b;
            Console.WriteLine($"La multiplicacion de {a} y {b} es: {multi}");
        }
    }

    public class Division : IOperacion
    {
        public void Operaciones(int a, int b)
        {
            int division = a / b;
            Console.WriteLine($"La resta entre {a} y {b} es: {division}");
        }
    }
}
