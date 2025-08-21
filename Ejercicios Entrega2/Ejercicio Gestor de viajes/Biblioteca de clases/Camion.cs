using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    internal class Camion : Vehiculo
    {
        public int CargaAdicional { get; set; }

        public Camion(int placa, int kilometraje, int viajes, int cargaAdicional, int Capacidad) : base(placa, kilometraje, viajes, Capacidad}
    )
        {
            this.CargaAdicional = cargaAdicional;
        }

        public void CargaMaxima(int CargaAdicional)
        {
            
        }

        public override void DistanciaTotal()
        {

        }

        public override void AgregarViaje()
        {

        }
    }
}
