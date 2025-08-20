using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class Mago : Personaje
    {
        public Mago(string nombre, int nivel) : base(nombre, nivel)
        {
            Vida = 100 + (10 * (nivel - 1));
            Ataque = 50;
            Defensa = 5;
        }
        public void Atacar(Personaje personajeAtacado)
        {
            Console.WriteLine($"El peresonaje {Nombre} Nivel: {Nivel} ataco a {personajeAtacado}");
        }

        public void dañoRecibido(Personaje personajeQueAtaca)
        {
            this.Vida = this.Vida - (personajeQueAtaca.Ataque - this.Defensa);
        }
    }
}

