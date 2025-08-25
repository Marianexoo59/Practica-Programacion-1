namespace Biblioteca_de_clases
{
    public abstract class Vehiculo
    {
        public string Placa { get; set; }
        public int Kilometraje { get; set; }
        public List<Viajes> ListaViajes { get; set; } = new List<Viajes>();

        public Vehiculo(string Placa, int Kilometraje)
        {
            this.Placa = Placa;
            this.Kilometraje = Kilometraje;
        }
        public virtual void AgregarViaje(Viajes viaje)
        {
            ListaViajes.Add(viaje);
            Kilometraje += viaje.Distancia;
        }
        public virtual void DistanciaTotal()
        {
            Console.WriteLine($"Distancia total recorrida por la motocicleta: {Kilometraje} km");
        }
    }
}
