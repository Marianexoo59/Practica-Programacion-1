using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Personaje
{
    public class RegistroCombate
    {
        public Personaje Personaje1 { get; set; }
        public Personaje Personaje2 { get; set; }
        public int Turnos { get; set; }
        public string Ganador { get; set; }

        public RegistroCombate(Personaje personaje1, Personaje personaje2, string Ganador, int Turnos, int Ganadas)
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
                int dañoA1 = Math.Max(1, Personaje2.Ataque - Personaje1.Defensa);
                int dañoA2 = Math.Max(1, Personaje1.Ataque - Personaje2.Defensa);

                Personaje1.Vida -= dañoA1;
                Personaje2.Vida -= dañoA2;

                Console.WriteLine($"Turno {Turnos + 1}:");
                Console.WriteLine($"{Personaje1.Nombre} recibe {dañoA1} de daño. Vida restante: {Personaje1.Vida}");
                Console.WriteLine($"{Personaje2.Nombre} recibe {dañoA2} de daño. Vida restante: {Personaje2.Vida}\n");

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
