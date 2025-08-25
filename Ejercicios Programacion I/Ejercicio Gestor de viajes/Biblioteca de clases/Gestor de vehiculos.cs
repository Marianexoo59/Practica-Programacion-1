using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
    public class Gestor_de_vehiculos
    {
        public static List<Vehiculo> Vehiculos = new List<Vehiculo>();

        public void MostrarPatentesTipo()
        {
            foreach (var variable in Vehiculos)
            {
                Console.WriteLine($"Tipo: {variable.GetType().Name}, Patente: {variable.Placa}");
            }
        }

        public void EstadisticasAgregadas()
        {
            int distanciaTotal = 0;
            int cargaTotal = 0;
            int cantidadVehiculos = 0;

            for (int i  = 0; i < Vehiculos.Count; i++)
            {
                var vehiculo = Vehiculos[i];

                foreach (var viaje in vehiculo.ListaViajes)
                {
                    distanciaTotal += viaje.Distancia;
                    cargaTotal += viaje.CargaTransportada;
                    cantidadVehiculos++;

                    Console.WriteLine($"Distancias total: {distanciaTotal} \nTotal de cargas: {cargaTotal} \nTotal Vehiculos: {cantidadVehiculos}");
                }
            }
        }

        public void MostrarEstadisticas()
        {

            for (int i = 0; i < Vehiculos.Count; i++)
            {
                var variable = Vehiculos[i];
                Console.WriteLine($"Tipo {variable.GetType().Name}");

                foreach (var varia in variable.ListaViajes)
                {
                    Console.WriteLine($"Km: {variable.Kilometraje}, Viajes {variable.ListaViajes}");
                }
            }
        }

        public void MostrarVehiculo(Vehiculo variable)
        {
            Console.WriteLine("Información del vehículo seleccionado ");
            Console.WriteLine($"Tipo: {variable.GetType().Name}");
            Console.WriteLine($"Placa: {variable.Placa}, Km: {variable.Kilometraje}, Cantidad de viajes: {variable.ListaViajes.Count}");

            foreach (var viaje in variable.ListaViajes)
            {
                Console.WriteLine($"Distancia: {viaje.Distancia}, Carga: {viaje.CargaTransportada}, Fecha: {viaje.Fecha}");
            }
        }


        public Vehiculo ElegirVehiculo()
        {
            while (true) // Sigue preguntando hasta que elija un vehículo válido
            {
                Console.WriteLine("Elija el vehículo a mostrar la información:");

                for (int i = 0; i < Vehiculos.Count; i++)
                {
                    var var = Vehiculos[i];
                    Console.WriteLine($"{i + 1}. Placa: {var.Placa}");
                }
                string? eleccion = Console.ReadLine();

                if (int.TryParse(eleccion, out int opcion) && opcion >= 1 && opcion <= Vehiculos.Count)
                {
                    return Vehiculos[opcion - 1]; // Vehículo elegido correctamente
                }
                Console.WriteLine("Opción inválida, intente nuevamente.");
            }
        }
    }
}
