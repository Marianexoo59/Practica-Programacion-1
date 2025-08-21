using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ejemplo_clases
{
        public class Vehiculo()
        {
            public string Marca {  get; set; }
            public virtual void Conducir()
        {
            Console.WriteLine("Conducir un vehiculo generico");
        }
        }

        public class Automovil : Vehiculo
        {
        public Automovil(int puertas)
        {
            this.puertas = puertas;
            Console.WriteLine("La cantidad de puertas del automovil es de: " + puertas);
        }
            public int puertas { get; set; }
        public override void Conducir()
        {
            Console.WriteLine("Esta conduciendo un automovil");
        }
    }

        public class Camion : Vehiculo
    {
        public Camion (int carga)
        {
            this.carga = carga;
            Console.WriteLine($"La carga que admite el camion es de: " + carga);
        }
        public int carga { get; set; }
        public override void Conducir()
        {
            Console.WriteLine("Esta conduciendo un camion");
        }


    }

}
