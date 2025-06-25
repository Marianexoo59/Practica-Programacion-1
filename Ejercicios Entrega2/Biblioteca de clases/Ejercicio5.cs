using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public abstract class Electrodomestico
    {
        public void Encender(string mensaje)
        {
            Console.WriteLine($"El electrodomestico esta {mensaje}");
        }
    }
    public class Licuadora : Electrodomestico
    {
        public void Encender(string mensaje)
        {
            Console.WriteLine($"El electrodomestico esta {mensaje}");
        }
    }
    public class Microondas : Electrodomestico
    {
        public void Encender(string mensaje)
        {
            Console.WriteLine($"El electrodomestico esta {mensaje}");
        }
    }
    public class Heladera : Electrodomestico
    {
        public void Encender(string mensaje)
        {
            Console.WriteLine($"El electrodomestico esta {mensaje}");
        }
    }
}
