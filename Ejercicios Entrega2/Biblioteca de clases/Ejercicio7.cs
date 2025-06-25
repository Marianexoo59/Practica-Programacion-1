using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public abstract class Personaje
    {
        public void Atacar()
        {

        }
    }
    public class Guerrero : Personaje
    {
        public void Atacar(string nombre)
        {
            Console.WriteLine($"El guerrero {nombre} atacó con arma.");
        }
    }
    public class Mago : Personaje
    {
        public void Atacar(string nombre)
        {
            Console.WriteLine($"{nombre}, el mago atacó con hechizo.");

        }
    }
    public class Arquero : Personaje
    {
        public void Atacar(string nombre)
        {
            Console.WriteLine($"El arquero {nombre} atacó con flechas.");

        }
    }
}
