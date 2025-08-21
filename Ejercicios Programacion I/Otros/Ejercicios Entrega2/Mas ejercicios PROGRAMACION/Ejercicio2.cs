using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public abstract class Animal
    {
        public void Reproducirse()
        {

        }
    }
    public class Leon : Animal
    {
        public void Reproducirse()
        {
            Console.WriteLine("El leon tiene reproduccion sexual y deja crias");
        }
    }
    public class Gallina : Animal
    {
        public void Reproducirse()
        {
            Console.WriteLine("La gallina tiene reproduccion sexual y deja huevos");
        }
    }
    public class Pez : Animal
    {
        public void Reproducirse()
        {
            Console.WriteLine("El pez se reproduce mediante huevos");
        }
    }
}
