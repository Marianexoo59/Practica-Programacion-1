using Biblioteca_de_clases;

namespace Gestor_de_viajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eliga la opcion para usar: 1. Agregar un vehiculo \n 2. Registrar un viaje para un vehiculo \n3 . Mostrar informacion del vehiculo \n4. Mostrar todos los vehiculos y estadisticas generales \n5. Mostrar todas las patentes");
            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    {
                        Console.WriteLine("Que vehiculo desea agregar? \n1. Camion \n2. Furgoneta \n3. Motocicleta");
                        int eleccionVehiculo = int.Parse(Console.ReadLine());

                        switch (eleccionVehiculo)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Ingrese la patente: ");
                                    string placa = Console.ReadLine();
                                    int kilometraje = PedirEntero("Ingrese el kilometraje");
                                    int Capacidad = PedirEntero("Ingrese la carga del camion: ");
                                    Camion camion = new Camion(placa, kilometraje, Capacidad);
                                    Vehiculo.NuevoVehiculo.Add(camion);
                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Ingrese la patente: ");
                                    string placa = Console.ReadLine();
                                    int kilometraje = PedirEntero("Ingrese el kilometraje");
                                    int Capacidad = PedirEntero("Ingrese la carga de la furgoneta: ");
                                    Furgoneta furgoneta = new Furgoneta(placa, kilometraje, Capacidad);
                                    Vehiculo.NuevoVehiculo.Add(furgoneta);
                                    break;
                                }

                            case 3:
                                {
                                    Console.WriteLine("Ingrese la patente: ");
                                    string placa = Console.ReadLine();
                                    int kilometraje = PedirEntero("Ingrese el kilometraje");
                                    int Capacidad = PedirEntero("Ingrese la carga: ");
                                    Motocicleta moto = new Motocicleta(placa, kilometraje, Capacidad);
                                    Vehiculo.NuevoVehiculo.Add(moto);
                                    break;
                                }
                        }
                        break;
                    }
                    
            }
        }
        public static int PedirEntero(string mensaje)
        {

            int num;
            Console.WriteLine(mensaje);
            while (int.TryParse(Console.ReadLine(), out num) == false)
            {

                Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");

            }

            return num;

        }
    }

}
