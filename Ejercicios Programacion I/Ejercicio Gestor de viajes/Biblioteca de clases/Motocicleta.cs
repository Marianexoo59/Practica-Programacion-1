using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Motocicleta : Vehiculo
    {
        public List<Viajes> ListaViajes { get; set; } = new List<Viajes>();
        public Motocicleta(string placa, int kilometraje) : base(placa, kilometraje)
        {

        }

        public override void DistanciaTotal()
        {
            Kilometraje = Kilometraje;
        }

        public override void AgregarViaje(Viajes viaje)
        {
            
        }
    }
}
