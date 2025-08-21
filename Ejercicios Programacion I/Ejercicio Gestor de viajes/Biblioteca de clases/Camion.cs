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

        public Camion(string placa, int kilometraje, int Capacidad) 
            : base(placa, kilometraje)
        {
            this.Capacidad = Capacidad;
        }

        public override void DistanciaTotal()
        {
            
        }
        public override void AgregarViaje()
        {
            
        }

        public void CargaMaxima(int carga)
        {
            Console.WriteLine($"La carga máxima del camión es {Capacidad + carga} toneladas");
        }
    }
}
