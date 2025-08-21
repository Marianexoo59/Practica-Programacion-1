using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta(string placa, int Kilometraje, int Capacidad) : base(placa, Kilometraje)
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
