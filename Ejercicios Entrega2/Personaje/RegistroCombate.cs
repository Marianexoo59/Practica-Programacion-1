using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class RegistroCombate
    {
        public Personaje Personaje1 { get; set; }
        public Personaje Personaje2 { get; set; }
        public int Turnos { get; set; }
        public string Ganador { get; set; }

        public RegistroCombate(string Personaje1, string Personaje2, string Ganador, int Turnos, int Ganadas)
        {
            Personaje1 = Personaje1;
            Personaje2 = Personaje2;
            Ganador = Ganador;
            Turnos = Turnos;
            Turnos = 0;
            Ganador = "";
        }

        public void Combate()
        {
            while (Personaje1.Vida > 0 && Personaje2.Vida > 0)
            {
                Personaje1.Atacar(Personaje2);
                Personaje1.Vida = Personaje1.Vida - (Personaje1.Defensa - Personaje2.Ataque);

                Personaje2.Atacar(Personaje1);
                Personaje2.Vida = Personaje2.Vida - (Personaje2.Defensa - Personaje1.Ataque);

                Console.WriteLine($"Puntos de vida restantes de {Personaje1}: {Personaje1.Vida} \n {Personaje2}: {Personaje2.Vida}");
                Console.WriteLine($"Cantidad de turnos: {Turnos}");
                Turnos++;
            }

            if (Personaje1.Vida > 0)
            {
                Ganador = Personaje1.Nombre;
                Personaje1.CombatesGanados++;
            }
            else
            {
                Ganador = Personaje2.Nombre;
                Personaje2.CombatesGanados++;
            }
            Console.WriteLine($"El ganador es: {Ganador}");

        }
    }
}
