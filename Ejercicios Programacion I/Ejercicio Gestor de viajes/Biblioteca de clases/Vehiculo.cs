namespace Biblioteca_de_clases
{
    public abstract class Vehiculo
    {
        public string Placa { get; set; }
        public int Kilometraje { get; set; }
        
        public static List<Vehiculo> NuevoVehiculo = new List<Vehiculo>();

        public Vehiculo(string Placa, int Kilometraje)
        {
            this.Placa = Placa;
            this.Kilometraje = Kilometraje;
        }
        public abstract void AgregarViaje();

        public abstract void DistanciaTotal();
    }
}
