using Personaje;
using System.ComponentModel;
using static Personaje.Personaje;

namespace Programcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personaje.Personaje> personajesCreados = new List<Personaje.Personaje>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1- Registrar personajes (Guerrero, Mago, Arquero).\r\n2- Ver lista de personajes creados.\r\n3- Iniciar un combate entre dos personajes.\r\n4- Ver historial de combates.\r\n5- Ver estadísticas globales de cada personaje.\r\n6- Salir.\r\n");
                
                int eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        int contador = 0;
                        Console.WriteLine($"Registre su personaje N#{contador + 1} \n1 Guerrero \n2 Mago \n3 Arquero");
                        int personaje = int.Parse(Console.ReadLine());

                        switch (personaje)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el nombre del Guerrero: ");
                                string nombreGuerrero = Console.ReadLine();
                                Console.WriteLine("Ingrese el nivel del Guerrero: ");
                                int nivelGuerrero = int.Parse(Console.ReadLine());
                                Guerrero nuevoGuerrero = new Guerrero(nombreGuerrero,nivelGuerrero);
                                personajesCreados.Add(nuevoGuerrero);
                                ControlDePersonajes.ListaPersonajes.Add(nuevoGuerrero);

                                break;

                            case 2:
                                Console.WriteLine("Ingrese el nombre del Mago: ");
                                string nombreMago = Console.ReadLine();
                                Console.WriteLine("Ingrese el nivel del Mago: ");
                                int nivelMago = int.Parse(Console.ReadLine());
                                Mago nuevoMago = new Mago(nombreMago, nivelMago);
                                personajesCreados.Add(nuevoMago);
                                ControlDePersonajes.ListaPersonajes.Add(nuevoMago);

                                break;

                            case 3:
                                Console.WriteLine("Ingrese el nombre del Arquero: ");
                                string nombreArquero = Console.ReadLine();
                                Console.WriteLine("Ingrese el nivel del Arquero: ");
                                int nivelArquero = int.Parse(Console.ReadLine());
                                Arquero nuevoArquero = new Arquero(nombreArquero, nivelArquero);
                                ControlDePersonajes.ListaPersonajes.Add(nuevoArquero);
                                personajesCreados.Add(nuevoArquero);
                                break;
                        }


                        break;

                    case 2:
                        foreach (var variable in personajesCreados)
                        {
                            Console.WriteLine($"{variable.Nombre}, {variable.GetType().Name}"); 
                        }
                        Console.WriteLine("\nPresione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Elija el primer personaje para batallar:");
                        for (int i = 0; i < ControlDePersonajes.ListaPersonajes.Count; i++)
                        {

                            Console.WriteLine($"{i + 1}. {ControlDePersonajes.ListaPersonajes[i].GetType().Name} {ControlDePersonajes.ListaPersonajes[i].Nombre}");

                        }
                        string input1 = Console.ReadLine();
                        int eleccionPersonaje1;
                        bool conversion1 = int.TryParse(input1, out eleccionPersonaje1);
                        while (conversion1 == false || eleccionPersonaje1 < 1 || eleccionPersonaje1 > ControlDePersonajes.ListaPersonajes.Count)
                        {
                            Console.WriteLine("Valor incorrecto, ingrese otro:");
                            input1 = Console.ReadLine();
                            conversion1 = int.TryParse(input1, out eleccionPersonaje1);

                        }
                        Personaje.Personaje personaje1 = ControlDePersonajes.ListaPersonajes[eleccionPersonaje1 - 1];
                        var ListaTemporalParaSegundo = ControlDePersonajes.ListaPersonajes.Where(x => x != personaje1).ToList();
                        Console.WriteLine("Elija el segundo personaje para batallar:");
                        for (int i = 0; i < ListaTemporalParaSegundo.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ListaTemporalParaSegundo[i].GetType().Name} {ListaTemporalParaSegundo[i].Nombre}");
                        }
                        input1 = Console.ReadLine();
                        int eleccionPersonaje2;
                        conversion1 = int.TryParse(input1, out eleccionPersonaje2);
                        while (conversion1 == false || eleccionPersonaje2 < 1 || eleccionPersonaje2 > ListaTemporalParaSegundo.Count)
                        {
                            Console.WriteLine("Valor incorrecto, ingrese otro:");
                            input1 = Console.ReadLine();
                            conversion1 = int.TryParse(input1, out eleccionPersonaje2);

                        }
                        string Ganador = string.Empty; 
                        int Turnos = 0; 
                        int Ganadas = 0; 


                        Personaje.Personaje personaje2 = ListaTemporalParaSegundo[eleccionPersonaje2 - 1];
                        var combate = new RegistroCombate(personaje1, personaje2,Ganador, Turnos, Ganadas)
                        {
                            Personaje1 = personaje1,
                            Personaje2 = personaje2,
                            Ganador = Ganador,
                            Turnos = Turnos
                        };
                        HistorialCombates.RegistroCombates.Add(combate);
                        combate.Combate();
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 4:
                        var listatemportal = HistorialCombates.RegistroCombates.OrderByDescending(c => c.Turnos).ToList();
                        foreach (var comb in listatemportal)
                        {
                            Console.WriteLine($"{comb.Personaje1.Nombre} vs {comb.Personaje2.Nombre} - Ganador: {comb.Ganador} - Turnos: {comb.Turnos}");

                        }
                        break;

                    case 5:
                        Console.WriteLine();
                        break;

                    case 6:
                        break;
                }
            }
        }
    }
}
