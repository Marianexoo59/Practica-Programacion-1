using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Camion : Vehiculo
    {
        public int Capacidad { get; set; }

        public List<Viajes> ListaViajes { get; set; } = new List<Viajes>();

        public Camion(string placa, int kilometraje, int Capacidad) : base(placa, kilometraje)
        {
            this.Capacidad = Capacidad;
        }

        public override void DistanciaTotal()
        {
            Console.WriteLine($"El camión con placa {Placa} ha recorrido un total de {Kilometraje} km.");
        }
        public override void AgregarViaje(Viajes viaje)
        {
            if (viaje.CargaTransportada > Capacidad)
            {
                Console.WriteLine($"La carga {viaje.CargaTransportada} supera a la capacidad del camion {Capacidad}");
            }
            else
            {
                ListaViajes.Add(viaje);
                Kilometraje += viaje.Distancia;
            }
        }

        public void CargaMaxima()
        {
            Console.WriteLine($"La capacidad máxima del camión es {Capacidad} toneladas");
        }
    }
}
