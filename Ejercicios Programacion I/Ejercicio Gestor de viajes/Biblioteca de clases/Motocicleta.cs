using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    internal class Motocicleta : Vehiculo
    {
        public Motocicleta(int Placa, int Kilometraje, int Viajes, int Capacidad) : base(Placa, Kilometraje, Viajes, Capacidad)
        {
            
        }

        public override void DistanciaTotal()
        {
            Kilometraje = Kilometraje;
        }

        public override void AgregarViaje()
        {
            
        }
    }
}
