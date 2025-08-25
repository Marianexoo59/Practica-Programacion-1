using Biblioteca_de_clases;

namespace Gestor_de_viajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (true)
            {

                Console.WriteLine("Eliga la opcion para usar: \n 1. Agregar un vehiculo \n 2. Registrar un viaje para un vehiculo \n 3. Mostrar informacion del vehiculo \n 4. Mostrar todos los vehiculos y estadisticas generales \n 5. Mostrar todas las patentes \n 6. Salir");
                int eleccion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (eleccion)
                {
                    case 1:
                        {
                            Console.WriteLine("Que vehiculo desea agregar? \n1. Camion \n2. Furgoneta \n3. Motocicleta");
                            int eleccionVehiculo = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (eleccionVehiculo)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Ingrese la patente: ");
                                        string placa = Console.ReadLine();

                                        bool existe = false;
                                        foreach (var var in Gestor_de_vehiculos.Vehiculos)
                                        {
                                            if (var.Placa == placa)
                                            {
                                                existe = true;
                                                break;
                                            }
                                        }
                                        if (existe)
                                        {
                                            Console.WriteLine("Ya existe un vehículo con esa placa. No se puede agregar.");
                                            break;
                                        }

                                        int kilometraje = PedirEntero("Ingrese el kilometraje");
                                        int Capacidad = PedirEntero("Ingrese la carga del camion: ");
                                        Camion camion = new Camion(placa, kilometraje, Capacidad);
                                        Gestor_de_vehiculos.Vehiculos.Add(camion);
                                        Console.Clear();
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.WriteLine("Ingrese la patente: ");
                                        string placa = Console.ReadLine();

                                        bool existe = false;
                                        foreach (var var in Gestor_de_vehiculos.Vehiculos)
                                        {
                                            if (var.Placa == placa)
                                            {
                                                existe = true;
                                                break;
                                            }
                                        }
                                        if (existe)
                                        {
                                            Console.WriteLine("Ya existe un vehículo con esa placa. No se puede agregar.");
                                            break;
                                        }
                                        int kilometraje = PedirEntero("Ingrese el kilometraje");
                                        int Capacidad = PedirEntero("Ingrese la carga de la furgoneta: ");
                                        string Fecha = Console.ReadLine();
                                        Furgoneta furgoneta = new Furgoneta(placa, kilometraje, Capacidad);
                                        Gestor_de_vehiculos.Vehiculos.Add(furgoneta);
                                        Console.Clear();
                                        break;
                                    }

                                case 3:
                                    {

                                        Console.WriteLine("Ingrese la patente: ");
                                        string placa = Console.ReadLine();

                                        bool existe = false;
                                        foreach (var var in Gestor_de_vehiculos.Vehiculos)
                                        {
                                            if (var.Placa == placa)
                                            {
                                                existe = true;
                                                break;
                                            }
                                        }
                                        if (existe)
                                        {
                                            Console.WriteLine("Ya existe un vehículo con esa placa. No se puede agregar.");
                                            break;
                                        }

                                        int kilometraje = PedirEntero("Ingrese el kilometraje");
                                        int Capacidad = PedirEntero("Ingrese la carga: ");
                                        Motocicleta moto = new Motocicleta(placa, kilometraje);
                                        Gestor_de_vehiculos.Vehiculos.Add(moto);
                                        Console.Clear();
                                        break;
                                    }

                            }
                            Console.Clear();
                            break;
                        }

                    case 2:
                        Console.WriteLine("Elija vehiculo para viaje: ");
                        Console.WriteLine("Vehiculos disponibles ");
                        var gestor = new Gestor_de_vehiculos();
                        var elegido = gestor.ElegirVehiculo();
                        gestor.MostrarVehiculo(elegido);

                        if (elegido != null)
                        {
                            Console.WriteLine($"\nEl vehiculo con placa: {elegido.Placa} fue seleccionado con exito!");
                            int DistanciaRecorrida = PedirEntero("Ingrese la distancia del viaje: ");
                            int Carga = 0;
                            if ((elegido is Camion || elegido is Furgoneta))
                            {
                                Carga = PedirEntero("Ingrese la carga del viaje: ");
                                Console.WriteLine("El viaje se ha registrado con exito");
                            }
                            Viajes nuevoviaje = new Viajes(DistanciaRecorrida, Carga, DateTime.Now);
                            elegido.ListaViajes.Add(nuevoviaje);
                        }
                        else
                        {
                            Console.WriteLine("\nNo se seleccionó ningún vehículo válido.");
                        }
                        Console.Clear();
                        break;

                    case 3:
                        var Gestor = new Gestor_de_vehiculos();
                        var Elegido = Gestor.ElegirVehiculo();
                        Gestor.MostrarVehiculo(Elegido);
                        break;

                    case 4:
                        var gestorcito = new Gestor_de_vehiculos();
                        gestorcito.MostrarEstadisticas();
                        gestorcito.EstadisticasAgregadas();
                        break;

                    case 5:
                        var muestra = new Gestor_de_vehiculos();
                        muestra.MostrarPatentesTipo();
                        break;

                    case 6:
                        Console.WriteLine("Saliendo el programa");
                        salir = true;
                        break;
                }

                if (salir)
                    break;
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
