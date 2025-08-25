using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Furgoneta : Vehiculo
    {
        public int Capacidad { get; set; }
        public List<Viajes> ListaViajes { get; set; } = new List<Viajes>();
        public Furgoneta(string placa, int Kilometraje, int Capacidad) : base(placa, Kilometraje)
        {
            this.Capacidad = Capacidad;
        }

        public override void AgregarViaje(Viajes viaje)
        {
            if (viaje.CargaTransportada > Capacidad)
            {
                Console.WriteLine($"La carga {viaje.CargaTransportada} supera la capacidad de la furgoneta {Capacidad}");
            }
            else
            {
                ListaViajes.Add(viaje);
                Kilometraje += viaje.Distancia;
            }
        }

        public override void DistanciaTotal()
        {

        }
    }
}
