using Biblioteca_de_clases;
using System;
using System.Collections.Generic;

namespace Parcial
{
    namespace Front
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Libro> listaLibros = new List<Libro>();
                bool salir = false;

                while (!salir)
                {
                    string opcion = IngresarString("Elija una opción:\n1.Registrar libro \n2.Registrar prestamo de un libro\n3.Mostrar informacion de un libro\n4.Mostrar todos los libros\n5.Salir");
                    Console.Clear();

                    switch (opcion)
                    {
                        case "1":
                            string tipoLibro = IngresarString("Ingrese si es \n1.Fisico \n2.Digital");
                            string titulo = IngresarString("Ingrese el Titulo del libro: ");
                            string autor = IngresarString("Ingrese el autor del libro: ");
                            int isbn = PedirEntero("Ingrese el codigo identificador: ");

                            bool existe = false;
                            foreach (var libro in listaLibros)
                            {
                                if (libro.ISBN == isbn)
                                {
                                    existe = true;
                                    break;
                                }
                            }

                            if (existe)
                                Console.WriteLine("Ya existe un libro con ese ISBN.");
                            else
                            {
                                if (tipoLibro == "1")
                                    listaLibros.Add(new LibroFisico(titulo, autor, isbn));
                                else
                                    listaLibros.Add(new LibroDigital(titulo, autor, isbn));

                                Console.WriteLine("Libro agregado con éxito.");
                            }
                            Console.ReadKey();
                            break;

                        case "2":
                            int isbnPrestamo = PedirEntero("Ingrese el ISBN del libro a retirar: ");
                            Libro libroParaPrestamo = null;

                            foreach (var libro in listaLibros)
                            {
                                if (libro.ISBN == isbnPrestamo)
                                {
                                    libroParaPrestamo = libro;
                                    break;
                                }
                            }

                            if (libroParaPrestamo == null)
                                Console.WriteLine("No existe un libro con ese ISBN.");
                            else if (!libroParaPrestamo.Disponible)
                                Console.WriteLine("El libro no está disponible actualmente.");
                            else
                            {
                                string nombreSocio = IngresarString("Ingrese el nombre del socio:");
                                int dniSocio = PedirEntero("Ingrese el DNI del socio:");
                                Socio socio = new Socio (nombreSocio, dniSocio);

                                DateTime fechaPrestamo = PedirFecha("Ingrese la fecha del préstamo (dd/MM/yyyy):");
                                int duracionDias = PedirEntero("Ingrese la duración del préstamo en días:");

                                libroParaPrestamo.Prestamos.Add(new Prestamo(fechaPrestamo, socio, duracionDias));

                                if (libroParaPrestamo is LibroFisico)
                                    libroParaPrestamo.Disponible = false;

                                Console.WriteLine("Préstamo registrado con éxito.");
                            }
                            Console.ReadKey();
                            break;

                        case "3":
                            int isbnConsulta = PedirEntero("Ingrese el ISBN del libro:");
                            Libro libroConsultado = null;

                            foreach (var libro in listaLibros)
                            {
                                if (libro.ISBN == isbnConsulta)
                                {
                                    libroConsultado = libro;
                                    break;
                                }
                            }

                            if (libroConsultado == null)
                                Console.WriteLine("No existe un libro con ese ISBN.");
                            else
                                libroConsultado.MostrarLibro();

                            Console.ReadKey();
                            break;

                        case "4":
                            Console.WriteLine("Listado de libros:");
                            int totalPrestamos = 0, totalFisicos = 0, totalDigitales = 0;

                            foreach (var libro in listaLibros)
                            {
                                libro.MostrarLibro();
                                totalPrestamos += libro.Prestamos.Count;
                                if (libro is LibroFisico)
                                    totalFisicos++;
                                else
                                    totalDigitales++;
                            }

                            Console.WriteLine($"\nEstadísticas:");
                            Console.WriteLine($"Total de préstamos: {totalPrestamos}");
                            Console.WriteLine($"Libros físicos: {totalFisicos}");
                            Console.WriteLine($"Libros digitales: {totalDigitales}");

                            Console.WriteLine("Ingrese una tecla para continuar");
                            Console.ReadKey();
                            break;

                        case "5":
                            salir = true;
                            Console.WriteLine("Saliendo el programa...");
                            break;

                        default:
                            Console.WriteLine("Opción inexistente");
                            Console.ReadKey();
                            break;
                    }
                }
            }

            public static int PedirEntero(string mensaje)
            {
                int numero;
                Console.WriteLine(mensaje);
                while (!int.TryParse(Console.ReadLine(), out numero))
                    Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                return numero;
            }

            public static DateTime PedirFecha(string mensaje)
            {
                DateTime fecha;
                Console.WriteLine(mensaje);
                string input = Console.ReadLine();

                while (DateTime.TryParseExact(input, "dd/MM/yyyy", null,
                        System.Globalization.DateTimeStyles.None, out fecha) == false)
                {
                    Console.WriteLine("Fecha inválida, ingrese nuevamente (dd/MM/yyyy):");
                    input = Console.ReadLine();
                }

                return fecha;
            }


            public static string IngresarString(string mensaje)
            {
                Console.WriteLine(mensaje);
                string palabra = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(palabra))
                {
                    Console.WriteLine("Valor incorrecto, ingreselo nuevamente:");
                    palabra = Console.ReadLine();
                }
                return palabra;
            }
        }
    }
}
