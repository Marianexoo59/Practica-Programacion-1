using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class Arquero : Personaje
    {
        private static Random rnd = new Random();

        public Arquero(string nombre, int nivel) : base(nombre, nivel)
        {
            Vida = 120 + (15 * (nivel - 1));
            Ataque = 25;
            Defensa = 15;
        }

        public void dañoRecibido(Personaje personajeQueAtaca)
        {
            this.Vida = this.Vida - (personajeQueAtaca.Ataque - this.Defensa);
        }
        public override int Atacar(Personaje personajeAtacado)
        {
            int daño = rnd.Next(1, 101) <= 25 ? Ataque * 2 : Ataque;
            personajeAtacado.RecibirDaño(daño);
            return daño;
        }
    }
}
