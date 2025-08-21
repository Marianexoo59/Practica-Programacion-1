namespace Biblioteca_de_clases
{
    public abstract class Vehiculo
    {
        public int Placa { get; set; }
        public int Kilometraje { get; set; }
        public int Viajes { get; set; }

        public double Capacidad { get; set; }

        public Vehiculo(int Placa, int Kilometraje, int Viajes, double capacidad)
        {
            this.Placa = Placa;
            this.Kilometraje = Kilometraje;
            this.Viajes = Viajes;
            Capacidad = capacidad;
        }
        public abstract void AgregarViaje();

        public abstract void DistanciaTotal();
    }
}
