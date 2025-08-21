using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ejemplo_clases
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public abstract void hacerSonido();
    }

    public class Perro : Animal
    {
        public override void hacerSonido()
        {
            Console.WriteLine("waw");
        }
    }

    public class Gato : Animal
    {
        public override void hacerSonido()
        {
            Console.WriteLine("Miau");
        }
    }
}
