using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class Guerrero : Personaje
    {
        public Guerrero(string nombre, int nivel) : base(nombre, nivel)
        {
            Vida = 150 + (15 * (nivel - 1));
            Ataque = 30;
            Defensa = 15;
        }
  

    public void Atacar(Personaje personajeAtacado)
        {
            Console.WriteLine($"El peresonaje {Nombre} Nivel {Nivel} ataco a {personajeAtacado}");
        }

        public void dañoRecibido(Personaje personajeQueAtaca)
        {
            this.Vida = this.Vida - (personajeQueAtaca.Ataque - this.Defensa);
        }
    }
}
    