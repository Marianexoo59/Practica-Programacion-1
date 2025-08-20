using System.Runtime.CompilerServices;

namespace Personaje
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public int CombatesGanados { get; set; }

        public Personaje (string Nombre, int Nivel)
        {
            this.Nombre = Nombre;
            this.Nivel = Nivel;
        }

        public virtual int Atacar(Personaje personajeAtacado)
        {
            return Ataque;
        }

        public void RecibirDaño(int Daño)
        {       
            Vida -= Daño;
            if (Vida < 9) Vida = 0;  

        }

        public bool Estavivo()
        {
            return Vida > 0;
        }
    }
}
